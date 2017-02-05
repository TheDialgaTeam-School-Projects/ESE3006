<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Error.aspx.cs" Inherits="Member_Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <p>
        Error: User not authorized! Please
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Member/LoginPage.aspx">Login</asp:HyperLink>
        to view this page.
    </p>
</asp:Content>