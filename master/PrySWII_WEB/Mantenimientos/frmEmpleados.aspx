<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdm.master" AutoEventWireup="true" CodeFile="frmEmpleados.aspx.cs" Inherits="Mantenimientos_frmEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <table border="2">
        <caption>
            <strong><span style="font-size: 14pt; " class="style1">LISTADO DE EMPLEADOS</span></strong></caption>
        <tr>
            <td style="width: 100px; height: 35px;">
                <table style="width: 632px">
                    <tr>
                        <td style="width: 100px; height: 25px;">
                            <asp:Button ID="btnNuevo" runat="server" OnClick="btnNuevo_Click1" Text="Nuevo" />
                        </td>
                        <td style="width: 100px; height: 25px;">
                            &nbsp;</td>
                        <td style="width: 100px; text-align: center; height: 25px;">
                            &nbsp;</td>
                        <td style="width: 100px; text-align: center; height: 25px;">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:GridView ID="gvEmpleados" HorizontalAlign="Left" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="848px" OnRowCommand="gvEmpleados_RowCommand">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Editar" 
                            ImageUrl="~/Images/Editar.png" Text="Editar">
                        <ItemStyle Width="20px" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="IdEmpleado" HeaderText="Codigo">
                        <ItemStyle Width="60px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NomEmpleado" HeaderText="Nombres" />
                        <asp:BoundField DataField="ApeEmpPat" HeaderText="Apellidos" />
                        <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
                        <asp:BoundField DataField="NroDNI" HeaderText="Documento" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                        <asp:BoundField DataField="IdDistrito" HeaderText="Distrito" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="Celular" HeaderText="Celular" />
                        <asp:BoundField DataField="Email" HeaderText="Correo" />
                        <asp:BoundField DataField="IdEspecialidad" HeaderText="Especialidad" />
                    </Columns>
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 22px; text-align: left;">
                <asp:Label ID="lblMensaje" runat="server" Width="487px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 22px; text-align: left">
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" 
                    NavigateUrl="~/Mantenimientos/Mantenimientos.aspx" Width="448px">Retornar al Menu de Mantenimiento</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

