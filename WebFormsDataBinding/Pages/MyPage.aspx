<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebFormsDataBinding.Pages.MyPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <label>
            Firstname: 
            <asp:TextBox runat="server"
                ID="Firstname"
                Text="<%#: Model.Firstname %>">
            </asp:TextBox>
        </label>
    </div>

    <div>
        <label>
            Lastname: 
            <asp:TextBox runat="server"
                ID="Lastname"
                Text="<%#: Model.Lastname %>">
            </asp:TextBox>
        </label>
    </div>

    <div>
        <label>
            Married: 
            <asp:CheckBox runat="server"
                ID="IsMarried"
                Checked="<%# Model.IsMarried %>" />
        </label>
    </div>

    <div>
        <asp:Button runat="server" Text="Submit" />
    </div>
</asp:Content>
