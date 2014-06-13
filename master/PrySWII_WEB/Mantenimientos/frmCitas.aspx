<%@ Page Title="" Language="C#" MasterPageFile="~/SiteCliente.master" AutoEventWireup="true" CodeFile="frmCitas.aspx.cs" Inherits="Mantenimientos_frmCitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 198px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <script src="../Scripts/calendar.js" type="text/javascript" > </script>
    <p>Datos del Paciente Registrado</p>

    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" Text="Codigo:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblCod" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="Apellido:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="Sexo:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" Text=" # Identidad:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNro" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label8" runat="server" Text="Tipo de Sangre:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTipoSangre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label9" runat="server" Text="Talla:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTalla" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label10" runat="server" Text="Peso:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>

    <br />
    <br />
    <br />
    <table class="auto-style1" style="vertical-align:central">
        <tr>
            <td colspan="3"><p style="text-align:center">RESERVA TU CITA EN LINEA</p> </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Ingrese la rama a Atenderse:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cboEspecialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboEspecialidad_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label12" runat="server" Text="Seleccione su Medico:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:GridView style="text-align:center" ID="gvMedicos" runat="server" AutoGenerateColumns="False" OnRowCommand="gvMedicos_RowCommand">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" HeaderText="Seleccionar" Text="Seleccionar" />
                        <asp:BoundField DataField="IdEmpleado" HeaderText="Codigo" />
                        <asp:BoundField DataField="NomEmpleado" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApeEmpPat" HeaderText="Ape Paterno" />
                        <asp:BoundField DataField="ApeEmpMat" HeaderText="Ape Materno" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Seleccione su Horario de Atencion:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cboHorario" runat="server">
                    <asp:ListItem>18:00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Selecione la Fecha:"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="caledario" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="16px" ShowGridLines="True" Width="16px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
             </td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style2">
                <p style="text-align:center"><asp:Button ID="btnGrabar" runat="server" Text="Guadar Cita" OnClick="btnGrabar_Click" /></p>
            </td>
            <td>
                <p style="text-align:center"><asp:Button ID="btnCancelar" runat="server" Text="Cancelar Operacion" /></p>
            </td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style2" colspan="3">
                
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                
            </td>
        </tr>
    </table>
    
</asp:Content>

