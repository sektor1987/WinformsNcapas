using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        Entities_ contexto = new Entities_();
        
        public List<TBL_USUARIO> getAll()
        {
            var lista = contexto.TBL_USUARIO.ToList();
            return lista;
        }

        public Tuple<int, string> getById(int id)
        {
            TBL_USUARIO usuarioToSearch = contexto.TBL_USUARIO.Find(id);

            if (usuarioToSearch != null)
            {
                return new Tuple<int, string>(Convert.ToInt32(usuarioToSearch.RUT_USUARIO), usuarioToSearch.PASSWORD);
            }
            else
            {
                return new Tuple<int, string>(0, "Usuario no encontrado");

            }
        }

        public bool loginUsuario(int p_rut, string p_pass){

            
            TBL_USUARIO usuarioToLogin = contexto.TBL_USUARIO.Find(p_rut);

            if (usuarioToLogin !=null && usuarioToLogin.PASSWORD==p_pass)
            {
                return true;
            }
            else
            {
                return false;
            }
              
        }

        public string nomberUsuario(int p_rut)
        {
            return contexto.TBL_USUARIO.Find(p_rut).NOMBRE;
        }

        public TBL_USUARIO datosUsuario(int p_rut)
        {
            return contexto.TBL_USUARIO.Find(p_rut);
        }

        //public int validarLoginUsuario(int rut, string password) {
        //    int respuesta = 0;

        //    var test = contexto.LOGIN_USUARIO(rut, password);
        //    foreach (var item in test.ToList())
        //    {
        //         respuesta = Convert.ToInt32(item.ToString());
        //    }

        //    return respuesta;
        //}

        public int  agregarUsuario(int rut, string apPaterno, string apMaterno, string nombre, string telefonoParticular, string telefonoInstituto, string direccion, int idUnidad, string email, string cargo, int idRol){

                        int rspta = 0;
                
                            try 
                {	                    //public virtual int PKG_MANTENEDOR_USUARIO_SP_AGREGAR_USUARIO(Nullable<decimal> rUT_USUARIO_SP, string aP_PATERNO_SP, string aP_MATERNO_SP, string nOMBRE_SP, string tEL_PARTICULAR_SP, string tEL_INSTITU_SP, string dIR_PARTICU_SP, Nullable<decimal> iD_UNID_SP, string eMAIL_SP, string cARGO_SP)
                                TBL_USUARIO usuario = new TBL_USUARIO();
                                usuario.RUT_USUARIO = rut;
                                usuario.AP_MATERNO = apMaterno;
                                usuario.AP_MATERNO = apMaterno;
                                usuario.NOMBRE = nombre;
                                usuario.TEL_PARTICULAR = telefonoParticular;
                                usuario.TEL_INSTITUCIONAL = telefonoInstituto;
                                usuario.DIR_PARTICULAR = direccion;
                                usuario.ID_UNIDAD_INTERNA = idUnidad;
                                usuario.EMAIL = email;
                                //usuario.ID_ROL = idRol;
                                //usuario.CARGO = cargo;
      
                                //https://stackoverflow.com/questions/4253165/insert-update-many-to-many-entity-framework-how-do-i-do-it
                                var rol = contexto.TBL_ROL.Single(r => r.ID_ROL == idRol);
      
                                //usuario.TBL_ROL.Add(rol);
                                contexto.TBL_USUARIO.Add(usuario);
                                
                          
                                //contexto.TBL_USUARIO.Add(usuario);
                                    //agregamos el rol ahora
                               //no aparece la wea
                                   // usuario.TBL_ROL.Add()
                                    if (contexto.SaveChanges() > 1)
                                    {
                                        rspta = 1;
                                    }
                                    else { rspta = 0; }
		                       // var rsptaa = contexto.PKG_MANTENEDOR_USUARIO_SP_AGREGAR_USUARIO(rut, apPaterno, apMaterno, nombre, telefonoParticular,telefonoInstituto, direccion, idUnidad, email, cargo);
                                
	            }
	            catch (Exception ex)
	            {

                    rspta = 0;
	            };

                            return rspta;
        }


        public int agregarUsuario2(int rut, string apPaterno, string apMaterno, string nombre, string telefonoParticular, string telefonoInstituto, string direccion, int idUnidad, string email, string cargo, int idRol, int tipo = 0)
        {
            //tipo 0: agregar - tipo 1: actualizar

            int rspta = 0;
            string query = "";
            string query2 = "";
            try
            {
  //              
                if (tipo == 0)
                {
                    query = "BEGIN  PKG_MANTENEDOR_USUARIO.sp_agregar_usuario(" + rut + ", '" + apMaterno + "', '" + apMaterno + "', '" + nombre + "','" + telefonoParticular + "', '" + telefonoInstituto + "', '" + direccion + "', " + idUnidad + ",'" + email + "', '" + cargo + "'," +idRol +"); END;";
                    //query2 = "INSERT INTO tbl_rolusuario(RUT_USUARIO, ID_ROL ) VALUES (" + rut + ", " + idRol + ")";

                }
                else {

                    query = "BEGIN  PKG_MANTENEDOR_USUARIO.sp_actualizar_usuario(" + rut + ", '" + apMaterno + "', '" + apMaterno + "', '" + nombre + "','" + telefonoParticular + "', '" + telefonoInstituto + "', '" + direccion + "', " + idUnidad + ",'" + email + "', '" + cargo + "'," + idRol + "); END;";
                    //query2 = "update tbl_rolusuario set ID_ROL = " + idRol + " where RUT_USUARIO = "+rut;
                    //query2 = "BEGIN  PKG_MANTENEDOR_TBL_ROL.sp_actualizar_rol_usuario(" + rut + ", "+idRol + "); END;";
                }
                //var s = contexto.ExecuteStoreQuery<List<string>>("exec " + storedProcedure).ToList();
                var s = contexto.Database.ExecuteSqlCommand(query);
                //var s2 = contexto.Database.ExecuteSqlCommand(query2);
                contexto.SaveChanges();
                //var result = contexto.Database.SqlQuery<decimal>(query).Single();
                //var result2 = contexto.Database.SqlQuery<decimal>(query2).Single();
                //string qry2 = "BEGIN  PKG_MANTENEDOR_USUARIO.sp_agregar_usuario({0}, {1}, {2}, {3},{4}, {5}, {6}, {7},{8}, {9}); END;";
                //var result2 = contexto.Database.ExecuteSqlCommand(qry2, rut, apPaterno, apMaterno, nombre, telefonoParticular, telefonoInstituto, direccion, idUnidad, email, cargo);
                //var s = db.ExecuteStoreQuery<List<string>>("exec " + storedProcedure).ToList();

            }
            catch (Exception ex)
            {

                rspta = 1;
            };

            return rspta;
        }

        public Boolean verificarUserExistente(int rut)
        {


            TBL_USUARIO usuarioToSearch = contexto.TBL_USUARIO.Find(rut);

            if (usuarioToSearch != null)
            {
                return true;
            }
            else {

                return false;
            }

          
        }
        public Dictionary<string, string> ListadoUsuarios()
        {
            Dictionary<string, string> diccionarioUsuarios = new Dictionary<string, string>();
            //int idEmpresa = Convert.ToInt32(Common.empresaId);
            //int idAmbiente = Convert.ToInt32(Common.empresaAmbiente);
            //var listaUsuarios = contexto.Usuarios_empresas.Where(c => c.uem_amb_id == idAmbiente && c.uem_emp_id == idEmpresa).ToList();
            var listaUsuarios = contexto.TBL_USUARIO.ToList();
            diccionarioUsuarios.Add("999", "Crear Nuevo");
            if (listaUsuarios.Count() >= 1)
            {
                foreach (var usuario in listaUsuarios)
                {
                    diccionarioUsuarios.Add(usuario.RUT_USUARIO.ToString(), usuario.NOMBRE.ToString());
                }

            }

            return diccionarioUsuarios;
        }

        public TBL_USUARIO buscarUsuario(string rut)
        {
            int idABuscar = Convert.ToInt32(rut);
            var dteUsuario = (from c in contexto.TBL_USUARIO
                              where c.RUT_USUARIO == idABuscar
                              select c).FirstOrDefault();

            return dteUsuario;

        }

        public Boolean eliminarUsuario(string rut)
        {
            int idABuscar = Convert.ToInt32(rut);
            var usuarioAEliminar = contexto.TBL_USUARIO.SingleOrDefault(x => x.RUT_USUARIO == idABuscar);


            if (usuarioAEliminar != null)
            {
                contexto.TBL_USUARIO.Remove(usuarioAEliminar);
                contexto.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Dictionary<string, string> frmPermisoUsuario(int idSolicitud)
        {
            TBL_SOLICITUDPERMISO solicitudPermiso = new TBL_SOLICITUDPERMISO();
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
             //var dteUsuario = (from c in contexto.TBL_USUARIO
             //                 where c.RUT_USUARIO == idABuscar
             //                 select c).FirstOrDefault();
            solicitudPermiso = (from c in contexto.TBL_SOLICITUDPERMISO
                                where c.ID_SOLICITUD == idSolicitud
                                select c).FirstOrDefault();
            diccionario.Add("idSolicitud", solicitudPermiso.ID_SOLICITUD.ToString());
            diccionario.Add("fechaIni", solicitudPermiso.FECHA_INICIO.ToString());
            diccionario.Add("fechaFin", solicitudPermiso.FECHA_FIN_SOL.ToString());
            diccionario.Add("rutUser", solicitudPermiso.RUT_USUARIO.ToString());

            var motivo = (from c in contexto.TBL_PERMISO
                          where c.ID_PERMISO == solicitudPermiso.MOTIVO
                          select c).FirstOrDefault();
            diccionario.Add("motivo", motivo.RECURSO_LEGAL.ToString());
            return diccionario;
        }

       

    }
}
