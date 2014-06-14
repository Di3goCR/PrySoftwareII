<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Seguridad.aspx.cs" Inherits="Seguridad_Seguridad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 421px;
        }
        .style4
        {
            width: 227px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        CONFIGURACION DE SEGURIDAD</p>
   
    <p>
        <table class="style1">
            <tr>
                <td class="style4">
                    <asp:Image ID="Image1" runat="server" Height="213px" 
                        ImageUrl="~/Images/users.png" Width="260px" />
                </td>
                <td class="style3">
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/Seguridad/Roles.aspx">Creación de Roles</asp:HyperLink>
                    <br />
                    <br />
        <asp:HyperLink ID="HyperLink2" runat="server" 
            NavigateUrl="~/Seguridad/Usuarios.aspx">Creación de Usuarios</asp:HyperLink>
                </td>
            </tr>
        </table>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>

