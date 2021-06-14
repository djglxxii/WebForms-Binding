<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>

<%@ Import Namespace="WebFormsWithAlpine.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <aegis-editable-list id="ctl00$MainContent$GenderOptions" x-model="ctl00$MainContent$GenderOptions"></aegis-editable-list>
    </div>

    <div>
        <button type="submit">Submit</button>
    </div>

</asp:Content>
