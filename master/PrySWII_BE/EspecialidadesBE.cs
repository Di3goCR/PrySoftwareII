using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class EspecialidadesBE
    {
        private string codesp;
        public string IdEspecialidad
        {
            get { return codesp; }
            set { codesp = value; }
        }
        private string esp;
        public string Especialidad
        {
            get { return esp; }
            set { esp = value; }
        }
    }
}
