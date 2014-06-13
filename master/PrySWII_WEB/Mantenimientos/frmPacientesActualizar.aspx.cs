using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;

public partial class Mantenimientos_frmPacientesActualizar : System.Web.UI.Page
{
    DistritoBL objDistritoBL = new DistritoBL();
    PacienteBE objPacienteBE = new PacienteBE();
    ClienteBL objPacienteBL = new ClienteBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            cboDistrito.DataSource = objDistritoBL.ListarDistrito();
            cboDistrito.DataValueField = "IdDistrito";
            cboDistrito.DataTextField = "Nombre";
            cboDistrito.DataBind();


            String strCodPac= Session["IdPaciente"].ToString();
            try
            {
                objPacienteBE = objPacienteBL.consultarPaciente(strCodPac);
                lblCod.Text = strCodPac;
                txtApe.Text = objPacienteBE.ApePacPat;
                txtApeMat.Text = objPacienteBE.ApePacMat;
                txtNom.Text = objPacienteBE.NomPaciente;
                cboGenero.SelectedValue = objPacienteBE.Sexo;
                txtDocumento.Text = objPacienteBE.NroIdentidad;
                txtDireccion.Text = objPacienteBE.Direccion;
                cboDistrito.SelectedValue = objPacienteBE.IdDistrito;
                txtTelefono.Text = objPacienteBE.Telefono;
                txtCelular.Text = objPacienteBE.Celular;
                txtCorreo.Text = objPacienteBE.Email;
                txtTalla.Text = objPacienteBE.TallaPac;
                txtSangre.Text = objPacienteBE.TipSangrePac;
                txtPeso.Text = objPacienteBE.PesoPac;


            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error : " + ex.Message;
            }
        }
    }


    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmPacientes.aspx");
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (objPacienteBL.EliminarPaciente(lblCod.Text))
            {
                Response.Redirect("frmPacientes.aspx");
            }
            else
            {
                lblMensaje.Text = "El Paciente no se pudo eliminar porque esta vinculado a otras tablas";
            }

        }
        catch (Exception ex)
        {

            lblMensaje.Text = "Se ha producido el error: " + ex.Message;
        }
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            String strCodPac = Session["IdPaciente"].ToString();
            objPacienteBE.IdPaciente = strCodPac;
            objPacienteBE.ApePacPat = txtApe.Text;
            objPacienteBE.ApePacMat = txtApeMat.Text;
            objPacienteBE.NomPaciente = txtNom.Text;
            objPacienteBE.Sexo = cboGenero.SelectedValue.ToString();
            objPacienteBE.NroIdentidad = txtDocumento.Text;
            objPacienteBE.Direccion = txtDireccion.Text;
            objPacienteBE.IdDistrito = cboDistrito.SelectedValue.ToString();
            objPacienteBE.Telefono = txtTelefono.Text.ToString();
            objPacienteBE.Celular = txtCelular.Text;
            objPacienteBE.Email = txtCorreo.Text;
            objPacienteBE.TallaPac = txtTalla.Text;
            objPacienteBE.TipSangrePac = txtSangre.Text;
            objPacienteBE.PesoPac = txtPeso.Text;
            if (objPacienteBL.ActualizarPacietne(objPacienteBE)== true)
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
            lblMensaje.Text = "Error : " + ex.Message;
        }
    }
}