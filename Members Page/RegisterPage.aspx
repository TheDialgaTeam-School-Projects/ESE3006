<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="RegisterPage.aspx.cs" Inherits="Members_Page_RegisterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Register Page</title>
    <style type="text/css">
        .style1
        {
            width: 10%;
            height: 26px;
        }
        .style2
        {
            width: 40%;
            height: 26px;
        }
        .style3
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Member Registration:"></asp:Label>
    <br />
    <br />
    <table style="width: 100%">
        <tr>
            <td class="style1">
                <asp:Label ID="Label4" runat="server" Text="Username:"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtUsername" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td class="style2" style="padding-left: 10px">
                <asp:Label ID="lbl_username_status" runat="server" Font-Bold="True" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtPassword" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td class="style3" style="padding-left: 10px">
                <asp:Label ID="lbl_password_status" runat="server" Font-Bold="True" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Confirm Password:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtConfirmPassword" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td style="padding-left: 10px">
                <asp:Label ID="lbl_confirm_password_status" runat="server" Font-Bold="True" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="100%"></asp:TextBox>
            </td>
            <td style="padding-left: 10px">
                <asp:Label ID="lbl_email_status" runat="server" Font-Bold="True" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click" />
    <asp:Button ID="btnRegister" runat="server" Text="Register" 
        onclick="btnRegister_Click" />
</asp:Content>
