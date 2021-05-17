<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>

<%@ Register TagPrefix="cc1" Namespace="WebFormsWithAlpine.Controls" Assembly="WebFormsWithAlpine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <cc1:DataContext runat="server"
                     GetDataMethod="SomeOtherMethod">
        <h1>Hello World</h1>
    </cc1:DataContext>
</asp:Content>
