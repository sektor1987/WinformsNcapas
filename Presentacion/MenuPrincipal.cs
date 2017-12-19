using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace Presentacion
{
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
          //  switch (Common.rol)
          //  {
          //   case 1:
          //          //btnMantenedorTipos.Enabled = true;
          //          //btnMantenedorMotivos.Enabled = true;
          //          //btnMantenedorTipos.Enabled = true;
          //          btnConsultaPermisosEmp.Enabled = true;
          //          //btnVerificarDoc.Enabled = true;
          //          btnMantenedorUsuarios.Enabled = true;
                    
          //          //borrar

          //    break;
          //case 2:
          //    btnConsultaPermisosEmp.Enabled = true;
          //     btnResumenPermisos.Enabled = true;
          //    break;
          //case 3:
          //    btnGeneraResolucion.Enabled = true;
          //    break;
          //case 4:
          //    //btnVerificarDoc.Enabled = true;
          //    btnAutorizarPermiso.Enabled = true;
          //    break;
          //case 5:
          //    btnGeneraPermisos.Enabled = true;
          //   // btnVerificarDoc.Enabled = true;
          //    btnConsultaPermisosEmp.Enabled = true;
          //    break;
          //default:
          //    Console.WriteLine("Default case");
          //    break;
          //  }

            switch (Common.rol)
            {
                case 1:
                    btnMantenedorUnidades.Enabled = true;
                    btnGeneraPermisos.Enabled = true;
                    btnAutorizarPermiso.Enabled = true;
                    btnConsultaPermisosEmp.Enabled = true;
                    btnGeneraResolucion.Enabled = true;
                    btnResumenResMesAnterior.Enabled = true;
                    btnResumenPermisos.Enabled = true;
                    btnMantenedorUsuarios.Enabled = true;
                    btnResumenPermisosUI.Enabled = true;

                    break;
                case 2:
                    btnConsultaPermisosEmp.Enabled = true;
                    btnGeneraResolucion.Enabled = true;
                    btnResumenPermisosUI.Enabled = true;

                    break;
                case 3:
                    btnGeneraResolucion.Enabled = true;
                    btnConsultaPermisosEmp.Enabled = true;
                    btnResumenPermisosUI.Enabled = true;

                    break;
                case 4:
                    btnAutorizarPermiso.Enabled = true;
                    btnConsultaPermisosEmp.Enabled = true;

                    break;
                case 5:
                    btnGeneraPermisos.Enabled = true;
                    btnConsultaPermisosEmp.Enabled = true;
                    btnGeneraPermisos.Enabled = true;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        private void btnResumenPermisos_Click(object sender, EventArgs e)
        {
            frmResoluciones frma = new frmResoluciones();
            frma.Show();
        }

        private void btnMantenedorUnidades_Click(object sender, EventArgs e)
        {
            frmMantenedorPermisos mp = new frmMantenedorPermisos();
            mp.Show();
        }

        private void btnMantenedorMotivos_Click(object sender, EventArgs e)
        {

        }

        private void btnMantenedorTipos_Click(object sender, EventArgs e)
        {

        }

        private void btnMantenedorUsuarios_Click(object sender, EventArgs e)
        {
            MantenedorUsuario mp = new MantenedorUsuario();
            mp.Show();
        }

        private void btnGeneraResolucion_Click(object sender, EventArgs e)
        {
            frmResoluciones frs = new frmResoluciones();
            frs.Show();
        }

        private void btnAutorizarPermiso_Click(object sender, EventArgs e)
        {
            frmAutorizarPermisos fap = new frmAutorizarPermisos();
            fap.Show();
        }

        private void btnConsultaPermisosEmp_Click(object sender, EventArgs e)
        {
            frmConsultaPermisosEmpleado cpe = new frmConsultaPermisosEmpleado();
            cpe.Show();
        }

        private void btnResumenResMesAnterior_Click(object sender, EventArgs e)
        {
            FRMUnidadInternaMesAnterior frma = new FRMUnidadInternaMesAnterior();
            frma.Show();
        }

        private void btnResumenPermisosUI_Click(object sender, EventArgs e)
        {
            frmResumenPermisoUI rui = new frmResumenPermisoUI();
            rui.Show();
        }

        private void btnGeneraPermisos_Click(object sender, EventArgs e)
        {
            GeneradorPermiso gp = new GeneradorPermiso();
            gp.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
