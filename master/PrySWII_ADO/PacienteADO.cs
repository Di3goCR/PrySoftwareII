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
    public class PacienteADO
    {
        Boolean vexito = false;
        MiseladaEntities Miselada = new MiseladaEntities();

        public List<PacienteBE> ListarPaciente()
        {

            List<PacienteBE> objListarPaciente = new List<PacienteBE>();
            try
            {
                var query = Miselada.ListarPaciente();
                foreach (var resultado in query)
                {
                    PacienteBE objPacienteBE = new PacienteBE();
                    objPacienteBE.IdPaciente = resultado.IdPaciente;
                    objPacienteBE.ApePacPat = resultado.ApePacPat;
                    objPacienteBE.ApePacMat = resultado.ApePacMat;
                    objPacienteBE.NomPaciente = resultado.NomPaciente;
                    objPacienteBE.Sexo = resultado.Genero;
                    objPacienteBE.NroIdentidad = resultado.NroIdentidad;
                    objPacienteBE.Direccion = resultado.Direccion;
                    objPacienteBE.IdDistrito = resultado.Distrito;
                    objPacienteBE.Telefono = resultado.Telefono;
                    objPacienteBE.Celular = resultado.Celular;
                    objPacienteBE.Email = resultado.Email;
                    objPacienteBE.TipSangrePac = resultado.TipSangrePac;
                    objPacienteBE.TallaPac = resultado.TallaPac;
                    objPacienteBE.PesoPac = resultado.PesoPac;
                    objListarPaciente.Add(objPacienteBE);
                    

                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarPaciente;

        }

        public bool InsertarPaciente(PacienteBE objpacBE)
        {

            try
            {

                Paciente objPaciente = new Paciente();

                objPaciente.IdPaciente = objpacBE.IdPaciente;
                objPaciente.ApePacPat = objpacBE.ApePacPat;
                objPaciente.ApePacMat = objpacBE.ApePacMat;
                objPaciente.NomPaciente = objpacBE.NomPaciente;
                objPaciente.Sexo = objpacBE.Sexo;
                objPaciente.NroIdentidad = objpacBE.NroIdentidad;
                objPaciente.Direccion = objpacBE.Direccion;
                objPaciente.IdDistrito = objpacBE.IdDistrito;
                objPaciente.Telefono = objpacBE.Telefono;
                objPaciente.Celular = objpacBE.Celular;
                objPaciente.Email = objpacBE.Email;
                objPaciente.TipSangrePac = objpacBE.TipSangrePac;
                objPaciente.TallaPac = objpacBE.TallaPac;
                objPaciente.PesoPac = objpacBE.PesoPac;

                Miselada.Paciente.Add(objPaciente);
                Miselada.SaveChanges();
                vexito = true;

            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public bool ActualizarPaciente(PacienteBE objpacBE)
        {

            try
            {
                Paciente objPaciente = (from Pac in Miselada.Paciente
                                        where Pac.IdPaciente==objpacBE.IdPaciente
                                        select Pac).FirstOrDefault();
                objPaciente.ApePacPat = objpacBE.ApePacPat;
                objPaciente.ApePacMat = objpacBE.ApePacMat;
                objPaciente.NomPaciente = objpacBE.NomPaciente;
                objPaciente.Sexo = objpacBE.Sexo;
                objPaciente.NroIdentidad = objpacBE.NroIdentidad;
                objPaciente.Direccion = objpacBE.Direccion;
                objPaciente.IdDistrito = objpacBE.IdDistrito;
                objPaciente.Telefono = objpacBE.Telefono;
                objPaciente.Celular = objpacBE.Celular;
                objPaciente.Email = objpacBE.Email;
                objPaciente.TipSangrePac = objpacBE.TipSangrePac;
                objPaciente.TallaPac = objpacBE.TallaPac;
                objPaciente.PesoPac = objpacBE.PesoPac;
                Miselada.SaveChanges();

                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }


        public bool EliminarPaciente(String strcodpac)
        {

            try
            {
                Paciente objPaciente = (from Pac in Miselada.Paciente
                                        where Pac.IdPaciente == strcodpac
                                        select Pac).FirstOrDefault();

                Miselada.Paciente.Remove(objPaciente);
                Miselada.SaveChanges();
                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public PacienteBE ConsultarPaciente(string codpac)
        {
            
            PacienteBE objPacienteBE = new PacienteBE();

            try
            {
                var query = Miselada.ConsultarPaciente(codpac);

                foreach (var resultado in query)
                {
                    objPacienteBE.IdPaciente = resultado.IdPaciente;
                    objPacienteBE.ApePacPat = resultado.ApePacPat;
                    objPacienteBE.ApePacMat = resultado.ApePacMat;
                    objPacienteBE.NomPaciente = resultado.NomPaciente;
                    objPacienteBE.Sexo = resultado.Sexo;
                    objPacienteBE.NroIdentidad = resultado.NroIdentidad;
                    objPacienteBE.Direccion = resultado.Direccion;
                    objPacienteBE.IdDistrito = resultado.IdDistrito;
                    objPacienteBE.Telefono = resultado.Telefono;
                    objPacienteBE.Celular = resultado.Celular;
                    objPacienteBE.Email = resultado.Email;
                    objPacienteBE.TipSangrePac = resultado.TipSangrePac;
                    objPacienteBE.TallaPac = resultado.TallaPac;
                    objPacienteBE.PesoPac = resultado.PesoPac;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objPacienteBE;

        }
        public List<PacienteBE> ConsultarPacienteDistrito(string codDis)
        {

            List<PacienteBE> objListaPacienteBE = new List<PacienteBE>();

            try
            {
                var query = Miselada.ListarPacienteDistrito(codDis);

                foreach (var resultado in query)
                {
                    PacienteBE objPacienteBE = new PacienteBE();
                    objPacienteBE.IdPaciente = resultado.IdPaciente;
                    objPacienteBE.ApePacPat = resultado.ApePacPat;
                    objPacienteBE.ApePacMat = resultado.ApePacMat;
                    objPacienteBE.NomPaciente = resultado.NomPaciente;
                    objPacienteBE.Sexo = resultado.Sexo;
                    objPacienteBE.NroIdentidad = resultado.NroIdentidad;
                    objPacienteBE.Direccion = resultado.Direccion;
                    objPacienteBE.Telefono = resultado.Telefono;
                    objPacienteBE.Celular = resultado.Celular;
                    objPacienteBE.Email = resultado.Email;
                    objPacienteBE.TipSangrePac = resultado.TipSangrePac;
                    objPacienteBE.TallaPac = resultado.TallaPac;
                    objPacienteBE.IdDistrito = resultado.IdDistrito;
                    objListaPacienteBE.Add(objPacienteBE);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objListaPacienteBE;

        }

        public List<PacienteBE> ConsultarPacienteTipoSangre(string codTSangre)
        {

            List<PacienteBE> objListaPacienteBE = new List<PacienteBE>();

            try
            {
                var query = Miselada.ListarPacienteTipoSangre(codTSangre);

                foreach (var resultado in query)
                {
                    PacienteBE objPacienteBE = new PacienteBE();
                    objPacienteBE.IdPaciente = resultado.IdPaciente;
                    objPacienteBE.ApePacPat = resultado.ApePacPat;
                    objPacienteBE.ApePacMat = resultado.ApePacMat;
                    objPacienteBE.NomPaciente = resultado.NomPaciente;
                    objPacienteBE.Sexo = resultado.Sexo;
                    objPacienteBE.NroIdentidad = resultado.NroIdentidad;
                    objPacienteBE.Direccion = resultado.Direccion;
                    objPacienteBE.Telefono = resultado.Telefono;
                    objPacienteBE.Celular = resultado.Celular;
                    objPacienteBE.Email = resultado.Email;
                    objPacienteBE.TipSangrePac = resultado.TipSangrePac;
                    objPacienteBE.TallaPac = resultado.TallaPac;
                    objPacienteBE.IdDistrito = resultado.IdDistrito;
                    objListaPacienteBE.Add(objPacienteBE);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return objListaPacienteBE;

        }




    }
}
