using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  static class Common
    {
        //public static string token;
        //public static string empresaRut;
        //public static string userLogin;
        //public static string passwordLogin;
        //public static string empresaAmbiente;
        //public static string empresaRazonSocial;
        //public static string empresaUsuario;
        //public static string empresaContrasena;
        //public static string empresaId;
        //public static string IdUsuario;
        //public static string fechaPivot;
        //public static Boolean _procesarPivot;
        //public static Boolean isAdmin;
        //public static Boolean isSuperAdmin;
        //public static int LimiteDescarga;

        public static string cargo;
        public static string direccion;
        public static string email;
        public static decimal rut;
        public static int rol;
        //txtApMat.Text = usuarioActual.AP_MATERNO;
        //txtApPat.Text = usuarioActual.AP_PATERNO;
        //txtCargo.Text = usuarioActual.CARGO;
        //txtDir.Text = usuarioActual.DIR_PARTICULAR;
        //txtEmail.Text = usuarioActual.EMAIL;
        //txtNombre.Text = usuarioActual.NOMBRE;
        //txtTelIns.Text = usuarioActual.TEL_INSTITUCIONAL;
        //txtTelPart.Text = usuarioActual.TEL_PARTICULAR;
        //txtCargo.Text = usuarioActual.CARGO;
        //txtRut.Text = usuarioActual.RUT_USUARIO.ToString();
        //cboUnidad.SelectedValue = usuarioActual.ID_UNIDAD_INTERNA;
        //Auxiliar para saber cuantos documentos lleva descargados actualmente.
        public static int LimiteDescargaActual;

        //public static bool checkearInternet()
        //{
        //    try
        //    {
        //        using (var client = new WebClient())
        //        {
        //            using (client.OpenRead("http://bcn.getdte.cl/"))
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        /// <summary>
        /// Ingresa informacion al log, que queda en root
        /// </summary>
        /// <param name="logMessage">Descripcion</param>
        /// <param name="user">Usuario</param>
        /// <returns>nada</returns>
        public static void LogTxt(string logMessage, string user)
        {
            Console.WriteLine(logMessage);
            using (StreamWriter writer = new StreamWriter("E:\\backup portafolio\\FINAL\\portafolio_titulo\\portafolioAPP\\" + "userlog_" + FileDate() + ".txt", true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString() + "][" + user + "][" + logMessage + "]");
                writer.WriteLine();
            }
        }

        static string FileDate()
        {
            return DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd");
        }
    }
}
