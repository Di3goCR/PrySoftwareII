using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;

public partial class Mantenimientos_frmEmpleado02 : System.Web.UI.Page
{

    DistritoBL objDistritoBL = new  DistritoBL();
    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();
    EspecialidadesBL objEspecialidadBL = new EspecialidadesBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            try
            {
                cboDistrito.DataSource = objDistritoBL.ListarDistrito();
                cboDistrito.DataValueField = "IdDistrito";
                cboDistrito.DataTextField = "Nombre";
                cboDistrito.DataBind();
                cboEspecialidad.DataSource = objEspecialidadBL.ListarEspecialidad();
                cboEspecialidad.DataValueField = "IdEspecialidad";
                cboEspecialidad.DataTextField = "Especialidad";
                cboEspecialidad.DataBind();
                //lblMensaje.Visible = false;

            }
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }



    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEmpleados.aspx");
    }

    protected void brnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objEmpleadoBE.IdEmpleado = "";
            objEmpleadoBE.ApeEmpPat = txtApe.Text;
            objEmpleadoBE.ApeEmpMat = txtApeMat.Text;
            objEmpleadoBE.NomEmpleado = txtNom.Text;
            objEmpleadoBE.Sexo = cboGenero.SelectedValue.ToString();
            objEmpleadoBE.NroDNI = txtDocumento.Text;
            objEmpleadoBE.Direccion = txtDireccion.Text;
            objEmpleadoBE.IdDistrito = cboDistrito.SelectedValue.ToString();
            objEmpleadoBE.Telefono = txtTelefono.Text;
            objEmpleadoBE.Celular = txtCelular.Text;
            objEmpleadoBE.Email = txtCorreo.Text;
            objEmpleadoBE.IdEspecialidad = cboEspecialidad.SelectedValue.ToString();

            if (objEmpleadoBL.InsetarEmpleado(objEmpleadoBE) == true)
            {
                Response.Redirect("frmEmpleados.aspx");
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
}