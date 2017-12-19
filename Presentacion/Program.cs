using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
           // Application.Run(new MantenedorUsuario());
           // Application.Run(new ConsultaPermisosEmpleado());
           // Application.Run(new MantenedorPermisos());
           // Application.Run(new GeneradorPermiso());
           // Application.Run(new ConsultaPermisosEmpleado());
           // Application.Run(new AutorizarPermisos());
           //Application.Run(new Resoluciones());
           // Application.Run(new FRMUnidadInternaMesAnterior());
           // Application.Run(new frmResumenPermisoUI());
        }
    }
}
