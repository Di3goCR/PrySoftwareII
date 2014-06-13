using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class UsuMedicoBE
    {
        private string codusu;
        public string IdUsuario
        {
            get { return codusu; }
            set { codusu = value; }
        }
        private string usu;
        public string usuario
        {
            get { return usu; }
            set { usu = value; }
        }
        private string pw;
        public string contraseña
        {
            get { return pw; }
            set { pw = value; }
        }
        private string est;
        public string estado
        {
            get { return est; }
            set { est = value; }
        }
        private string codemp;
        public string IdEmpleado
        {
            get { return codemp; }
            set { codemp = value; }
        }
        private string _rol;
        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
    }
}
