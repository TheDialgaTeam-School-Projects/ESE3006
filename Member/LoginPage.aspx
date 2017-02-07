<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="Member_LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Login Page</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Member / Admin Login:"></asp:Label>
    <br />
    <br />
    <table style="width: 100%">
        <tr>
            <td style="width: 10%">
                <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
    <asp:Label ID="txtError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    <asp:Button ID="btnForgetPassword" runat="server" Text="Forget Password?" OnClick="btnForgetPassword_Click" />
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
</asp:Content>