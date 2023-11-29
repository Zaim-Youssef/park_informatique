<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="liste_equipement_anomalie.aspx.cs" Inherits="projetAnomalie.liste_equipement_anomalie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 266px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp; liste&nbsp; anomnalie<br />
        local Id :&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="150px" AutoPostBack="True">
        </asp:DropDownList>
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">Id Personnel :&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Nom :&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    <p style="margin-left: 40px">
        <asp:Label ID="Label5" runat="server" Text="Liste des Equipements :"></asp:Label>
    </p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <p style="margin-left: 40px">
        <asp:Label ID="Label4" runat="server" Text="Liste des Anomalies :"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p style="margin-left: 40px">
        <asp:Label ID="labelerror" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
