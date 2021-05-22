<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>
<%@ Import Namespace="WebFormsWithAlpine.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <%= this.TextInputFor(m => m.Firstname).WithClass("my-class").Build() %>
    </div>

    <div>
        <%= this.TextInputFor(m => m.Lastname).Build() %>
    </div>

    <div>
        <%= this.NumberInputFor(m => m.Zipcode).Build() %>
    </div>

    <div>
        <button type="submit">Submit</button>
    </div>

</asp:Content>