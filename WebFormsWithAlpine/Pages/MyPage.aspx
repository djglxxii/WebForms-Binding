<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>
<%@ Import Namespace="WebFormsWithAlpine.Extensions" %>

<%@ Register TagPrefix="cc1" Namespace="WebFormsWithAlpine.Controls" Assembly="WebFormsWithAlpine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <%= this.TextInputFor(m => m.Firstname).Build() %>
    </div>

    <div>
        <cc1:CustomTextInput
            runat="server"
            ID="Lastname"
            Value="<%#: Model.Lastname %>"/>
    </div>

    <div>
        <cc1:CustomTextInput
            runat="server"
            ID="Zipcode"
            Value="<%#: Model.Zipcode %>"/>
    </div>
    
    <div>
        <button type="submit">Submit</button>
    </div>

</asp:Content>