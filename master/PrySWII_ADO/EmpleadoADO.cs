using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PrySWII_BE;
using System.Data.Entity;

namespace PrySWII_ADO
{
    public class EmpleadoADO
    {
        MiseladaEntities Miselada = new MiseladaEntities();
        Boolean vexito=false;

        public List<EmpleadoBE> ListarEmpleado()
        {
            
            List<EmpleadoBE> objListarEmpleado = new List<EmpleadoBE>();
            try
            {
                var query = Miselada.ListarEmpleado();
                foreach (var resultado in query)
                { 
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.IdEmpleado = resultado.IdEmpleado;
                    objEmpleadoBE.NomEmpleado = resultado.NomEmpleado;
                    objEmpleadoBE.ApeEmpPat = resultado.ApeEmpPat;
                    objEmpleadoBE.ApeEmpMat = resultado.ApeEmpMat;
                    objEmpleadoBE.Sexo = resultado.Genero;
                    objEmpleadoBE.NroDNI = resultado.NroDNI;
                    objEmpleadoBE.Direccion = resultado.Direccion;
                    objEmpleadoBE.IdDistrito = resultado.Distrito;
                    objEmpleadoBE.Telefono = resultado.Telefono;
                    objEmpleadoBE.Celular = resultado.Celular;
                    objEmpleadoBE.Email = resultado.Email;
                    objEmpleadoBE.IdEspecialidad = resultado.Especialidad;
                    objListarEmpleado.Add(objEmpleadoBE);

                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarEmpleado;

        }

        public bool InsertarEmpleado(EmpleadoBE objempBE)
        {

            try
            {
                
                Empleado objEmpleado = new Empleado();

                objEmpleado.IdEmpleado = String.Empty;
                objEmpleado.ApeEmpPat = objempBE.ApeEmpPat;
                objEmpleado.ApeEmpMat = objempBE.ApeEmpMat;
                objEmpleado.NomEmpleado = objempBE.NomEmpleado;
                objEmpleado.Sexo = objempBE.Sexo;
                objEmpleado.NroDNI = objempBE.NroDNI;
                objEmpleado.Direccion = objempBE.Direccion;
                objEmpleado.IdDistrito = objempBE.IdDistrito;
                objEmpleado.Telefono = objempBE.Telefono;
                objEmpleado.Celular = objempBE.Celular;
                objEmpleado.Email = objempBE.Email;
                objEmpleado.IdEspecialidad = objempBE.IdEspecialidad;
                Miselada.Empleado.Add(objEmpleado);
                Miselada.SaveChanges();
                vexito = true;

            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public bool ActualizarEmpleado(EmpleadoBE objempBE)
        {

            try
            {
                Empleado objEmpleado = (from Emp in Miselada.Empleado
                                           where Emp.IdEmpleado == objempBE.IdEmpleado
                                           select Emp).FirstOrDefault();

                objEmpleado.ApeEmpPat = objempBE.ApeEmpPat;
                objEmpleado.ApeEmpMat = objempBE.ApeEmpMat;
                objEmpleado.NomEmpleado = objempBE.NomEmpleado;
                objEmpleado.Sexo = objempBE.Sexo;
                objEmpleado.NroDNI = objempBE.NroDNI;
                objEmpleado.Direccion = objempBE.Direccion;
                objEmpleado.IdDistrito = objempBE.IdDistrito;
                objEmpleado.Telefono = objempBE.Telefono;
                objEmpleado.Celular = objempBE.Celular;
                objEmpleado.Email = objempBE.Email;
                objEmpleado.IdEspecialidad = objempBE.IdEspecialidad;
                Miselada.SaveChanges();

                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }


        public bool EliminarEmpleado(String strcodemp)
        {

            try
            {
                Empleado objEmpleado = (from Emp in Miselada.Empleado
                                        where Emp.IdEmpleado == strcodemp
                                        select Emp).FirstOrDefault();
                Miselada.Empleado.Remove(objEmpleado);
                Miselada.SaveChanges();
                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public EmpleadoBE ConsultarEmpleado(String strcodemp)
        {
            EmpleadoBE objEmpleadoBE = new EmpleadoBE();

            try
            {
                var query = Miselada.ConsultarEmpleado(strcodemp);

                foreach (var resultado in query)
                {

                    objEmpleadoBE.IdEmpleado = resultado.IdEmpleado;
                    objEmpleadoBE.NomEmpleado = resultado.NomEmpleado;
                    objEmpleadoBE.ApeEmpPat = resultado.ApeEmpPat;
                    objEmpleadoBE.ApeEmpMat = resultado.ApeEmpMat;
                    objEmpleadoBE.Sexo = resultado.Sexo;
                    objEmpleadoBE.NroDNI = resultado.NroDNI;
                    objEmpleadoBE.Direccion = resultado.Direccion;
                    objEmpleadoBE.IdDistrito = resultado.IdDistrito;
                    objEmpleadoBE.Telefono = resultado.Telefono;
                    objEmpleadoBE.Celular = resultado.Celular;
                    objEmpleadoBE.Email = resultado.Email;
                    objEmpleadoBE.IdEspecialidad = resultado.Especialidad;
                    
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objEmpleadoBE;
        }

        public List<EmpleadoBE> ConsultarempleadoEspecialidad(String strCodEsp)
        {
            
            List<EmpleadoBE> objListarEmpleado = new List<EmpleadoBE>();
            try
            {
                
                var query = Miselada.ConsultarEmpleadoEspecialidad(strCodEsp);

                foreach (var resultado in query)
                {
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.IdEmpleado = resultado.IdEmpleado;
                    objEmpleadoBE.ApeEmpPat = resultado.ApeEmpPat;
                    objEmpleadoBE.ApeEmpMat = resultado.ApeEmpMat;
                    objEmpleadoBE.NomEmpleado = resultado.NomEmpleado;
                    objListarEmpleado.Add(objEmpleadoBE);

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objListarEmpleado;
        }

        public List<EmpleadoBE> ConsultarEmpEspecialidad(String strCodEsp)
        {

            List<EmpleadoBE> objListarEmpleado = new List<EmpleadoBE>();
            try
            {

                var query = Miselada.ConsultarEmpEspecialidad(strCodEsp);

                foreach (var resultado in query)
                {
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.IdEmpleado = resultado.IdEmpleado;
                    objEmpleadoBE.ApeEmpPat = resultado.ApeEmpPat;
                    objEmpleadoBE.ApeEmpMat = resultado.ApeEmpMat;
                    objEmpleadoBE.NomEmpleado = resultado.NomEmpleado;
                    objEmpleadoBE.IdEspecialidad = resultado.Especialidad;
                    objEmpleadoBE.Sexo = resultado.Sexo;
                    objEmpleadoBE.NroDNI = resultado.NroDNI;
                    objListarEmpleado.Add(objEmpleadoBE);

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objListarEmpleado;
        }

        public List<EmpleadoBE> ListarEmpleadoDistrito(String strcoddis)
        {

            List<EmpleadoBE> objListarEmpleado = new List<EmpleadoBE>();
            try
            {

                var query = Miselada.ListarEmpleadoDistrito(strcoddis);

                foreach (var resultado in query)
                {
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.IdEmpleado = resultado.IdEmpleado;
                    objEmpleadoBE.ApeEmpPat = resultado.ApeEmpPat;
                    objEmpleadoBE.ApeEmpMat = resultado.ApeEmpMat;
                    objEmpleadoBE.NomEmpleado = resultado.NomEmpleado;
                    objEmpleadoBE.IdEspecialidad = resultado.Especialidad;
                    objEmpleadoBE.Sexo = resultado.Sexo;
                    objEmpleadoBE.NroDNI = resultado.NroDNI;
                    objListarEmpleado.Add(objEmpleadoBE);

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objListarEmpleado;
        }

    }
}
