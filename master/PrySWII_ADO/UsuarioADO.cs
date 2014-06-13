using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using PrySWII_BE;


namespace PrySWII_ADO
{
   public class UsuarioADO
    {
       MiseladaEntities Miselada = new MiseladaEntities();

       public UsuarioBE validarUsuario(String user, String pass)
       {
           Usuarios usuario = new Usuarios();

            usuario = (from Emp in Miselada.Usuarios
                             where Emp.usuario == user
                             select Emp).FirstOrDefault();

            UsuarioBE usuabe = new UsuarioBE();
            usuabe.IdUsuario = usuario.IdUsuairo;
            usuabe.usuario = usuario.usuario;
            usuabe.contraseña = usuario.contraseña;
            usuabe.estado = usuario.estado;
            usuabe.IdPaciente = usuario.IdPaciente;

          
           if (user.Equals(usuario.usuario))
           {
               if (pass.Equals(usuario.contraseña))
               {

                   return usuabe;
               }
               else
                   return null;
           }
           else
           {
               return null;
           }

         
       }

       public List<UsuarioBE> ListarUsuarios()
       {
           List<UsuarioBE> objListarUsuarios = new List<UsuarioBE>();
           try
           {
               var query = Miselada.ListarUsuarios();
               foreach (var resultado in query)
               {
                   UsuarioBE objUsuarioBE = new UsuarioBE();
                   objUsuarioBE.IdUsuario = resultado.IdUsuairo;
                   objUsuarioBE.usuario = resultado.usuario;
                   objUsuarioBE.contraseña = resultado.contraseña;
                   objUsuarioBE.estado = resultado.estado;
                   objUsuarioBE.IdPaciente = resultado.IdPaciente;
                   objUsuarioBE.Rol = resultado.Rol;
                   objListarUsuarios.Add(objUsuarioBE);
               }
           }
           catch (EntityException ex)
           {
               throw new Exception(ex.Message);
           }
           return objListarUsuarios;
       }

       public List<UsuMedicoBE> ListarUsuariosMedicos()
       {
           List<UsuMedicoBE> objListarUsuariosMedicos = new List<UsuMedicoBE>();
           try
           {
               var query = Miselada.ListarUsuMedicos();
               foreach (var resultado in query)
               {
                   UsuMedicoBE objUsuarioBE = new UsuMedicoBE();
                   objUsuarioBE.IdUsuario = resultado.IdUsuario;
                   objUsuarioBE.usuario = resultado.usuario;
                   objUsuarioBE.contraseña = resultado.contraseña;
                   objUsuarioBE.estado = resultado.estado;
                   objUsuarioBE.IdEmpleado = resultado.IdEmpleado;
                   objUsuarioBE.Rol = resultado.rol;
                   objListarUsuariosMedicos.Add(objUsuarioBE);
               }
           }
           catch (EntityException ex)
           {
               throw new Exception(ex.Message);
           }
           return objListarUsuariosMedicos;
       }

    }
}
