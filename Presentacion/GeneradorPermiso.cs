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
    public partial class GeneradorPermiso : MetroFramework.Forms.MetroForm
    {
        public GeneradorPermiso()
        {
            InitializeComponent();
        }

        private void GeneradorPermiso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSPermiso.TBL_PERMISO' Puede moverla o quitarla según sea necesario.
            this.tBL_PERMISOTableAdapter.Fill(this.dSPermiso.TBL_PERMISO);
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.TBL_PERMISOUSUARIO' Puede moverla o quitarla según sea necesario.
            this.tBL_PERMISOUSUARIOTableAdapter1.Fill(this.dataSet3.TBL_PERMISOUSUARIO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCodigoMotivoPermiso.TBL_PERMISOUSUARIO' Puede moverla o quitarla según sea necesario.
            this.tBL_PERMISOUSUARIOTableAdapter.Fill(this.dataSetCodigoMotivoPermiso.TBL_PERMISOUSUARIO);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtMotivo.Text == "") {
            //    MessageBox.Show("debe ingresar un motivo válido");
            //    return;
            //}

            DateTime dtFechaInicial = Convert.ToDateTime(this.dtInicio.Text);
            DateTime dtFechaFinal = Convert.ToDateTime(this.dtFin.Text);


            if (dtFechaInicial > dtFechaFinal)
            {
                MessageBox.Show("Rango de fechas no válido");
                return;
            }


            DAL.VS_Login.VHWServiceClient VHWS = new DAL.VS_Login.VHWServiceClient();
           int rutUsuarioGeneraPermiso = (int)Common.rut;
           //rutUsuarioGeneraPermiso = 19;
           //int permisoFuncionario = VHWS.getAntiguedadFun(rutUsuarioGeneraPermiso);

            PermisoBLL permisoBL = new PermisoBLL();
            var motivo = Convert.ToInt32((((System.Data.DataRowView)(cbMotivoPermiso.SelectedValue)).Row).ItemArray[0]);

            int resultadoPermiso = permisoBL.insertarPermiso(dtFechaInicial, dtFechaFinal, (int)Common.rut, motivo);
            Common.LogTxt("Permiso Generado", Common.rut.ToString());
            MessageBox.Show("Permiso solicitado correctamente");
        }

        private void cbMotivoPermiso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
