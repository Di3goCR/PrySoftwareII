using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;

public partial class Mantenimientos_frmPacientesIngresar : System.Web.UI.Page
{
    DistritoBL objDistritoBL = new DistritoBL();
    PacienteBE objPacienteBE = new PacienteBE();
    PacienteBL objPacienteBL = new PacienteBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                cboDistrito.DataSource = objDistritoBL.ListarDistrito();
                cboDistrito.DataValueField = "IdDistrito";
                cboDistrito.DataTextField = "Nombre";
                cboDistrito.DataBind();

            }
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
    protected void brnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objPacienteBE.IdPaciente = "";
            objPacienteBE.ApePacPat = txtApe.Text;
            objPacienteBE.ApePacMat = txtApeMat.Text;
            objPacienteBE.NomPaciente = txtNom.Text;
            objPacienteBE.Sexo = cboGenero.SelectedValue.ToString();
            objPacienteBE.NroIdentidad = txtDocumento.Text;
            objPacienteBE.Direccion = txtDireccion.Text;
            objPacienteBE.IdDistrito = cboDistrito.SelectedValue.ToString();
            objPacienteBE.Telefono = txtTelefono.Text;
            objPacienteBE.Celular = txtCelular.Text;
            objPacienteBE.Email = txtCorreo.Text;
            objPacienteBE.TipSangrePac = txtSangre.Text;
            objPacienteBE.TallaPac = txtTalla.Text;
            objPacienteBE.PesoPac = txtPeso.Text;

            if (objPacienteBL.InsertarPaciente(objPacienteBE) == true)
            {
                Response.Redirect("frmPacientes.aspx");
            }
            else
            {
                lblMensaje.Text = "Error, verifique los datos";
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error: " + ex.Message;
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmPacientes.aspx");
    }
}