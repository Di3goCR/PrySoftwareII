using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrySWII_ADO;
using PrySWII_BE;

namespace PrySWII_BL
{
    public class EspecialidadesBL
    {
        EspecialidadADO objEspecialidadADO = new EspecialidadADO();

        public List<EspecialidadesBE> ListarEspecialidad()
        {
            return objEspecialidadADO.ListarEspecialidad();
        }
    }
}
