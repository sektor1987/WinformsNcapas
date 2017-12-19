using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{

    //https://msdn.microsoft.com/en-us/library/aa581779.aspx
   public class RolBLL
    {
       public Entities_ contexto = new Entities_();
       
       
        public KeyValuePair<int, string> Delete(int id)
        {
           
            try
            {
                TBL_ROL rol = contexto.TBL_ROL.Find(id);
                if (rol != null)
                {
                   
                    contexto.TBL_ROL.Remove(rol);
                    contexto.SaveChanges();
                    return new KeyValuePair<int, string>(0, "Eliminado Correctamente");
                }
                else
                {
                    return new KeyValuePair<int, string>(1, "Rol no encontrado");
                }

            }
            catch (Exception ex/* dex */)
            {
                return new KeyValuePair<int, string>(2, ex.ToString());
            }
            
        }

        public KeyValuePair<int, string> insert(string nombreRol, string descRol, out int newPK)
        {
            newPK = 0;
            TBL_ROL rol = new TBL_ROL();
            try
            {
                rol.NOMBRE_ROL = nombreRol;
                rol.DESC_ROL = descRol;
                contexto.TBL_ROL.Add(rol); //Se cambio la arquitectura de las capas a x64 por la versiòn del odac instalado
                //ref: https://stackoverflow.com/questions/26137256/ef-with-oracle-the-specified-store-provider-cannot-be-found-in-the-configurat
                contexto.SaveChanges();
                //extraemos el id de la entidad insertada
                newPK = Convert.ToInt32(rol.ID_ROL);
                //context.Database.ExecuteSqlCommand("BEGIN  STORED_PROCEDURE_NAME; END; ");  para ejecutar procedimientos almacenados ;D

                return new KeyValuePair<int, string>(0, "Insertado Correctamente");
            }
            catch (Exception ex/* dex */)
            {
                return new KeyValuePair<int, string>(2, ex.ToString());               
            }

           

        }

        public KeyValuePair<int, string> update(int idRol, string nombreRol, string descRol)
        {
            
            try
            {
                TBL_ROL rolOriginal = contexto.TBL_ROL.Find(idRol);

                if (rolOriginal != null)
                {
                    rolOriginal.NOMBRE_ROL = nombreRol;
                    rolOriginal.DESC_ROL = descRol;
                    contexto.SaveChanges();
                    
                    return new KeyValuePair<int, string>(0, "Actualizado Correctamente");
                }
                else
                {
                    return new KeyValuePair<int, string>(1, "Rol no encontrado");
                }

            }
            catch (Exception ex/* dex */)
            {
                return new KeyValuePair<int, string>(2, ex.ToString());
            }

            

        }

        public List<TBL_ROL> getAll()
        {
            var lista = contexto.TBL_ROL.ToList();
            return lista;
        }

        public Tuple<int, string, string> getById(int id)
        {
            
            TBL_ROL rolToSearch = contexto.TBL_ROL.Find(id);

            if (rolToSearch != null)
            {
                return new Tuple<int, string, string>(Convert.ToInt32(rolToSearch.ID_ROL), rolToSearch.NOMBRE_ROL, rolToSearch.DESC_ROL);
            }
            else {
                return new Tuple<int, string, string>(0, "Rol no encontrado", "");

            }
        }


        //public TBL_USUARIO obtenerRolPorUsuario(int rut)
        //{
        //    int s2 = 0;
        //    contexto.en
        //    //TBL_ROL rol = new TBL_ROL();
        //    //var query= from article in db.Articles
        //    //where article.Categories.Any(c=>c.Category_ID==cat_id)
        //    //select article;            select r.Employees;


        //    //string query = "select ID_ROL from tbl_rolusuario where RUT_USUARIO = 1234";
        //    //var result = contexto.Database.SqlQuery<decimal>(query).Single();
        //    //int s2 = contexto.Database.ExecuteSqlCommand(query);

        //    //var query = (from article in Articles
        //    //             from category in article.Categories.Where(x => x.Category_ID == category_id)
        //    //             select article);
        //    //var id = from d in contexto.TBL_USUARIO
        //    //         from r in contexto.TBL_ROL
        //    //         where d.RUT_USUARIO == rut
        //    //         select d;
        //    //var dteUsuario = (from c in contexto.TBL_USUARIO
        //    //                  where c.RUT_USUARIO == idABuscar
        //    //                  select c).FirstOrDefault();

        //    //var rol = (from d in contexto.TBL_ROL
        //    //           where d.TBL_USUARIO.Any(c => c.RUT_USUARIO == 1234)
        //    //           select d).FirstOrDefault();

        //    return rol;

        //}

    }
}
