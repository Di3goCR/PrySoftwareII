using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;
using System.Data;

public partial class Mantenimientos_frmCitas : System.Web.UI.Page
{
    EspecialidadesBL objEspecialidadBL = new EspecialidadesBL();
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();
    CitasBE objCitasBE = new CitasBE();
    CitasBL objCitasBL = new CitasBL();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["codP"] != null)
            {
                ClienteBL paciente = new ClienteBL();
                PacienteBE pacientebe = new PacienteBE();
                pacientebe = paciente.consultarPaciente(Session["codP"].ToString());

                if (pacientebe == null)
                    lblMensaje.Text = "Nulo";
                else
                {

                    txtApellido.Text = pacientebe.ApePacMat;
                    txtNombre.Text = pacientebe.NomPaciente;
                    txtSexo.Text = pacientebe.Sexo.Equals("F") ? "Femenino" : "Masculino";
                    txtNro.Text = pacientebe.NroIdentidad;
                    txtPeso.Text = pacientebe.PesoPac;
                    txtTipoSangre.Text = pacientebe.TipSangrePac;
                    txtTalla.Text = pacientebe.TallaPac;
                }
            }
            else
            {

                lblMensaje.Text = "Ingrese login";
            }

            if (Page.IsPostBack == false)
            {
                cboEspecialidad.DataSource = objEspecialidadBL.ListarEspecialidad();
                cboEspecialidad.DataValueField = "IdEspecialidad";
                cboEspecialidad.DataTextField = "Especialidad";
                cboEspecialidad.DataBind();

               
            }
            
        }
        catch (Exception ex)
        {

        }

         
        
    }
    protected void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        gvMedicos.DataSource = objEmpleadoBL.consultarEmpleadoEspecialidad(cboEspecialidad.SelectedValue.ToString());
        //cboMedico.DataValueField = "IdEspecialidad";
        //cboMedico.DataTextField = "NombreCompleto";
        gvMedicos.DataBind();



    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {

        try
        {
            objCitasBE.IdCita = "";
            objCitasBE.IdPaciente = Session["CodP"].ToString();
            objCitasBE.IdEmpleado = Session["CodEmp"].ToString();
            objCitasBE.Fecha = caledario.SelectedDate;
            objCitasBE.HoraInicio =TimeSpan.Parse(cboHorario.SelectedValue);
            objCitasBE.HoraFin = TimeSpan.Parse(cboHorario.SelectedValue);
            

            if (objCitasBL.insertarCita(objCitasBE) == true)
            {
                //Response.Redirect("frmPacientes.aspx");
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

    protected void gvMedicos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int indicefila;

            indicefila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Seleccionar")
            {
                Session["CodEmp"] = gvMedicos.Rows[indicefila].Cells[1].Text;

               // Response.Redirect("frmPacientesActualizar.aspx");
            }

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
        }
    }
}