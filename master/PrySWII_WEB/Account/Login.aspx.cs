using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrySWII_BL;
using PrySWII_BE;
using System.Web.Security;

public partial class Account_Login : System.Web.UI.Page
{

    String defaultAdmin;

    protected void Page_Load(object sender, EventArgs e)
    {

        Dictionary<int, string> roles = new Dictionary<int, string>();
        roles.Add(2, "Administrador");
        roles.Add(1, "Medico");
        roles.Add(0, "Paciente");

        if (Page.User.IsInRole(roles[2]))
        {

            Response.Redirect("~/Admin/frmUsuarios.aspx", false);
            Session["role"] = roles[2].ToString();
        }

        if (Page.User.IsInRole(roles[1]))
        {
            Response.Redirect("~/Admin/frmUsuarios.aspx", false);
            Session["role"] = roles[1].ToString();
        }
        if (Page.User.IsInRole(roles[0]))
        {
            Response.Redirect("~/Mantenimientos/frmCitas.aspx", false);
            Session["role"] = roles[0].ToString();
        }

        if (!Page.IsPostBack)
        {



        }


    }


    protected void Login2_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Dictionary<int, string> roles = new Dictionary<int, string>();
        roles.Add(2, "Administrador");
        roles.Add(1, "Medico");
        roles.Add(0, "Paciente");
        foreach (var role in roles)
        {
            if (!Roles.RoleExists(role.Value.ToString()))
            {
                Roles.CreateRole(role.Value.ToString());
            }
        }
        defaultAdmin = "DefaultAdmin";

        if (Membership.GetUser(defaultAdmin) == null)
            Membership.CreateUser(defaultAdmin, "default");
        if (!Roles.IsUserInRole(defaultAdmin, roles[2].ToString()))
            Roles.AddUserToRole(defaultAdmin, roles[2].ToString());

        LoginBL login = new LoginBL();
        if (Membership.ValidateUser(myLogin.UserName, myLogin.Password))
        {

            MembershipUser usrInfo = Membership.GetUser(myLogin.UserName);
            if (usrInfo != null)
            {

                e.Authenticated = true;
                if (myLogin.UserName != defaultAdmin)
                {
                    UsuarioBE validado = login.validarLogin(myLogin.UserName, myLogin.Password);
                    Session["codP"] = validado.IdPaciente;

                   // UsuMedicoBE validado = login.validarLogin(myLogin.UserName, myLogin.Password);
                   // Session["codP"] = validado.IdPaciente;
                }

                if (Roles.IsUserInRole(usrInfo.UserName, roles[2].ToString()))
                    myLogin.DestinationPageUrl = "~/Admin/frmUsuarios.aspx";

                if (Roles.IsUserInRole(usrInfo.UserName, roles[1].ToString()))
                    myLogin.DestinationPageUrl = "~/Admin/frmUsuarios.aspx";

                if (Roles.IsUserInRole(usrInfo.UserName, roles[0].ToString()))
                    myLogin.DestinationPageUrl = "~/Mantenimientos/frmCitas.aspx";
            }
        }


        else
        {

            e.Authenticated = false;
        }
    }

}