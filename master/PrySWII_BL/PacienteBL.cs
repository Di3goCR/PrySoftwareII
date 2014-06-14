using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrySWII_BE;
using PrySWII_ADO;

namespace PrySWII_BL
{
    public class PacienteBL
    {
        PacienteADO objpaciente = new PacienteADO();

        public PacienteBE consultarPaciente(String codPac)
        {
            return objpaciente.ConsultarPaciente(codPac);
        }

        public List<PacienteBE> ListarPaciente()
        {
            return objpaciente.ListarPaciente();
        }
        public Boolean InsertarPaciente(PacienteBE objpacBE)
        {
            return objpaciente.InsertarPaciente(objpacBE);
        }

        public Boolean ActualizarPacietne(PacienteBE objpacBE  )
        {
            return objpaciente.ActualizarPaciente(objpacBE);
        }

        public Boolean EliminarPaciente(String codPac)
        {
            return objpaciente.EliminarPaciente(codPac);
        }

        public List<PacienteBE> ListarPacienteDistrito(String codDis)
        {
            return objpaciente.ConsultarPacienteDistrito(codDis);
        }

        public List<PacienteBE> ListarPacienteTSangre(String codTSangre)
        {
            return objpaciente.ConsultarPacienteTipoSangre(codTSangre);
        }

         
    }
}
