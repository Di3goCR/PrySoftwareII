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
    public class ExamenesADO
    {
        MiseladaEntities Miselada = new MiseladaEntities();
        Boolean vexito = false;


        public bool InsertarExamen(ExamenesBE objExamenBE)
        {

            try
            {

                Examenes objExamen = new Examenes();

                objExamen.IdExamen = objExamenBE.IdExamene;
                objExamen.Examem = objExamenBE.Examen;
                objExamen.IdPaciente = objExamenBE.IdPaciente;
                Miselada.Examenes.Add(objExamen);
                Miselada.SaveChanges();
                vexito = true;

            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public bool ActualizarExamen(Examenes objexaBE)
        {

            try
            {
                Examenes objExamen = (from Exa in Miselada.Examenes
                                            where Exa.IdExamen==objexaBE.IdExamen
                                            select Exa).FirstOrDefault();
                objExamen.Examem = objexaBE.Examem;
                Miselada.SaveChanges();

                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }


        public bool EliminarExamen(String strcodexm)
        {

            try
            {
                Examenes objExamen = (from Exa in Miselada.Examenes
                                      where Exa.IdExamen == strcodexm
                                      select Exa).FirstOrDefault();

                Miselada.Examenes.Remove(objExamen);
                Miselada.SaveChanges();
                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

    }
}
