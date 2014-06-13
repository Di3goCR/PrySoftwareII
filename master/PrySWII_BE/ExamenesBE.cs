using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySWII_BE
{
    public class ExamenesBE
    {
        private string codexm;
        public string IdExamene
        {
            get { return codexm; }
            set { codexm = value; }
        }
        private string exam;
        public string Examen
        {
            get { return exam; }
            set { exam = value; }
        }
        private string codpac;
        public string IdPaciente
        {
            get { return codpac; }
            set { codpac = value; }
        }
    }
}
