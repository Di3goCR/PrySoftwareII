<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Roles.aspx.cs" Inherits="Seguridad_Roles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    CREACION DE ROLES<br />
    <br />
 <table>
        <tr>
            <td style="width: 100px">
                Ingrese
                Rol:</td>
            <td>
                <asp:TextBox ID="txtRol" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRol" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 100px">
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" Width="96px" 
                    onclick="btnGrabar_Click" /></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Roles existentes:<br />
                <br />
                <br />
            </td>
            <td>
                <asp:ListBox ID="lstRoles" runat="server" Width="256px"></asp:ListBox></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 18px">
                <asp:Label ID="lblMensaje" runat="server" Width="380px"></asp:Label>
                <br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl="~/Seguridad/Seguridad.aspx">Retornar al Menu de Seguridad</asp:HyperLink>
            </td>
        </tr>
    </table>

</asp:Content>

