<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegisterComplete.aspx.cs" Inherits="Members_Page_RegisterComplete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .CustomStyle {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            font-variant: normal;
            font-style: italic;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Timer ID="Timer" runat="server" Interval="1000" OnTick="Timer_Tick">
    </asp:Timer>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="CustomStyle">
                Thank you for registering with us! You will be redirected to login page in
                <asp:Label ID="txtRemainingTime" runat="server" Text="5"></asp:Label>
                seconds.<br />
                You may click
                <asp:LinkButton ID="btnLinkHere" runat="server" PostBackUrl="~/Members Page/LoginPage.aspx">here</asp:LinkButton>
                if it does not redirect.
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
