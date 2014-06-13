using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class EstadoBE
    {
        private string codest;
        public string IdEstado
        {
            get { return codest; }
            set { codest = value; }
        }
        private string est;
        public string Estado
        {
            get { return est; }
            set { est = value; }
        }
        private string codcita;
        public string IdCita
        {
            get { return codcita; }
            set { codcita = value; }
        }
    }
}
