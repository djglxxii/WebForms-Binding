<%@ Control Language="C#" CodeBehind="MyUserControl.ascx.cs" Inherits="WebFormsWithAlpine.UserControls.MyUserControl" %>
<%@ Import Namespace="WebFormsWithAlpine.UI.Extensions" %>

<h2>My User Control</h2>

<div>
    <%= this.TextInputFor(m => m.SomeInfo1).Build() %>
</div>

<div>
    <%= this.TextInputFor(m => m.SomeInfo2).Build() %>
</div>