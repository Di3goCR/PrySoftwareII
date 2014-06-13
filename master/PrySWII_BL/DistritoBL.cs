using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrySWII_ADO;
using PrySWII_BE;

namespace PrySWII_BL
{
    public class DistritoBL
    {
        DistritoADO objDistritoADO = new DistritoADO();

        public List<DistritoBE> ListarDistrito()
        {
            return objDistritoADO.ListarDistrito();
        }
    }
}
