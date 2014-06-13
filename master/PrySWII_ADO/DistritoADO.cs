using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrySWII_BE;
using System.Data;
using System.Data.Entity;


namespace PrySWII_ADO
{
    public class DistritoADO
    {

        MiseladaEntities Miselada = new MiseladaEntities();

        public List<DistritoBE> ListarDistrito()
        {
            List<DistritoBE> objListarDistrito = new List<DistritoBE>();

            try
            {
                var query = Miselada.ListarDistrito();

                foreach (var resultado in query)
                {
                    DistritoBE objDistritoBE = new DistritoBE();

                    objDistritoBE.IdDistrito = resultado.IdDistrito;
                    objDistritoBE.Nombre = resultado.Nombre;
                    objListarDistrito.Add(objDistritoBE);
                }
            }

            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

            return objListarDistrito;
        }
    }
}
