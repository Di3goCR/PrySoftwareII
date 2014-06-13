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
    public class CitaADO
    {
        MiseladaEntities Miselada = new MiseladaEntities();
        Boolean vexito = false;

        public List<CitasBE> ListarCitas()
        {

            List<CitasBE> objListarCitas = new List<CitasBE>();
            try
            {
                var query = Miselada.usp_listarCita();
                foreach (var resultado in query)
                {
                    CitasBE objCitaBE = new CitasBE();
                    objCitaBE.IdCita = resultado.IdCita;
                    objCitaBE.IdEmpleado = resultado.Empleado;
                    objCitaBE.IdPaciente = resultado.Paciente;
                    objCitaBE.Fecha = resultado.Fecha;
                    objCitaBE.HoraInicio = resultado.HoraInicio;
                    objCitaBE.HoraFin =resultado.HoraFin;

                    objListarCitas.Add(objCitaBE);

                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarCitas;

        }

        public bool InsertarCita(CitasBE objcitasBE)
        {

            try
            {

                Citas objCitas = new Citas();

                objCitas.IdCita = String.Empty;
                objCitas.IdEmpleado = objcitasBE.IdEmpleado;
                objCitas.IdPaciente = objcitasBE.IdPaciente;
                objCitas.Fecha = objcitasBE.Fecha;
                objCitas.HoraInicio = objcitasBE.HoraInicio;
                objCitas.HoraFin = objcitasBE.HoraFin;
                objCitas.Estado1 = objcitasBE.estado;
                Miselada.Citas.Add(objCitas);
                Miselada.SaveChanges();
                vexito = true;

            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public bool ActualizarCita(CitasBE objcitasBE)
        {

            try
            {
                Citas  objCitas = (from Emp in Miselada.Citas
                                        where Emp.IdCita== objcitasBE.IdCita
                                        select Emp).FirstOrDefault();

                
                objCitas.IdEmpleado = objcitasBE.IdEmpleado;
                objCitas.IdPaciente = objcitasBE.IdPaciente;
                objCitas.Fecha = objcitasBE.Fecha;
                objCitas.HoraInicio = objcitasBE.HoraInicio;
                objCitas.HoraFin = objcitasBE.HoraFin;
                objCitas.Estado1 = objcitasBE.estado;
                
                Miselada.SaveChanges();

                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public List<CitasBE> ListarCitasEstadoFecha(string stdo,DateTime fInic,DateTime fFin)
        {

            List<CitasBE> objListarCitas = new List<CitasBE>();
            try
            {
                var query = Miselada.ConsultarCitaEstadoRango(stdo, fInic, fFin);
                foreach (var resultado in query)
                {
                    CitasBE objCitaBE = new CitasBE();
                    objCitaBE.IdCita = resultado.IdCita;
                    objCitaBE.IdEmpleado = resultado.Empleado;
                    objCitaBE.IdPaciente = resultado.Paciente;
                    objCitaBE.Fecha = resultado.Fecha;
                    objCitaBE.HoraInicio = resultado.HoraInicio;
                    objCitaBE.HoraFin = resultado.HoraFin;
                    objCitaBE.NomPaciente = resultado.Paciente;
                    objCitaBE.estado = resultado.Estado;
                    objListarCitas.Add(objCitaBE);

                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarCitas;

        }
    }
}
