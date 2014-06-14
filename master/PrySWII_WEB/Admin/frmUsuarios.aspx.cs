using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using System.Web.Security;
using PrySWII_BE;
using PrySWII_BL;

public partial class Mantenimientos_frmEmpleados : System.Web.UI.Page
{
    LoginBL objEmpleadoBL = new LoginBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                gvEmpleados.DataSource = objEmpleadoBL.listarUsuariosDB();
                gvEmpleados.DataBind();

                Application_Start();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }

    protected void btnNuevo_Click1(object sender, EventArgs e)
    {
        
    }


    void Application_Start()
    {
        Dictionary<int, string> roles = new Dictionary<int, string>();
        roles.Add(2,"Administrador");
        roles.Add(1,"Medico");
        roles.Add(0,"Paciente");


        foreach (var role in roles)
        {
            if (!Roles.RoleExists(role.Value.ToString()))
            {
                Roles.CreateRole(role.Value.ToString());
            }   
        }

       
        List<UsuarioBEDB> listUsers = new LoginBL().listarUsuariosDB();
        PacienteBL pacientebl = new PacienteBL();
        PacienteBE objpaciente = new PacienteBE();
        

        foreach (UsuarioBEDB user in listUsers)
        {
            if (user.estado.Equals("Activo"))
            {
                if (Membership.GetUser(user.usuario) == null)
                {
                    objpaciente = pacientebl.consultarPaciente(user.IdPaciente);
                    Membership.CreateUser(user.usuario, user.contraseña,objpaciente.Email);
                }

                if (!Roles.IsUserInRole(user.usuario,roles[int.Parse(user.Rol)].ToString()))
                {
                    Roles.AddUserToRole(user.usuario, roles[int.Parse(user.Rol)].ToString());
                }
            }
        }
        

    }
}