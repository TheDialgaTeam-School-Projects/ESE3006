<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ForgetPassword.aspx.cs" Inherits="Members_Page_ForgetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Forget Password?<br /> Don&#39;t worry, please enter your username and email to retrive your password.<br />
                <br />
                <table class="auto-style1">
                    <tr>
                        <td style="width: 10%">Username:</td>
                        <td>
                            <asp:TextBox ID="txtUsername" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Email:</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <asp:Label ID="txt_Status" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
                <asp:Button ID="btnGetPassword" runat="server" OnClick="btnGetPassword_Click" Text="Get Password" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

