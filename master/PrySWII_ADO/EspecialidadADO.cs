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
    public class EspecialidadADO
    {
        MiseladaEntities Miselada = new MiseladaEntities();
        
        public List<EspecialidadesBE> ListarEspecialidad()
        {
            List<EspecialidadesBE> objListarEspecialidad = new List<EspecialidadesBE>();

            try
            {
                var query = Miselada.ListarEspecialidad();

                foreach (var resultado in query)
                {
                    EspecialidadesBE objEspecialidadBE = new EspecialidadesBE();

                    objEspecialidadBE.IdEspecialidad = resultado.IdEspecialidades;
                    objEspecialidadBE.Especialidad = resultado.Especialidad;
                    objListarEspecialidad.Add(objEspecialidadBE);
                }
            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

            return objListarEspecialidad;
        }

    }
}
