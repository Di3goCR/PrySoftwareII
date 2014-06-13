using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class CitasBE
    {
        private string codcita;
        public string IdCita
        {
            get { return codcita; }
            set { codcita = value; }
        }

        private string codemp;
        public string IdEmpleado
        {
            get { return codemp; }
            set { codemp = value; }
        }

        private string codpac;
        public string IdPaciente
        {
            get { return codpac; }
            set { codpac = value; }
        }

        private DateTime fec;
        public DateTime Fecha
        {
            get { return fec; }
            set { fec = value; }
        }

        private TimeSpan inicio;
        public TimeSpan HoraInicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        private TimeSpan fin;
        public TimeSpan HoraFin
        {
            get { return fin; }
            set { fin = value; }
        }

        private string _estado;
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private string nombrePaciente;
        public string NomPaciente
        {
            get { return nombrePaciente; }
            set { nombrePaciente = value; }
        }
    }
}
