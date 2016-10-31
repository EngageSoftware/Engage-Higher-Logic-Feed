<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="Settings.ascx.cs" Inherits="Engage.Dnn.HigherLogicFeed.Settings" %>
<%@ Register TagPrefix="dnn" TagName="label" src="~/controls/LabelControl.ascx" %>

<div class="dnnForm">
    <fieldset>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="HLUserNameTxt" ResourceKey="HLUserName.Text" HelpKey="HLUserName.Help" />
            <asp:TextBox runat="server" ID="HLUserNameTxt" CssClass="dnnFormRequired" Text="<%# this.Model.HigherLogicUserName %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="HLUserNameTxt" 
                CssClass="dnnFormMessage dnnFormError" ResourceKey="HLUserName.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="HLPasswordTxt" ResourceKey="HLPassword.Text" HelpKey="HLPassword.Help" />
            <asp:TextBox runat="server" ID="HLPasswordTxt" CssClass="dnnFormRequired" TextMode="Password" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="HLIAMKeyTxt" ResourceKey="HLIAMKey.Text" HelpKey="HLIAMKey.Help" />
            <asp:TextBox runat="server" ID="HLIAMKeyTxt" CssClass="dnnFormRequired" Text="<%# this.Model.HigherLogicIAMKey %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="HLIAMKeyTxt" 
                CssClass="dnnFormMessage dnnFormError" ResourceKey="HLIAMKey.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="DiscussionKeyTxt" ResourceKey="DiscussionKey.Text" HelpKey="DiscussionKey.Help" />
            <asp:TextBox runat="server" ID="DiscussionKeyTxt" CssClass="dnnFormRequired" Text="<%# this.Model.HigherLogicDiscussionKey %>" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="DiscussionKeyTxt" 
                CssClass="dnnFormMessage dnnFormError" ResourceKey="DiscussionKey.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="MaxToRetrieveTxt" ResourceKey="MaxToRetrieve.Text" HelpKey="MaxToRetrieve.Help" />
            <asp:TextBox runat="server" ID="MaxToRetrieveTxt" CssClass="dnnFormRequired" TextMode="Number" min="0" Text="<%# this.Model.MaxDiscussionsToRetrieve %>"/>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="MaxToRetrieveTxt" 
                CssClass="dnnFormMessage dnnFormError" ResourceKey="MaxToRetrieve.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="IncludeStaffChk" ResourceKey="IncludeStaff.Text" HelpKey="IncludeStaff.Help" />
            <asp:CheckBox runat="server" ID="IncludeStaffChk" Checked="<%# this.Model.IncludeStaff %>" />
        </div>
    </fieldset>
</div>
            