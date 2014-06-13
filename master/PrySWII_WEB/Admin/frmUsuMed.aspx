<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="frmUsuMed.aspx.cs" Inherits="Admin_frmUsuMed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <table border="2">
        <caption>
            <strong><span style="font-size: 14pt; " class="style1">LISTADO DE USUARIOS</span></strong></caption>
        <tr>
            <td class="auto-style1">
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
            <td class="auto-style2">
                <asp:GridView ID="gvMedicos" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="848px">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Editar" 
                            ImageUrl="~/Images/Editar.png" Text="Activar">
                        <ItemStyle Width="20px" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="IdUsuario" HeaderText="Codigo">
                        <ItemStyle Width="60px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                        <asp:BoundField DataField="contraseña" HeaderText="Contraseña" />
                        <asp:BoundField HeaderText="Estado" DataField="estado" />
                        <asp:BoundField DataField="IdEmpleado" HeaderText="Cod Medico" />
                        <asp:BoundField DataField="rol" HeaderText="Rol" />
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
            <td style="text-align: left;" class="auto-style3">
                <asp:Label ID="lblMensaje" runat="server" Width="487px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left" class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" 
                    NavigateUrl="~/Mantenimientos/Mantenimientos.aspx" Width="448px">Retornar al Menu de Mantenimiento</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

