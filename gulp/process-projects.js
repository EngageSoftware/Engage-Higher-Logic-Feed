/*eslint-env node*/
/*eslint no-console:0*/
'use strict';

const path = require('path');
const _ = require('lodash');
const glob = require('glob');
const Project = require('./Project');
const gitignoreFilter = require('./gitignore-filter');
const configOptions = require('../gulpfile.config');

module.exports = function processProjects() {
    const projectFolders = glob.sync('**/*.dnn', { nocase: true, })
        .filter(gitignoreFilter.filter)
        .map((dnnFile) => path.dirname(dnnFile));
    const folderGroups = _.groupBy(
        projectFolders,
        (folder) => (folder.includes('/DesktopModules/') && path.basename(folder) !== 'Templates'
                    ? 'modules'
                    : folder.includes('/Portals/_default/Skins/')
                        ? 'themes'
                        : 'others'));
    folderGroups.modules = folderGroups.modules || [];
    folderGroups.themes = folderGroups.themes || [];
    folderGroups.others = folderGroups.others || [];
    const moduleProjects = folderGroups.modules
        .map((moduleFolder) => {
        const folderName = path.basename(moduleFolder);
        const moduleProject = new Project(
            `${folderName}-module`,
            moduleFolder,
            { stylesDirPath: moduleFolder, });
        moduleProject.lessEntryFilesGlobs = [ path.join(moduleFolder, '**/module.less'), ];
        const testScriptsGlob = path.join(moduleFolder, '*.Tests/Scripts/**/*.js');
        moduleProject.javaScriptFilesGlobs.push(`!${testScriptsGlob}`);
        const nugetScriptsGlob = path.join(moduleFolder, 'packages/**/*.js');
        moduleProject.javaScriptFilesGlobs.push(`!${nugetScriptsGlob}`);
        return moduleProject;
    });

    const themeProjects = folderGroups.themes
        .map((themeFolder) => {
            const folderName = path.basename(themeFolder);
            return new Project(`${folderName}-theme`, themeFolder);
        });
    const otherProjects = folderGroups.others
        .map((folder) => {
            const folderName = path.basename(folder);

            let name;
            if (folderName === 'Templates') {
                name = path.basename(path.dirname(folder));
            } else {
                name = folderName;
            }

            return new Project(`${name}-templates`, folder);
        });

    return require('../gulpfile.user').customizeProjects(
        configOptions.customizeProjects({
            moduleProjects,
            themeProjects,
            otherProjects,
        }));
};
