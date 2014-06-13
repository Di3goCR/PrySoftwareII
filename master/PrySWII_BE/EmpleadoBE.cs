using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class EmpleadoBE
    {
        private string idemp;
        public string IdEmpleado
        {
            get { return idemp; }
            set { idemp = value; }
        }
        private string apepat;
        public string ApeEmpPat
        {
            get { return apepat; }
            set { apepat = value; }
        }
        private string apemat;
        public string ApeEmpMat
        {
            get { return apemat; }
            set { apemat = value; }
        }
        private string nombre;
        public string NomEmpleado
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string sex;
        public string Sexo
        {
            get { return sex; }
            set { sex = value; }
        }
        private string dni;
        public string NroDNI
        {
            get { return dni; }
            set { dni = value; }
        }
        private string dir;
        public string Direccion
        {
            get { return dir; }
            set { dir = value; }
        }
        private string coddis;
        public string IdDistrito
        {
            get { return coddis; }
            set { coddis = value; }
        }
        private string telf;
        public string Telefono
        {
            get { return telf; }
            set { telf = value; }
        }
        private string cel;
        public string Celular
        {
            get { return cel; }
            set { cel = value; }
        }
        private string mail;
        public string Email
        {
            get { return mail; }
            set { mail = value; }
        }
        private string codesp;
        public string IdEspecialidad
        {
            get { return codesp; }
            set { codesp = value; }
        }
    }
}
