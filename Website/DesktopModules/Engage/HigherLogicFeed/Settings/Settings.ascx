<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="Settings.ascx.cs" Inherits="Engage.Dnn.HigherLogicFeed.Settings" %>
<%@ Import Namespace="Engage.Util" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>

<div class="dnnForm" id="HigherLogicSettings">
    <h2 class="dnnFormSectionHead"><a href="#"><%: this.LocalizeString("MainSettings.Text") %></a></h2>
    <fieldset class="dnnClear">
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="HLUserNameTxt" ResourceKey="HLUserName.Text" HelpKey="HLUserName.Help" />
            <asp:TextBox runat="server" ID="HLUserNameTxt" CssClass="dnnFormRequired" Text="<%#: this.Model.HigherLogicUserName %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="HLUserNameTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="HLUserName.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="HLPasswordTxt" ResourceKey="HLPassword.Text" HelpKey="HLPassword.Help" />
            <asp:TextBox runat="server" ID="HLPasswordTxt" CssClass="dnnFormRequired" TextMode="Password" Value="<%#: this.Model.HigherLogicPassword %>" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="HLIAMKeyTxt" ResourceKey="HLIAMKey.Text" HelpKey="HLIAMKey.Help" />
            <asp:TextBox runat="server" ID="HLIAMKeyTxt" CssClass="dnnFormRequired" Text="<%#: this.Model.HigherLogicIAMKey %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="HLIAMKeyTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="HLIAMKey.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="DiscussionKeyTxt" ResourceKey="DiscussionKey.Text" HelpKey="DiscussionKey.Help" />
            <asp:TextBox runat="server" ID="DiscussionKeyTxt" CssClass="dnnFormRequired" Text="<%#: this.Model.HigherLogicDiscussionKey %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="DiscussionKeyTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="DiscussionKey.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="MaxToRetrieveTxt" ResourceKey="MaxToRetrieve.Text" HelpKey="MaxToRetrieve.Help" />
            <asp:TextBox runat="server" ID="MaxToRetrieveTxt" CssClass="dnnFormRequired" TextMode="Number" min="0" Text="<%#: this.Model.MaxDiscussionsToRetrieve %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="MaxToRetrieveTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="MaxToRetrieve.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="MaxContentLengthTxt" ResourceKey="MaxContentLength.Text" HelpKey="MaxContentLength.Help" />
            <asp:TextBox runat="server" ID="MaxContentLengthTxt" CssClass="dnnFormRequired" TextMode="Number" min="0" Text="<%#: this.Model.MaxContentLength %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="MaxContentLengthTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="MaxContentLength.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="MaxSubjectLengthTxt" ResourceKey="MaxSubjectLength.Text" HelpKey="MaxSubjectLength.Help" />
            <asp:TextBox runat="server" ID="MaxSubjectLengthTxt" CssClass="dnnFormRequired" TextMode="Number" min="0" Text="<%#: this.Model.MaxSubjectLength %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="MaxSubjectLengthTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="MaxSubjectLength.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="IncludeStaffChk" ResourceKey="IncludeStaff.Text" HelpKey="IncludeStaff.Help" />
            <asp:CheckBox runat="server" ID="IncludeStaffChk" Checked="<%# this.Model.IncludeStaff %>" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="DateFormatTxt" ResourceKey="DateFormat.Text" HelpKey="DateFormat.Help" />
            <asp:TextBox runat="server" ID="DateFormatTxt" CssClass="dnnFormRequired" Text="<%#: this.Model.DateFormat %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="DateFormatTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="DateFormat.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="HeaderTemplateTxt" ResourceKey="HeaderTemplate.Text" HelpKey="HeaderTemplate.Help" />
            <asp:TextBox runat="server" ID="HeaderTemplateTxt" CssClass="dnnFormRequired" TextMode="MultiLine" Text="<%#: this.Model.HeaderTemplate.AsRawHtml() %>" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="ItemTemplateTxt" ResourceKey="ItemTemplate.Text" HelpKey="ItemTemplate.Help" />
            <asp:TextBox runat="server" ID="ItemTemplateTxt" CssClass="dnnFormRequired" TextMode="MultiLine" Text="<%#: this.Model.ItemTemplate.AsRawHtml() %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="ItemTemplateTxt"
                CssClass="dnnFormMessage dnnFormError" ResourceKey="ItemTemplate.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="NoRecordsTemplateTxt" ResourceKey="NoRecordsTemplate.Text" HelpKey="NoRecordsTemplate.Help" />
            <asp:TextBox runat="server" ID="NoRecordsTemplateTxt" CssClass="dnnFormRequired" TextMode="MultiLine" Text="<%#: this.Model.NoRecordsTemplate.AsRawHtml() %>" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="FooterTemplateTxt" ResourceKey="FooterTemplate.Text" HelpKey="FooterTemplate.Help" />
            <asp:TextBox runat="server" ID="FooterTemplateTxt" CssClass="dnnFormRequired" TextMode="MultiLine" Text="<%#: this.Model.FooterTemplate.AsRawHtml() %>" />
        </div>
        <div class="dnnFormItem">
            <dnn:label runat="server" ControlName="AttachmentItemTemplateTxt" ResourceKey="AttachmentItemTemplate.Text" HelpKey="AttachmentItemTemplate.Help" />
            <asp:TextBox runat="server" ID="AttachmentItemTemplateTxt" CssClass="dnnFormRequired" TextMode="MultiLine" Text="<%#: this.Model.AttachmentItemTemplate.AsRawHtml() %>" />
        </div>
    </fieldset>
    <h2 class="dnnFormSectionHead"><a href="#"><%: this.LocalizeString("DnnTokenSettings.Text") %></a></h2>
    <fieldset class="dnnClear">
        <div class="dnnFormItem">
            <table class="dnnGrid" width="100%">
                <thead>
                    <tr class="dnnGridHeader">
                        <th>Token</th>
                        <th>Description</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class="dnnGridItem">
                        <td>[Portal:Description]</td>
                        <td>Portal Description</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Portal:Email]</td>
                        <td>Portal Admin Email</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Portal:FooterText]</td>
                        <td>Portal Copyright Text</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Portal:HomeDirectory]</td>
                        <td>Portal Path (relative) of Home Directory</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Portal:LogoFile]</td>
                        <td>Portal Path to Logo File</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Portal:PortalName]</td>
                        <td>Portal Name</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Portal:PortalAlias]</td>
                        <td>Portal URL</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Portal:TimeZoneOffset]</td>
                        <td>Difference in Minutes between Portal Default Time and UTC</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[User:DisplayName]</td>
                        <td>User's Display Name</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[User:Email]</td>
                        <td>User's Email Address</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[User:FirstName]</td>
                        <td>User's First Name</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[User:LastName]</td>
                        <td>User's Last Name</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[User:Username]</td>
                        <td>User's Login User Name</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Membership:Approved]</td>
                        <td>Is User Approved?</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Membership:CreatedOnDate]</td>
                        <td>User Signup Date</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Membership:IsOnline]</td>
                        <td>Is User Currently Online?</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Profile:]</td>
                        <td>Use any default or custom Profile Property as listed in Profile Property Definition section of Manage User Accounts. Use non-localized Property Name only.</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:Description]</td>
                        <td>Page Description Text for Search Engine</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:EndDate]</td>
                        <td>Page Display Until Date</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:FullUrl]</td>
                        <td>Page Full URL</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:IconFile]</td>
                        <td>Page Relative Path to Icon File</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:KeyWords]</td>
                        <td>Page Keywords for Search Engine</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:PageHeadText]</td>
                        <td>Page Header Text</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:StartDate]</td>
                        <td>Page Display from Date</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:TabName]</td>
                        <td>Page Name</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:TabPath]</td>
                        <td>Page Relative Path</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:Title]</td>
                        <td>Page Title (Window Title)</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Tab:URL]</td>
                        <td>Page URL</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:Description]</td>
                        <td>Module Definition Description</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:EndDate]</td>
                        <td>Module Display Until Date</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:Footer]</td>
                        <td>Module Footer Text</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:FriendlyName]</td>
                        <td>Module Definition Name</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:Header]</td>
                        <td>Module Header Text</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:HelpURL]</td>
                        <td>Module Help URL</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:IconFile]</td>
                        <td>Module Path to Icon File</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:ModuleTitle]</td>
                        <td>Module Title</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:PaneName]</td>
                        <td>Module Name of Pane (where the module resides)</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Module:StartDate]</td>
                        <td>Module Display from Date</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[DateTime:Now]</td>
                        <td>Current Date and Time</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Ticks:Now]</td>
                        <td>CPU Tick Count for Current Second</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Ticks:Today]</td>
                        <td>CPU Tick Count since Midntdht</td>
                    </tr>
                    <tr class="dnnGridItem">
                        <td>[Ticks:TicksPerDay]</td>
                        <td>CPU Ticks per Day (for calculations)</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </fieldset>
    <h2 class="dnnFormSectionHead"><a href="#"><%: this.LocalizeString("HLTokenSettings.Text") %></a></h2>
    <fieldset class="dnnClear">
        <div class="dnnFormItem">
            <table class="dnnGrid" width="100%">
                <thead>
                    <tr class="dnnGridHeader">
                        <th>Token</th>
                        <th>Description</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:Body]</td>
                      <td>The body of the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:BodyWithoutMarkup]</td>
                      <td>The body of the discussion post without the HTML markup.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:DiscussionName]</td>
                      <td>The name of the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:EmailAddress]</td>
                      <td>The email address of the author for the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:LinkToDiscussion]</td>
                      <td>The link to the discussion post details page.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:LinkToMessage]</td>
                      <td>The link to the discussion message.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:LinkToMessageInContext]</td>
                      <td>The link to the context within the discussion message.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:MessageStatus]</td>
                      <td>The current status of the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:ModerationType]</td>
                      <td>The active moderation type for the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:Subject]</td>
                      <td>The subject of the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:ContactKey]</td>
                      <td>The author's contact Id.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:DiscussionPostKey]</td>
                      <td>The discussion post Id.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:DiscussionKey]</td>
                      <td>The discussion Id.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:DatePosted]</td>
                      <td>The posted date for the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:Pinned]</td>
                      <td>True is the discussion post has been pinned in higher logic.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:RecommendationCount]</td>
                      <td>The recommendation count for the discussion post.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Discussion:Attachments]</td>
                      <td>The attachments rendered with the attachment template.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:LinkToProfile]</td>
                      <td>The link to the author's profile.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:PictureUrl]</td>
                      <td>The link to the author's profile image.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:ContactKey]</td>
                      <td>The contact Id of the auhtor.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:FirstName]</td>
                      <td>The first name of the author.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:LastName]</td>
                      <td>The last name of the author.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:DisplayName]</td>
                      <td>The display name of the author.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:EmailAddress]</td>
                      <td>The email address of the author.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:CompanyName]</td>
                      <td>The company name of the author.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:CompanyTitle]</td>
                      <td>The author's job title.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:Designation]</td>
                      <td>The author's designation.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Author:MiddleName]</td>
                      <td>The middle name of the author.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:DocumentAttachmentKey]</td>
                      <td>The attachment Id.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:DocumentKey]</td>
                      <td>The document Id for the attachment.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:FileName]</td>
                      <td>The name of the attachment file.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:UploadedByContact]</td>
                      <td>The contact Id of the user that uploaded the attachment.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:CreatedOn]</td>
                      <td>The date the attachment was created.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:FileExtension]</td>
                      <td>The file extension for the attachment.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:FileSizeInBytes]</td>
                      <td>The file size for the attachment.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:Width]</td>
                      <td>The width of the attachment.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:Height]</td>
                      <td>The height of the attachment.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:DurationSeconds]</td>
                      <td>The duration in seconds of the attachment, if it is a video.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:DownloadUrl]</td>
                      <td>The download URL of the attachment.</td>
                    </tr>
                    <tr class="dnnGridItem">
                      <td>[HL:Attachment:IconUrl]</td>
                      <td>The icon URL of the attachment.</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </fieldset>
</div>
<script type="text/javascript">
    jQuery(function ($) {
        var setupModule = function () {
            $('#HigherLogicSettings').dnnPanels();
        };
        setupModule();
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
            setupModule();
        });
    });
</script>
