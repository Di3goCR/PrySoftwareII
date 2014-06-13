using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class DetalleRecetaBE
    {
        private string codreceta;
        public string IdReceta_Detalle
        {
            get { return codreceta; }
            set { codreceta = value; }
        }

        private string detall;
        public string Detalle
        {
            get { return detall; }
            set { detall = value; }
        }

        private string codpac;
        public string IdPaciente
        {
            get { return codpac; }
            set { codpac = value; }
        }
    }
}
