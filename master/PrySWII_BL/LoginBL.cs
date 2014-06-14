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

        public UsuarioBEDB consultarUsuarioDB(String user)
        {
            return login.ConsultarUsuarioDB(user);
         }

        public List<UsuarioBEDB> listarUsuariosDB() {
            return login.ListarUsuariosDB();
        }

        public List<UsuMedicoBE> ListarUsuarioMedicos()
        {
            return login.ListarUsuariosMedicos();
        }
    }
}
