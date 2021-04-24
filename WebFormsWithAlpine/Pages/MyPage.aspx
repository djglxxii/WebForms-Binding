<%@ Page Title="Title" Language="C#" MasterPageFile="~/Site.Master" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>
<%@ Register TagPrefix="cc1" Namespace="WebFormsWithAlpine.UserControls" Assembly="WebFormsWithAlpine" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>My Page</h1>

    <div>
        <cc1:CustomInputText
            runat="server"
            ID="Firstname"
            Value="<%#: Model.Firstname %>"/>
    </div>

    <div>
        <cc1:CustomInputText
            runat="server"
            ID="Lastname"
            Value="<%#: Model.Lastname %>"/>
    </div>
    
    <div>
            <cc1:CustomInputText
                runat="server"
                ID="Zipcode"
                Value="<%#: Model.Zipcode %>"/>
        </div>
    
    <button runat="server">Submit</button>
</asp:Content>