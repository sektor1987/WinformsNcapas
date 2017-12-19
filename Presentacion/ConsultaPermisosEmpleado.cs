using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmConsultaPermisosEmpleado : MetroFramework.Forms.MetroForm
    {
        public frmConsultaPermisosEmpleado()
        {
            InitializeComponent();
        }

        private void ConsultaPermisosEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'permisosUsuariosDataSet.VW_CANTIDAD_PERMISOS_USUARIOS' Puede moverla o quitarla según sea necesario.
            this.vW_CANTIDAD_PERMISOS_USUARIOSTableAdapter.Fill(this.permisosUsuariosDataSet.VW_CANTIDAD_PERMISOS_USUARIOS);

        }
    }
}
