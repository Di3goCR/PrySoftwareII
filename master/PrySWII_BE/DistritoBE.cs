using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class DistritoBE
    {
        private string coddis;
        public string IdDistrito
        {
            get { return coddis; }
            set { coddis = value; }
        }

        private string nom;
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
