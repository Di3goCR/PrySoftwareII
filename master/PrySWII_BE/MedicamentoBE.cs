using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class MedicamentoBE
    {
        private string codmed;
        public string IdMedicamento
        {
            get { return codmed; }
            set { codmed = value; }
        }
        private string nombre;
        public string NomMedicamento
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string tipo;
        public string TipoMedicamento
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private string desc;
        public string Descripcion
        {
            get { return desc; }
            set { desc = value; }
        }
        private double prec;
        public double Precio
        {
            get { return prec; }
            set { prec = value; }
        }
        private int stk;
        public int Stock
        {
            get { return stk; }
            set { stk = value; }
        }
    }
}
