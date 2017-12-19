using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity.Migrations;
using System.Globalization;
namespace BLL
{
    public class PermisoBLL
    {
        Entities_ contexto = new Entities_();

        public int eliminar(int idPermiso) {
            int result = 0;
            var permiso = contexto.TBL_PERMISO.SingleOrDefault(x => x.ID_PERMISO == idPermiso);

            if (permiso != null)
            {
                contexto.TBL_PERMISO.Remove(permiso);
                contexto.SaveChanges();
                
                    result = 1;
                

            }
            else {
                result = 0;
            }
           
          
            return result;       
        }


        public int actualizar(int idPermiso, string recursoLegal) {

            int result = 0;

            try
            {
                TBL_PERMISO permiso = new TBL_PERMISO();
                permiso.ID_PERMISO = idPermiso;
                permiso.RECURSO_LEGAL = recursoLegal;
                //contexto.TBL_PERMISO.Attach(permiso);
                //contexto.tbl_
                //contexto.Entry(permiso).CurrentValues.SetValues(permiso);
                contexto.TBL_PERMISO.AddOrUpdate(permiso);
                contexto.SaveChanges();
                result = 1;             
            }
            catch (Exception)
            {

                result = 0;
            }

            return result;
        }


        public int agregar(int idPermiso, string recursoLegal)
        {

            int result = 0;

            try
            {
                TBL_PERMISO permiso = new TBL_PERMISO();
                permiso.ID_PERMISO = idPermiso;
                permiso.RECURSO_LEGAL = recursoLegal;
                contexto.TBL_PERMISO.Add(permiso);
                contexto.SaveChanges();
                //contexto.TBL_PERMISO.Attach(permiso);
                //contexto.tbl_
                //contexto.Entry(permiso).CurrentValues.SetValues(permiso);
                //contexto.TBL_PERMISO.Add(permiso);
                //contexto.SaveChanges();
                result = 1;
            }
            catch (Exception)
            {

                result = 0;
            }

            return result;
        }


        //public int insertarPermiso(DateTime fechaInicio, DateTime fechaFin, int rutUsuario, int motivo) {
        //        int rspta = 0;
        //                try
        //                {
        //                    decimal sequence = 0;
        //             TBL_SOLICITUDPERMISO solicitudPermiso = new TBL_SOLICITUDPERMISO();
        //             sequence = contexto.Database.SqlQuery<decimal>("select TBL_SOLICITUDPERMISO_SEQ.nextval from dual").Single();
        //             solicitudPermiso.ID_SOLICITUD = sequence;
        //                solicitudPermiso.FECHA_INICIO = fechaInicio;
        //                solicitudPermiso.FECHA_FIN_SOL = fechaFin;
        //                solicitudPermiso.RUT_USUARIO = rutUsuario;
        //                solicitudPermiso.MOTIVO = motivo;

        //                contexto.TBL_SOLICITUDPERMISO.Add(solicitudPermiso);
        //                contexto.SaveChanges();
        //                    //guardamos el estado de la solicitud
        //                insertarEstadoSolicitudPermiso(1, sequence, "", 0);

        //                    //actualizamos permisos usuario
        //                    //pendiente
        //                var updatePermisos = contexto.Database.SqlQuery<string>("UPDATE tbl_permisousuario SET dias_autorizados=dias_autorizados-var_dias_dif-1 WHERE rut_usuario=" + rutUsuario + " AND id_permiso=" + motivo).Single();

        //                    rspta = 1;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("error: "+ex.InnerException.Message.ToString());
        //            rspta = 0;
        //        }

        //    return rspta;
          
        //}

        public int insertarPermiso(DateTime fechaInicio, DateTime fechaFin, int rutUsuario, int motivo)
        {
            int rspta = 0;
            try
            {
                string fechaInicioFormateada = fechaInicio.ToString("dd-MM-yyyy");
                string fechaFinFormateada = fechaFin.ToString("dd-MM-yyyy");

                //SP MALO
                string query = "BEGIN  PKG_MANTENEDOR_SOLICITUD.sp_insertar_permiso('" + fechaFinFormateada + "', '" + fechaFinFormateada + "', " + rutUsuario + ", " + motivo + "); END; ";
                var result = contexto.Database.ExecuteSqlCommand(query);

                rspta = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.InnerException.Message.ToString());
                rspta = 0;
            }

