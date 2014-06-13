using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;

public partial class Mantenimientos_frmEmpleados : System.Web.UI.Page
{
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                gvEmpleados.DataSource = objEmpleadoBL.ListarEmpleado();
                gvEmpleados.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }

    protected void btnNuevo_Click1(object sender, EventArgs e)
    {
        Response.Redirect("frmEmpleado02.aspx");
    }
    protected void gvEmpleados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int indicefila;

            indicefila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Session["IdEmpleado"] = gvEmpleados.Rows[indicefila].Cells[1].Text;

                Response.Redirect("frmEmpleado01.aspx");
            }

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
        }
    }
}