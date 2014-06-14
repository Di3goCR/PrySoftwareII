using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PrySWII_BE;
using PrySWII_ADO;

namespace PrySWII_BL
{
   public  class RolBL
    {
       RolADO objRolADO = new RolADO();

       public DataTable Listar()
       {
           return objRolADO.Listar();
       }

       public Boolean Insertar(RolBE objRolBE)
       {
           return objRolADO.Insertar(objRolBE);
       
       }
    }
}
