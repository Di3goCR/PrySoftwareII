<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdm.master" AutoEventWireup="true" CodeFile="frmConsultas.aspx.cs" Inherits="Admin_frmConsultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            height: 23px;
            width: 270px;
        }
        .auto-style5 {
            height: 157px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Consulta Empledos por Especialidad:</td>
            <td>
                <asp:DropDownList ID="cboEspecialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboEspecialidad_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Consulta Empleados por Distrito:</td>
            <td>
                <asp:DropDownList ID="cboDistrito" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboDistrito_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Consulta Pacientes por Distrito:</td>
            <td>
                <asp:DropDownList ID="cboDistrito2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboDistrito2_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Consulta de Pacientes por Grupo Sanguineo:</td>
            <td>
                <asp:DropDownList ID="cboGrpSanguineo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboGrpSanguineo_SelectedIndexChanged">
                    <asp:ListItem Selected="True">O+</asp:ListItem>
                    <asp:ListItem>O-</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Consulta de Usuarios Activos </td>
            <td>
                <asp:DropDownList ID="cboEstado" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboEstado_SelectedIndexChanged">
                    <asp:ListItem>Activo</asp:ListItem>
                    <asp:ListItem>Inactivo</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Consulta de Citas Atendidas:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="cboCitas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboCitas_SelectedIndexChanged" Width="76px">
                    <asp:ListItem Selected="True" Value="1">Citado</asp:ListItem>
                    <asp:ListItem Value="2">En espera</asp:ListItem>
                    <asp:ListItem Value="3">Atendido</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Calendar ID="cldFInicio" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Calendar ID="cldFFin" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
&nbsp;
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td class="auto-style3">Consulta de Pacientes por Sexo:</td>
            <td>
                <asp:DropDownList ID="cboSexo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboSexo_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Femenino</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Consulta de Empleados por Sexo:</td>
            <td>
                <asp:DropDownList ID="cboSexo2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboSexo2_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Femenino</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td class="auto-style5" colspan="2">
                <asp:GridView ID="gvEmpleados" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="gvEmpleados_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="IdEmpleado" HeaderText="Codigo" />
                        <asp:BoundField DataField="NomEmpleado" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApeEmpPat" HeaderText="Ape Paterno" />
                        <asp:BoundField DataField="ApeEmpMat" HeaderText="Ape Materno" />
                        <asp:BoundField DataField="IdEspecialidad" HeaderText="Especialidad" />
                        <asp:BoundField DataField="sexo" HeaderText="Sexo" />
                        <asp:BoundField DataField="NroDNI" HeaderText="Documento" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <br />
                <asp:GridView ID="gvPaciente" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="gvEmpleados_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="IdPaciente" HeaderText="Codigo" />
                        <asp:BoundField DataField="NomPaciente" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApePacPat" HeaderText="Ape Paterno" />
                        <asp:BoundField DataField="ApePacMat" HeaderText="Ape Materno" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="TipSangrePac" HeaderText="Tipo Sange" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <br />
                <asp:GridView ID="gvCitas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="gvEmpleados_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="IdPaciente" HeaderText="Codigo" />
                        <asp:BoundField DataField="NomPaciente" HeaderText="Paciente" />
                        <asp:BoundField DataField="IdEmpleado" HeaderText="Doctor" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <br />
             </td>
        </tr>
                <tr>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="lblMensaje" runat="server" BorderStyle="Inset" ForeColor="Red" Width="691px"></asp:Label>
                    </td>
        </tr>
    </table>
</asp:Content>

