using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity.Migrations;
namespace BLL
{
    public class UnidadInternaBLL
    {
        Entities_ contexto = new Entities_();


        public int eliminar(int idUnidad)
        {
            int result = 0;
            var unidad = contexto.TBL_UNIDADINTERNA.SingleOrDefault(x => x.ID_UNIDAD_INTERNA == idUnidad);

            if (unidad != null)
            {
                contexto.TBL_UNIDADINTERNA.Remove(unidad);
                //contexto.TBL_UNIDADINTERNA.Remove(unidad);
                contexto.SaveChanges();

                result = 1;


            }
            else
            {
                result = 0;
            }


            return result;
        }


        public int agregar(int idUnidad, string descripcion)
        {

            int result = 0;

            try
            {
                TBL_UNIDADINTERNA unidad = new TBL_UNIDADINTERNA();
                unidad.ID_UNIDAD_INTERNA = idUnidad;
                unidad.DESC_UNIDAD_INTERNA = descripcion;
                contexto.TBL_UNIDADINTERNA.Add(unidad);
                contexto.SaveChanges();
                result = 1;
            }
            catch (Exception)
            {

                result = 0;
            }

            return result;
        }


        public int actualizar(int idUnidad, string descripcion)
        {

            int result = 0;

            try
            {
                TBL_UNIDADINTERNA unidad = new TBL_UNIDADINTERNA();
                unidad.ID_UNIDAD_INTERNA = idUnidad;
                unidad.DESC_UNIDAD_INTERNA = descripcion;
                contexto.TBL_UNIDADINTERNA.AddOrUpdate(unidad);
                                                                         contexto.SaveChanges();

                //contexto.TBL_PERMISO.Attach(permiso);
                //contexto.tbl_
                //contexto.Entry(permiso).CurrentValues.SetValues(permiso);
               
                result = 1;
            }
            catch (Exception)
            {

                result = 0;
            }

            return result;
        }

    }
}
