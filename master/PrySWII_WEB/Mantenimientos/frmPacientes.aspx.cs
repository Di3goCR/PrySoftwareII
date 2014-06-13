using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BE;
using PrySWII_BL;

public partial class Mantenimientos_frmPacientes : System.Web.UI.Page
{
    ClienteBL objPacienteBL = new ClienteBL();


    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                gvPacientes.DataSource = objPacienteBL.ListarPaciente();
                gvPacientes.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmPacientesIngresar.aspx");
    }

    protected void gvPacientes_RowCommand1(object sender, GridViewCommandEventArgs e)
    {


        try
        {
            int indicefila;

            indicefila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Session["IdPaciente"] = gvPacientes.Rows[indicefila].Cells[1].Text;

                Response.Redirect("frmPacientesActualizar.aspx");
            }

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
        }
    }
}