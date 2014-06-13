using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrySWII_ADO;
using PrySWII_BE;
namespace PrySWII_BL
{
    public class LoginBL
    {
        UsuarioADO login = new UsuarioADO();

        public UsuarioBE validarLogin(String user, String pass)
        {
            return login.validarUsuario(user, pass);
         }

        public List<UsuarioBE> listarUsuarios() {
            return login.ListarUsuarios();
        }

        public List<UsuMedicoBE> ListarUsuarioMedicos()
        {
            return login.ListarUsuariosMedicos();
        }
    }
}
