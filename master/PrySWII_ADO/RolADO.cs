using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrySWII_BE;
using System.Data;

// No olvidarse hacer las referencias al System.Web y System.Web.ApplicationServices
namespace PrySWII_ADO
{
   public class RolADO
    {
       public DataTable Listar()
       {
        // Obtiene todas las descripciones de roles y las almacena en un datatable
        String [] MisRoles;
        int x;
         // Obtienes todos los roles
           MisRoles = System.Web.Security.Roles.GetAllRoles();
        // Crea el datatable
         DataTable mitb = new DataTable();
        mitb.Columns.Add("Rol", Type.GetType("System.String"));
        
           //LLena el datatable con los nombres de roles
           for (x= 0; x <= MisRoles.Length - 1; x ++)
        {
          DataRow dr;
            dr = mitb.NewRow();
            dr["Rol"] = MisRoles[x];
            mitb.Rows.Add(dr);
        
        }
         return mitb;
       
       }

       public Boolean Insertar(RolBE objRolBE )
       { 
         try 
        {
            System.Web.Security.Roles.CreateRole(objRolBE.Rol);
            return true;
        }
         catch (Exception ex)
        {
            return false;
        }
       
       }
    }
}
