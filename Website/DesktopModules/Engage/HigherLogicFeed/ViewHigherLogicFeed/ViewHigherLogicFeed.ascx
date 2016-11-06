<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ViewHigherLogicFeed.ascx.cs" Inherits="Engage.Dnn.HigherLogicFeed.ViewHigherLogicFeed" %>
<%@Import namespace="DotNetNuke.Common.Utilities" %>
<%@ Import Namespace="Engage.Util" %>

<div class="border">
    <div class="container">
        <ul>
            <% if (this.Model.DiscussionPosts.Count() > 0) { %>
                <% foreach (var discussion in this.Model.DiscussionPosts) { %>
                <li>
                    <div class="item-header-container">
                        <div class="item-image-container" biobubblekey="<%: discussion.Author.ContactKey %>">
                            <a href="<%: discussion.Author.LinkToProfile %>" class="user-image-container">
                                <img class="item-image" src="<%: discussion.Author.PictureUrl %>" />
                            </a>
                        </div>
                        <div class="item-title-container">
                            <a title="<%: discussion.Subject %>" href="<%: discussion.LinkToMessage %>"><%: discussion.Subject %></a>
                        </div>
                        <div class="item-by-line-container">
                                <span>By: </span><a href="<%: discussion.Author.LinkToProfile %>" biobubblekey="<%: discussion.Author.ContactKey %>"><%: discussion.Author.DisplayName %></a>
                                <span>, <%: discussion.DatePosted %> </span>
                        </div>
                        <div class="item-posted-in-container">
                                <span>Posted in: </span><a href="<%: discussion.LinkToDiscussion %>"><%: discussion.DiscussionName %></a>
                        </div>
                    </div>
                    <div class="item-body-container"><%: discussion.Body.AsRawHtml() %></div>
                </li>
                <% } %>
            <% } else { %>
                <li>
                    <div class="empty">No data found.</div>
                </li>
            <% } %>
        </ul>
    </div>
</div>