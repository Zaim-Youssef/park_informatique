<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="creeranomalie.aspx.cs" Inherits="projetAnomalie.creeranomalie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; anomalie:</p>
    <p style="margin-left: 40px">
        id Anomalie :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px; margin-bottom: 0px" ReadOnly="True"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        date Anomalie :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="DateTime"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        Description :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="47px" Width="292px"></asp:TextBox>
        <br />
        .</p>
    <p style="margin-left: 40px">
        Etat Equipement :
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="16px" style="margin-bottom: 0px" Width="131px">
        </asp:DropDownList>
    </p>
    <p style="margin-left: 40px">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Inserer" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Edit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Annuler" />
    </p>
    <p style="margin-left: 40px">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
