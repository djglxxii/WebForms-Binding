<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="AspNetWebForms.Pages.MyPage" %>

<%@ Register TagPrefix="cc" Namespace="AspNetWebForms.Controls" Assembly="AspNetWebForms" %>
<%@ Register Src="~/UserControls/MyUserControl.ascx" TagPrefix="uc1" TagName="MyUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>My Page</h1>

    <div>
        <cc:TabControl runat="server" ActiveTab="<%# ActiveTab %>">

            <cc:Tab runat="server" Title="Tab 1">
                <h2>Tab 1 Content</h2>
                <input runat="server" type="button" value="<%#: Button1Text %>" />
            </cc:Tab>

            <cc:Tab runat="server" Title="Tab 2">
                <h2>Tab 2 Content</h2>
                <input runat="server" type="button" value="<%#: Button2Text %>" />
            </cc:Tab>

            <cc:Tab runat="server" Title="Tab 2">
                <uc1:MyUserControl runat="server"/>
            </cc:Tab>


        </cc:TabControl>
    </div>
</asp:Content>
