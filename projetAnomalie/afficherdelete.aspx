<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="afficherdelete.aspx.cs" Inherits="projetAnomalie.afficherdelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 258px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>VERIFICATION DE L&#39;ELEMENT A SUPPRIMMER</td>
        </tr>
        <tr>
            <td class="auto-style5">id Anomalie :&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">date Anomalie :&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Description :&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Etat Equipement :</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <br />
                <br />
                <br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/liste_equipement_anomalie.aspx">Retour a la liste d&#39;equipement</asp:HyperLink>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
