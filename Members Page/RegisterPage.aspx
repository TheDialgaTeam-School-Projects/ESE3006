<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="Members_Page_RegisterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Register Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Member Registration:"></asp:Label>
            <br />
            <br />
            <table style="width: 100%">
                <tr>
                    <td style="width: 10%;">
                        <asp:Label ID="Label4" runat="server" Text="Username:"></asp:Label>
                    </td>
                    <td style="width: 40%;">
                        <asp:TextBox ID="txtUsername" runat="server" Width="100%" MaxLength="50"></asp:TextBox>
                    </td>
                    <td style="width: 40%; padding-left: 10px">
                        <asp:Label ID="lbl_username_status" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Width="100%" MaxLength="50" TextMode="Password"></asp:TextBox>
                    </td>
                    <td style="padding-left: 10px">
                        <asp:Label ID="lbl_password_status" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Confirm Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server" Width="100%" MaxLength="50" TextMode="Password"></asp:TextBox>
                    </td>
                    <td style="padding-left: 10px">
                        <asp:Label ID="lbl_confirm_password_status" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
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
                        <asp:Label ID="lbl_email_status" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
