<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>
<%@ Register TagPrefix="cc" Namespace="WebFormsWithAlpine.Controls" Assembly="WebFormsWithAlpine" %>

<%@ Import Namespace="WebFormsWithAlpine.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <cc:ValidationMessageControl runat="server" Message="Hello World">
            <cc:MaskedInputControl ID="Password" runat="server"/>
        </cc:ValidationMessageControl>
    </div>

    <div>
        <button type="submit">Submit</button>
    </div>

</asp:Content>