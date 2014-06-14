using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using PrySWII_BE;
using System.Web;

namespace PrySWII_ADO
{
    public class UsuarioADO
    {
        MiseladaEntities Miselada = new MiseladaEntities();

        public UsuarioBEDB ConsultarUsuarioDB(String user)
        {
            UsuarioBEDB objUsuarioBE = new UsuarioBEDB();
            try
            {
                var query = Miselada.usp_obtener_usuario(user);
                foreach (var resultado in query)
                {

                    objUsuarioBE.IdUsuario = resultado.IdUsuairo;
                    objUsuarioBE.usuario = resultado.usuario;
                    objUsuarioBE.contraseña = resultado.contraseña;
                    objUsuarioBE.estado = resultado.estado;
                    objUsuarioBE.IdPaciente = resultado.IdPaciente;
                    objUsuarioBE.Rol = resultado.Rol;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objUsuarioBE;

            /* Usuarios usuario = new Usuarios();

             usuario = (from Emp in Miselada.Usuarios
                              where Emp.usuario == user
                              select Emp).FirstOrDefault();

             UsuarioBEDB usuabedb = new UsuarioBEDB();
             usuabedb.IdUsuario = usuario.IdUsuairo;
             usuabedb.usuario = usuario.usuario;
             usuabedb.contraseña = usuario.contraseña;
             usuabedb.estado = usuario.estado;
             usuabedb.IdPaciente = usuario.IdPaciente;
            */
        }

        public List<UsuarioBEDB> ListarUsuariosDB()
        {
            List<UsuarioBEDB> objListarUsuarios = new List<UsuarioBEDB>();
            try
            {
                var query = Miselada.ListarUsuarios();
                foreach (var resultado in query)
                {
                    UsuarioBEDB objUsuarioBE = new UsuarioBEDB();
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

        public Boolean Insertar(UsuarioBE objUsuarioBE)
        {
            try
            {
                // Agregamos el usuario
                System.Web.Security.Membership.CreateUser(objUsuarioBE.Login, objUsuarioBE.Password,
                                                                                            objUsuarioBE.Email);
                // Lo asignamos al rol elegido desde el combo en la capa GUI
                System.Web.Security.Roles.AddUserToRole(objUsuarioBE.Login, objUsuarioBE.Rol);
                return true;
            }
            catch (System.Web.Security.MembershipCreateUserException ex)
            {
                return false;
            }

        }

    }
}
