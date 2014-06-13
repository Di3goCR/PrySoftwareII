using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;

public partial class Consultas_Default : System.Web.UI.Page
{
    CitasBL objCitas = new CitasBL();
    protected void Page_Load(object sender, EventArgs e)
    {

        gvCitas.DataSource = objCitas.listarCitas();
        gvCitas.DataBind();
    }

    protected void gvPacientes_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int indicefila;

            indicefila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Session["IdPaciente"] = gvCitas.Rows[indicefila].Cells[1].Text;

                Response.Redirect("frmPacientesActualizar.aspx");
            }

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
        }
    }
}