<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage2.aspx.cs" Inherits="AspNetWebForms.Pages.MyPage2" %>
<%@ Import Namespace="AspNetWebForms.Infrastructure" %>
<%@ Import Namespace="AspNetWebForms.Pages" %>

<%@ Register TagPrefix="cc1" Namespace="AspNetWebForms.Controls" Assembly="AspNetWebForms" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <%= this.TextBoxFor<MyPage2Model>(m => m.MyPassword).WithClass("zmmy").Build()  %>

</asp:Content>
