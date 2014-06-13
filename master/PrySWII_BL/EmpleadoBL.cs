using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrySWII_BE;
using PrySWII_ADO;
using System.Threading.Tasks;

namespace PrySWII_BL
{
   public  class EmpleadoBL
    {
       EmpleadoADO objEmpleadoADO = new EmpleadoADO();

       public List<EmpleadoBE> ListarEmpleado()
       {
           return objEmpleadoADO.ListarEmpleado();
       }

       public Boolean InsetarEmpleado(EmpleadoBE emp)
       {
           return objEmpleadoADO.InsertarEmpleado(emp);
       }

       public Boolean ActualizarEmpleado(EmpleadoBE emp)
       {
           return objEmpleadoADO.ActualizarEmpleado(emp);
       }

       public Boolean EliminarEmpleado(String codemp)
       {
           return objEmpleadoADO.EliminarEmpleado(codemp);
       }

       public EmpleadoBE ConsultarEmpleado(String codemp)
       {
           return objEmpleadoADO.ConsultarEmpleado(codemp);
       }

       public List<EmpleadoBE> consultarEmpleadoEspecialidad(String codesp)
       {
           return objEmpleadoADO.ConsultarempleadoEspecialidad(codesp);
       }

       public List<EmpleadoBE> consultarEmpEspecialidad(String codesp)
       {
           return objEmpleadoADO.ConsultarEmpEspecialidad(codesp);
       }

       public List<EmpleadoBE> ListarEmpleadoDistrito(String codesp)
       {
           return objEmpleadoADO.ListarEmpleadoDistrito(codesp);
       }
    }
}
