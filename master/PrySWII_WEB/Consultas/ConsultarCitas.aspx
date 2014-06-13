<%@ Page Title="" Language="C#" MasterPageFile="~/SiteLog.master" AutoEventWireup="true" CodeFile="ConsultarCitas.aspx.cs" Inherits="Consultas_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
    <p>
        Consulta de Citas</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
                <asp:GridView ID="gvCitas" HorizontalAlign="Left" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="848px" OnRowCommand="gvPacientes_RowCommand1">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Editar" 
                            ImageUrl="~/Images/Editar.png" Text="Editar">
                        <ItemStyle Width="20px" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="IdCita" HeaderText="Codigo">
                        <ItemStyle Width="60px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="IdEmpleado" HeaderText="Nombres" />
                        <asp:BoundField DataField="IdPaciente" HeaderText="Paciente" />
                        <asp:BoundField HeaderText="Fecha" DataField="Fecha" dataformatstring="{0:MM/dd/yyyy}" />
                        <asp:BoundField DataField="Horainicio" HeaderText="HoraInicio" />
                        <asp:BoundField DataField="HoraFin" HeaderText="HoraFin" />
                    </Columns>
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
            <br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
                <asp:Label ID="lblMensaje" runat="server" Width="487px"></asp:Label>
            </asp:Content>

