using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class DetalleExamenesBE
    {
        private string coddetalle;
        public string IdDetalle_Examenes
        {
            get { return coddetalle; }
            set { coddetalle = value; }
        }

        private string detall;
        public string Detalle
        {
            get { return detall; }
            set { detall = value; }
        }

        private string codexamen;
        public string IdExamen
        {
            get { return codexamen; }
            set { codexamen = value; }
        }
    }
}
