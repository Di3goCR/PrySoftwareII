using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class AlergiasBE
    {
        private string codalr;
        public string IdAlergias
        {
            get { return codalr; }
            set { codalr = value; }
        }

        private string alrg;
        public string Alergenos
        {
            get { return alrg; }
            set { alrg = value; }
        }
        private string desc;
        public string Descripcion
        {
            get { return desc; }
            set { desc = value; }
        }
        private string codpac;
        public string IdPaciente
        {
            get { return codpac; }
            set { codpac = value; }
        }
    }
}
