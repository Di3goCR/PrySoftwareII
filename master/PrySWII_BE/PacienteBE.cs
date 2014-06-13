using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class PacienteBE
    {
        private string codpac;
        public string IdPaciente
        {
            get { return codpac; }
            set { codpac = value; }
        }
        private string apepat;
        public string ApePacPat
        {
            get { return apepat; }
            set { apepat = value; }
        }
        private string apemat;
        public string ApePacMat
        {
            get { return apemat; }
            set { apemat = value; }
        }
        private string nombre;
        public string NomPaciente
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
        public string NroIdentidad
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
        private string dist;
        public string IdDistrito
        {
            get { return dist; }
            set { dist = value; }
        }
        private string tel;
        public string Telefono
        {
            get { return tel; }
            set { tel = value; }
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
        private string sangre;
        public string TipSangrePac
        {
            get { return sangre; }
            set { sangre = value; }
        }
        private string talla;
        public string TallaPac
        {
            get { return talla; }
            set { talla = value; }
        }
        private string peso;
        public string PesoPac
        {
            get { return peso; }
            set { peso = value; }
        }   
    }
}
