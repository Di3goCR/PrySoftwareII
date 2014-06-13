<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdm.master" AutoEventWireup="true" CodeFile="frmPacientesIngresar.aspx.cs" Inherits="Mantenimientos_frmPacientesIngresar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <table border="2">
            <caption>
                <span style="color: #000099">NUEVO PACIENTE</span></caption>
            <tr>
                <td class="style1">
                    <span style="color: #3399ff">
                        <asp:Label ID="Label2" runat="server" ForeColor="#0066FF" Text="Nombres:" Width="160px"></asp:Label></span></td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label3" runat="server" ForeColor="#0066FF" Text="Apellido Paterno:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtApe" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label1" runat="server" ForeColor="#0066FF" Text="Apellido Materno:" Width="160px"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtApeMat" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label4" runat="server" ForeColor="#0066FF" Text="Sexo:" Width="160px"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="cboGenero" runat="server">
                        <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Femenino</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label6" runat="server" ForeColor="#0066FF" Text="Documento:"
                        Width="160px"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtDocumento" runat="server" Width="94px" Height="21px"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" ForeColor="#0066FF" Text="Direccion:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
        
                    <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" ForeColor="#0066FF" Text="Distrito" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:DropDownList ID="cboDistrito" runat="server" Height="25px" Width="180px">
                    </asp:DropDownList>
                </td>
                <td></td>
                <td></td>
            </tr>
                    <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label8" runat="server" ForeColor="#0066FF" Text="Telefono:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
                    <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label9" runat="server" ForeColor="#0066FF" Text="Celular:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
                    <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label10" runat="server" ForeColor="#0066FF" Text="Correo Electronico:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
                            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label11" runat="server" ForeColor="#0066FF" Text="Tipo de Sangre:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtSangre" runat="server"></asp:TextBox>
                                </td>
                <td></td>
                <td></td>
            </tr>

         <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label12" runat="server" ForeColor="#0066FF" Text="Talla:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTalla" runat="server"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>

         <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label13" runat="server" ForeColor="#0066FF" Text="Peso:" Width="160px"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>



            <tr>
                <td class="auto-style4" colspan="2">
                   
                    <asp:Button ID="brnGrabar" runat="server"  Text="Grabar" OnClick="brnGrabar_Click" />
                   
                    </td>
                <td class="auto-style4">
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMensaje" runat="server" BorderStyle="Double" ForeColor="#003399"
                        Width="782px"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red" 
                        NavigateUrl="~/Mantenimientos/VendedorMan01.aspx">Retornar</asp:HyperLink></td>
                <td></td>
                <td></td>
            </tr>
        </table>
</asp:Content>

