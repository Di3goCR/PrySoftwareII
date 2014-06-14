using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PrySWII_BL;
using PrySWII_BE;
public partial class Seguridad_Roles : System.Web.UI.Page
{

    RolBE objRolBE = new RolBE();
    RolBL objRolBL = new RolBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            EnlazarRoles();
        }
    }

    private void EnlazarRoles()
    {
        lstRoles.DataSource = objRolBL.Listar();
        lstRoles.DataTextField = "Rol";
        lstRoles.DataBind();

    }

    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objRolBE.Rol = txtRol.Text;
            if (objRolBL.Insertar(objRolBE))
            {
                EnlazarRoles();
                lblMensaje.Text = "Rol agregado con exito";
                txtRol.Text = String.Empty;
                txtRol.Focus();
            }
            else
            {
                lblMensaje.Text = "Error, rol no se inserto.Revise";
            }
        }
        catch (Exception ex)
        {
         lblMensaje.Text = ex.Message;
        }
           
        
    }

   
}