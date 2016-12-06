<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ViewHigherLogicFeed.ascx.cs" Inherits="Engage.Dnn.HigherLogicFeed.ViewHigherLogicFeed" %>

<%: this.Model.HeaderTemplate %>

<% if (this.Model.HasRecords) { %>
    <%: this.Model.ItemTemplate %>

<% } else { %>
    <%: this.Model.NoRecordsTemplate %>
<% } %>

<%: this.Model.FooterTemplate %>
