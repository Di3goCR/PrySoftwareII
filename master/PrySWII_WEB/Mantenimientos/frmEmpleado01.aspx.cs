using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BE;
using PrySWII_BL;

public partial class Mantenimientos_frmEmpleado01 : System.Web.UI.Page
{
    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();
    DistritoBL objDistritoBL = new DistritoBL();
    EspecialidadesBL objEspecialidadBL = new EspecialidadesBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            cboDistrito.DataSource = objDistritoBL.ListarDistrito();
            cboDistrito.DataValueField = "IdDistrito";
            cboDistrito.DataTextField = "Nombre";
            cboDistrito.DataBind();
            cboEspecialidad.DataSource = objEspecialidadBL.ListarEspecialidad();
            cboEspecialidad.DataValueField = "IdEspecialidad";
            cboEspecialidad.DataTextField = "Especialidad";
            cboEspecialidad.DataBind();


            String strCodEmp = Session["IdEmpleado"].ToString();
            try
            {
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(strCodEmp);
                lblCod.Text = strCodEmp;
                txtApe.Text = objEmpleadoBE.ApeEmpPat ;
                txtApeMat.Text=objEmpleadoBE.ApeEmpMat;
                txtNom.Text  = objEmpleadoBE.NomEmpleado ;
                cboGenero.SelectedValue = objEmpleadoBE.Sexo;
                txtDocumento.Text = objEmpleadoBE.NroDNI ;
                txtDireccion.Text = objEmpleadoBE.Direccion ;
                cboDistrito.SelectedValue= objEmpleadoBE.IdDistrito ;
                txtTelefono.Text = objEmpleadoBE.Telefono ;
                txtCelular.Text = objEmpleadoBE.Celular ;
                txtCorreo.Text = objEmpleadoBE.Email ;
                cboEspecialidad.SelectedValue= objEmpleadoBE.IdEspecialidad ;


            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error : " + ex.Message;
            }
        }
    }
    protected void brnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objEmpleadoBE.IdEmpleado = Session["IdEmpleado"].ToString();
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

            if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE) == true)
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


    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (objEmpleadoBL.EliminarEmpleado(lblCod.Text))
            {
                Response.Redirect("frmEmpleados.aspx");
            }
            else
            {
                lblMensaje.Text = "El vendedor no se pudo eliminar porque esta vinculado a otras tablas";
            }

        }
        catch (Exception ex)
        {

            lblMensaje.Text = "Se ha producido el error: " + ex.Message;
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEmpleados.aspx");
    }
}