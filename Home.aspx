<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div style="text-align: center; font-size: xx-large; font-style: italic; font-family: 'Comic Sans MS';">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        Welcome to JAS Torch Holders<br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="300px" Width="500px" />
        <ajaxToolkit:SlideShowExtender ID="Image1_SlideShowExtender" runat="server" AutoPlay="True" BehaviorID="Image1_SlideShowExtender" Loop="True" SlideShowServiceMethod="GetImages" SlideShowServicePath="" TargetControlID="Image1" />
    </div>
</asp:Content>