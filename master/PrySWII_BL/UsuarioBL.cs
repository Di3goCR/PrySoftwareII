using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrySWII_ADO;

using PrySWII_BE;

namespace PrySWII_BL
{
   public  class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public Boolean Insertar(UsuarioBE objUsuarioBE)
        {
            return objUsuarioADO.Insertar(objUsuarioBE);
        
        }

    }
}
