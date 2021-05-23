<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsWithAlpine.Pages.MyPage" %>

<%@ Import Namespace="WebFormsWithAlpine.UI.Extensions" %>
<%@ Register Src="~/UserControls/MyUserControl.ascx" TagPrefix="uc1" TagName="MyUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <%= this.TextInputFor(m => m.Firstname)
                .WithValidation()
                .WithCssClass("my-class")
                .Build() %>
    </div>

    <div>
        <%= this.TextInputFor(m => m.Lastname)
                .WithValidation()
                .WithCssClass("my-class")
                .Build() %>
    </div>

    <div>
        <%= this.NumberInputFor(m => m.Zipcode)
                .WithCssClass("my-class")
                .Build() %>
    </div>

    <div>
        <%= this.SelectFor(m => m.Gender)
                .WithOptions(("0", "Male"), ("1","Female"),("3","Other"))
                .WithCssClass("my-select-class")
                .Build()  %>
    </div>

    <div>
        <uc1:MyUserControl runat="server" ID="MyUserControl" />
    </div>

    <div>
        <button type="submit">Submit</button>
    </div>

</asp:Content>
