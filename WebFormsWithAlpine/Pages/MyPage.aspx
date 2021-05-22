<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>

<%@ Import Namespace="WebFormsWithAlpine.UI.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <%= this.TextInputFor(m => m.Firstname).WithCssClass("my-class").Build() %>
    </div>

    <div>
        <%= this.TextInputFor(m => m.Lastname).WithCssClass("my-class").Build() %>
    </div>

    <div>
        <%= this.SelectFor(m => m.Gender).WithOptions().WithCssClass("my-select-class").Build()  %>
    </div>

    <div>
    </div>
    <div>
        <button type="submit">Submit</button>
    </div>

</asp:Content>
