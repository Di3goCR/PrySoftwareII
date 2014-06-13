using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrySWII_ADO;
using PrySWII_BE;

namespace PrySWII_BL
{
    public class CitasBL
    {
        CitaADO objCitas = new CitaADO();

        public bool insertarCita(CitasBE citasbe) {
            return objCitas.InsertarCita(citasbe);
        }

        public List<CitasBE> listarCitas()
        {
            return objCitas.ListarCitas();
        }
        public List<CitasBE> listarCitasEstadoFecha(string stdo,DateTime fInic,DateTime fFin)
        {
            return objCitas.ListarCitasEstadoFecha(stdo, fInic, fFin);
        }
    }
}
