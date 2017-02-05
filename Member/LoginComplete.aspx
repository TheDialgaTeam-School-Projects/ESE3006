<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginComplete.aspx.cs" Inherits="Member_LoginComplete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
    </asp:Timer>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="CustomStyle">
                You have successfully logged in! You will be redirected to Home page in
                <asp:Label ID="txtRemainingTime" runat="server" Text="5"></asp:Label>
                seconds.<br />
                You may click
                <asp:LinkButton ID="btnLinkHere" runat="server" PostBackUrl="~/Home.aspx">here</asp:LinkButton>
                if it does not redirect.
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>