<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdm.master" AutoEventWireup="true" CodeFile="frmMantenimientos.aspx.cs" Inherits="Admin_frmMantenimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 266px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">



    <table class="auto-style1">
        <tr>
            <td colspan="2"><p style="text-align:center">Mantenimientos de Tablas</p></td>
        </tr>
        <tr>
            <td class="auto-style2">Mantenimiento de Empleados:</td>
            <td><a href="../Mantenimientos/frmEmpleados.aspx">Redireccionar</a></td>
        </tr>
        <tr>
            <td class="auto-style2">Mantenimiento de Pacientes:</td>
            <td><a href="../Mantenimientos/frmPacientes.aspx">Redireccionar</a></td>
        </tr>
        <tr>
            <td class="auto-style2">Mantenimientos de Usuarios Empleados:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Mantenimiento de Usuarios Pacientes:</td>
            <td>&nbsp;</td>
        </tr>
    </table>



</asp:Content>

