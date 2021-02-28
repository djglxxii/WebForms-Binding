<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyUserControl.ascx.cs" Inherits="AspNetWebForms.UserControls.MyUserControl" %>

<h1>My Custom Control</h1>

<div>
    <asp:Button runat="server" Text="<%#: MyButtonText %>" />
</div>
