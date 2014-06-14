<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Usuarios.aspx.cs" Inherits="Seguridad_Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    CREACION DE USUARIOS<br />
    <br />
<table>
        <tr>
            <td style="width: 100px">
                Usuario</td>
            <td style="width: 98px">
                <asp:TextBox ID="txtuser" runat="server"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtuser"
                    ErrorMessage="Obligatorio"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Password</td>
            <td style="width: 98px">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="118px" 
                    Height="21px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                    ErrorMessage="Obligatorio"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                E_mail</td>
            <td style="width: 98px">
                <asp:TextBox ID="txtEmail" runat="server" Width="256px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Obligatorio"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Roles</td>
            <td style="width: 98px">
                <asp:DropDownList ID="cboRoles" runat="server" Width="168px">
                </asp:DropDownList></td>
            <td style="width: 100px">
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" Width="96px" 
                    onclick="btnGrabar_Click" /></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblMensaje" runat="server" Width="445px"></asp:Label>
                <br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl="~/Seguridad/Seguridad.aspx">Retornar al Menu de Seguridad</asp:HyperLink>
            </td>
        </tr>
    </table>


</asp:Content>

