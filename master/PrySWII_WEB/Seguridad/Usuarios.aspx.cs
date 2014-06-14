using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;

public partial class Seguridad_Usuarios : System.Web.UI.Page
{

    RolBL objRolBL = new RolBL();
    UsuarioBE objUsuarioBE = new UsuarioBE();
    UsuarioBL objUsuarioBL = new UsuarioBL();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            try
            {
                 if (objRolBL.Listar().Rows.Count == 0)
                 {                 
                    lblMensaje.Text = "No hay Roles para asignar";
                    btnGrabar.Enabled = false;
                 }
                else
                 {
                    cboRoles.DataSource = objRolBL.Listar();
                    cboRoles.DataTextField = "Rol";
                    cboRoles.DataBind();
                    btnGrabar.Enabled = true;
                 }
                    
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            
            }
        }
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objUsuarioBE.Login = txtuser.Text;
            objUsuarioBE.Password = txtPassword.Text;
            objUsuarioBE.Email = txtEmail.Text;
            objUsuarioBE.Rol = cboRoles.Text;
            if( objUsuarioBL.Insertar(objUsuarioBE))
            {
             lblMensaje.Text = "Usuario registrado con exito";
                txtuser.Text = String.Empty;
                txtPassword.Text = String.Empty;
                txtEmail.Text = String.Empty;
            }
            else
            {
                lblMensaje.Text = "Error, usuario no se inserto. Revise";
              }
          }
        catch (Exception ex)
        {
            lblMensaje.Text = ex.Message;
    }


    }
}