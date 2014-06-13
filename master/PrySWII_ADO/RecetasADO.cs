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
    public class RecetasADO
    {
        MiseladaEntities Miselada = new MiseladaEntities();
        Boolean vexito = false;

        public bool InsertarReceta(DetalleRecetaBE objRecetaBE)
        {

            try
            {

                Detalle_Receta objReceta = new Detalle_Receta();

                objReceta.IdReceta_Detalle = objRecetaBE.IdReceta_Detalle;
                objReceta.Detalle = objRecetaBE.Detalle;
                objReceta.IdPaciente = objRecetaBE.IdPaciente;
                Miselada.Detalle_Receta.Add(objReceta);
                Miselada.SaveChanges();
                vexito = true;

            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }

        public bool ActualizarReceta(DetalleRecetaBE objrecBE)
        {

            try
            {
                Detalle_Receta objReceta = (from Rec in Miselada.Detalle_Receta
                                        where Rec.IdReceta_Detalle == objrecBE.IdReceta_Detalle
                                        select Rec).FirstOrDefault();
                objReceta.Detalle = objrecBE.Detalle;
                Miselada.SaveChanges();

                vexito = true;
            }

            catch (EntityException exception)
            {
                vexito = false;
            }

            return vexito;
        }


        public bool EliminarReceta(String strcodrec)
        {

            try
            {
                Detalle_Receta objReceta = (from Rec in Miselada.Detalle_Receta
                                            where Rec.IdReceta_Detalle == strcodrec
                                            select Rec).FirstOrDefault();

                Miselada.Detalle_Receta.Remove(objReceta);
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