            return rspta;

        }

        public int insertarEstadoSolicitudPermiso(int id_estado, decimal id_solicitudpermiso, string fh_estado, int responsable_id)
        {//id_estado, id_solicitudpermiso, fh_estado, responsable_id
            int rspta = 0;
            try
            {
                TBL_ESTADOSOLICITUDPERMISO esp = new TBL_ESTADOSOLICITUDPERMISO();
                esp.ID_ESTADO = id_estado;
                esp.ID_SOLICITUDPERMISO = id_solicitudpermiso;
                esp.FH_ESTADO = DateTime.Now;
                esp.RESPONSABLE_ID = responsable_id;
                contexto.TBL_ESTADOSOLICITUDPERMISO.Add(esp);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.InnerException.Message.ToString());
                rspta = 0;
            }

            return rspta;

        }

        public Boolean cambiarEstadoPermiso(int idEstado, int idSolicitudPermiso, DateTime fh_estado, int responsableId) {

            try
            {
                var original = contexto.TBL_ESTADOSOLICITUDPERMISO.Where(x => x.ID_SOLICITUDPERMISO == idSolicitudPermiso).FirstOrDefault();
                TBL_ESTADOSOLICITUDPERMISO estadoSolicitudPermido = new TBL_ESTADOSOLICITUDPERMISO();
                estadoSolicitudPermido.ID_SOLICITUDPERMISO = idSolicitudPermiso;
                estadoSolicitudPermido.ID_ESTADO = idEstado;
                
                estadoSolicitudPermido.RESPONSABLE_ID = 1;
                if (original != null)
                {

                   // string fechaFinFormateada = fechaFin.ToString("dd-MM-yyyy");

                    //SP MALO
                    string query = "BEGIN  PKG_MANTENEDOR_SOLICITUD.sp_actualizar_estadoper(" + original.ID_ESTADO + ", " + idEstado + ", " + idSolicitudPermiso + ", " + 1 + "); END; ";
                    //  PROCEDURE sp_actualizar_estadoper(id_estado_sp tbl_estadosolicitudpermiso.ID_ESTADO%TYPE, id_estadonuevo_sp tbl_estadosolicitudpermiso.ID_ESTADO%TYPE, id_permiso_sp tbl_solicitudpermiso.id_solicitud%TYPE, RESPONSABLE_ID_sp tbl_estadosolicitudpermiso.responsable_id%TYPE);
                    try
                    {
                        var result = contexto.Database.SqlQuery<decimal>(query).Single();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.ToString());
                    }
                    









                    //estadoSolicitudPermido.FH_ESTADO = original.FH_ESTADO;
                    //contexto.Entry(original).CurrentValues.SetValues(estadoSolicitudPermido);

                }
                else {
                    estadoSolicitudPermido.FH_ESTADO = fh_estado;
                    contexto.TBL_ESTADOSOLICITUDPERMISO.Add(estadoSolicitudPermido);
                }

                
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
         
        }

        public int retornaEstadoPermiso(int idSolicitud)
        {


            var original = contexto.TBL_ESTADOSOLICITUDPERMISO.Where(x => x.ID_SOLICITUDPERMISO == idSolicitud).FirstOrDefault();

            if (original != null) { return Convert.ToInt32(original.ID_ESTADO); } else { return 9999; }
        }

            //fec_inicio_sp tbl_solicitudpermiso.fecha_inicio%TYPE, fec_fin_sp tbl_solicitudpermiso.fecha_fin_sol%TYPE, rut_usuario_sp tbl_solicitudpermiso.rut_usuario%TYPE, motivo_sp tbl_solicitudpermiso.motivo%TYPE
        }
    }

