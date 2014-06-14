using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrySWII_BE
{
   public class UsuarioBE
    {
        private string _Login;
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _Rol;
        public string Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }
        

    }
}
