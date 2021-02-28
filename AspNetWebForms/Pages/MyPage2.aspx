<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage2.aspx.cs" Inherits="AspNetWebForms.Pages.MyPage2" %>

<%@ Register TagPrefix="cc1" Namespace="AspNetWebForms.Controls" Assembly="AspNetWebForms" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div x-data="{ Password : '<%#: Model.MyPassword %>'}">
        
        <cc1:CustomPasswordBox runat="server" ID="MyPassword" Password="<%#:Model.MyPassword %>" />

        <div>
            <asp:Button runat="server" Text="Submit" />
        </div>
    </div>
</asp:Content>
