<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>
<%@ Register TagPrefix="cc" Namespace="WebFormsWithAlpine.Controls" Assembly="WebFormsWithAlpine" %>

<%@ Import Namespace="WebFormsWithAlpine.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <%--<aeg-masked-input name="MyPassword" value="Default"></aeg-masked-input>--%>
        <cc:MaskedInput runat="server" name="MyPassword" Value="Default"></cc:MaskedInput>
    </div>

    <div>
        <button type="submit">Submit</button>
    </div>

</asp:Content>
