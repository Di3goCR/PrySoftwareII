<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <asp:Image ID="imgview" runat="server" /></div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Clinica Miselae S.A.C:</h3>
    
    <table class="auto-style1">
        <tr>
            <td>
                <asp:ImageButton ID="img1" runat="server" Height="123px" ImageUrl="~/Images/Clinica.jpg" Width="191px" OnClick="img1_Click" />
            </td>
            <td>
                <asp:ImageButton ID="img2" runat="server" ImageUrl="~/Images/Clinica2.jpg" Height="123px" Width="191px" OnClick="img2_Click" />
            </td>
            <td>
                <asp:ImageButton ID="img3" runat="server" ImageUrl="~/Images/Clinica3.jpg" Height="123px" Width="191px" OnClick="img3_Click" />
            </td>
            <td class="auto-style2">
                <asp:ImageButton ID="img4" runat="server" ImageUrl="~/Images/Clinica4.jpg" Height="123px" Width="191px" OnClick="img4_Click" />
            </td>
             <td>
                <asp:ImageButton ID="img5" runat="server" ImageUrl="~/Images/Clinica5.jpg" Height="123px" Width="191px" OnClick="img5_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/consultas.jpg" />
            </td>
        </tr>
    </table>
    
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 253px;
        }
    </style>
</asp:Content>
