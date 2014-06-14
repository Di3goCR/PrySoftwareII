using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;

public partial class Admin_frmConsultas : System.Web.UI.Page
{
    DistritoBL objDistritoBL = new DistritoBL();
    EspecialidadesBL objEspecialidadBL = new EspecialidadesBL();
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();
    PacienteBL objClienteBL = new PacienteBL();
    CitasBL objCitasBL = new CitasBL();

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
                cboDistrito2.DataSource = objDistritoBL.ListarDistrito();
                cboDistrito2.DataValueField = "IdDistrito";
                cboDistrito2.DataTextField = "Nombre";
                cboDistrito2.DataBind();
                cboEspecialidad.DataSource = objEspecialidadBL.ListarEspecialidad();
                cboEspecialidad.DataValueField = "IdEspecialidad";
                cboEspecialidad.DataTextField = "Especialidad";
                cboEspecialidad.DataBind();
                lblMensaje.Visible = false;

            }
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
    protected void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
    {
        gvEmpleados.DataSource = objEmpleadoBL.consultarEmpEspecialidad(cboEspecialidad.SelectedValue.ToString());
        gvEmpleados.DataBind();

        gvCitas.DataSource = null;
        gvCitas.DataBind();
        gvPaciente.DataSource = null;
        gvPaciente.DataBind();
    }
    protected void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
    {
        gvEmpleados.DataSource = objEmpleadoBL.ListarEmpleadoDistrito(cboDistrito.SelectedValue.ToString());
        gvEmpleados.DataBind();

        gvCitas.DataSource = null;
        gvCitas.DataBind();
        gvPaciente.DataSource = null;
        gvPaciente.DataBind();
    }
    protected void cboDistrito2_SelectedIndexChanged(object sender, EventArgs e)
    {
        gvPaciente.DataSource = objClienteBL.ListarPacienteDistrito(cboDistrito2.SelectedValue.ToString());
        gvPaciente.DataBind();

        gvEmpleados.DataSource = null;
        gvEmpleados.DataBind();
        gvCitas.DataSource = null;
        gvCitas.DataBind();

    }
    protected void cboGrpSanguineo_SelectedIndexChanged(object sender, EventArgs e)
    {
        gvPaciente.DataSource = objClienteBL.ListarPacienteTSangre(cboGrpSanguineo.SelectedValue.ToString());
        gvPaciente.DataBind();

        gvEmpleados.DataSource = null;
        gvEmpleados.DataBind();
        gvCitas.DataSource = null;
        gvCitas.DataBind();
    }
    protected void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void cboCitas_SelectedIndexChanged(object sender, EventArgs e)
    {
        DateTime fInicio = cldFInicio.SelectedDate;
        DateTime fFin = cldFFin.SelectedDate;

        gvCitas.DataSource = objCitasBL.listarCitasEstadoFecha(cboCitas.SelectedValue.ToString(),fInicio,fFin);
        gvCitas.DataBind();


        gvPaciente.DataSource = null;
        gvPaciente.DataBind();
        gvEmpleados.DataSource = null;
        gvEmpleados.DataBind();
       
    }
    protected void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void cboSexo2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}