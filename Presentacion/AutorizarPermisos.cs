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
using Spire.Pdf;
using Spire.Pdf.HtmlConverter;
using System.IO;
using System.Threading;
namespace Presentacion
{
    public partial class frmAutorizarPermisos : MetroFramework.Forms.MetroForm
    {
        public frmAutorizarPermisos()
        {
            InitializeComponent();
        }

        private void AutorizarPermisos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetEstados.TBL_ESTADO' Puede moverla o quitarla según sea necesario.
            this.tBL_ESTADOTableAdapter1.Fill(this.dataSetEstados.TBL_ESTADO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetAutorizarPermiso.TBL_ESTADO' Puede moverla o quitarla según sea necesario.
            this.tBL_ESTADOTableAdapter.Fill(this.dataSetAutorizarPermiso.TBL_ESTADO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetAutorizarPermiso.TBL_SOLICITUDPERMISO' Puede moverla o quitarla según sea necesario.
            this.tBL_SOLICITUDPERMISOTableAdapter.Fill(this.dataSetAutorizarPermiso.TBL_SOLICITUDPERMISO);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdUnidadInterna.Rows)
                {
                    if (row.Selected)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        int rut = Convert.ToInt32(row.Cells[3].Value.ToString());
                        string desc = row.Cells[1].Value.ToString();
                        int valorSeleccionado = Convert.ToInt32(cboEstado.SelectedValue.ToString());
                        PermisoBLL permisoNegocio = new PermisoBLL();
                        Boolean actualizarEstado = permisoNegocio.cambiarEstadoPermiso(valorSeleccionado, id, DateTime.Now, 1);

                        if (actualizarEstado)
                        {
                            MessageBox.Show("Cambios realizados");
                           //enviamos mail en caso de que sea autorizado:
                            if (valorSeleccionado == 3)
                            {

                                  DialogResult res = MessageBox.Show("Desea notificar al empleado de su aprobacion?"
                                , "Confirmar Acción"
                                , MessageBoxButtons.YesNo
                                );
                                  if (res == System.Windows.Forms.DialogResult.Yes)
                                  {
                                      DAL.TBL_USUARIO datosUser = new DAL.TBL_USUARIO();
                                      UsuarioBLL usuarioNegocio = new UsuarioBLL();
                                      datosUser = usuarioNegocio.datosUsuario(rut);

                                      //var udestino = db.TBL_SOLICITUDPERMISO.Include(t => t.TBL_USUARIO).Where(t => t.ID_SOLICITUD == tBL_ESTADOSOLICITUDPERMISO.ID_SOLICITUDPERMISO).First();
                                      BLL.Helper.emailNotification(datosUser.EMAIL, datosUser.NOMBRE + " " + datosUser.AP_PATERNO);
                                      MessageBox.Show("Email enviado");
                                  }
                              
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error al cambiar el estado del permiso");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error: " + ex.ToString());
            }
    
        }

        private void grdUnidadInterna_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdUnidadInterna.Rows)
                {
                    if (row.Selected)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        //string desc = row.Cells[1].Value.ToString();
                        PermisoBLL negocioPermiso = new PermisoBLL();
                        int estadoActual = negocioPermiso.retornaEstadoPermiso(id);
                        if (estadoActual != 9999) { cboEstado.SelectedValue = estadoActual; 
                        } else {
                            MessageBox.Show("la solicitud actual no tiene un estado definido");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error: " + ex.ToString());
            }
    
        }

        private void btnVerPermiso_Click(object sender, EventArgs e)
        {
            PdfDocument pdf = new PdfDocument();
            PdfHtmlLayoutFormat htmlLayoutFormat = new PdfHtmlLayoutFormat();
            htmlLayoutFormat.IsWaiting = false;
            PdfPageSettings setting = new PdfPageSettings();
            setting.Size = PdfPageSize.A4;
            Dictionary<string, string> datosFrm = new Dictionary<string, string>();
            UsuarioBLL negocioUsuario = new UsuarioBLL();
            datosFrm = negocioUsuario.frmPermisoUsuario(1061);
            //string idSolicitud = (new System.Collections.Generic.Mscorlib_DictionaryDebugView<string, string>(datosFrm)).Items[0].Value;
            //string rutFuncionario = (new System.Collections.Generic.Mscorlib_DictionaryDebugView<string, string>(datosFrm)).Items[3].Value;
            //string htmlCode = File.ReadAllText("..\\..\\2.html");
            string htmlCode = @"<h1 style='text-align: center;'><span style='text-decoration: underline;'>COMPROBANTE PERMISO FUNCIONARIO MUNICIPALIDAD VISTA HERMOSA</span></h1>
<p>&nbsp;</p>
<p style='text-align: center;'><em><strong>ID SOLICITUD: {0}</strong></em></p>
<p style='text-align: center;'>&nbsp;</p>
<p style='text-align: center;'><em><strong>RUT FUNCIONARIO: {1}</strong></em></p>
<p style='text-align: center;'>&nbsp;</p>
<p style='text-align: center;'><em><strong>FECHA INICIO SOLICITUD: {2}</strong></em></p>
<p style='text-align: center;'>&nbsp;</p>
<p style='text-align: center;'><em><strong>FECHA FIN SOLICITUD: {3}</strong></em></p>
<p style='text-align: center;'>&nbsp;</p>
<p style='text-align: center;'><em><strong>MOTIVO SOLICITUD: {4}</strong></em></p>
<p style='text-align: center;'>&nbsp;</p>
<p style='text-align: center;'><em><strong>CODIGO VERIFICACION: {5}</strong></em></p>
<p>&nbsp;</p>
<p>&nbsp;</p>";
            htmlCode = string.Format(htmlCode, datosFrm["idSolicitud"], datosFrm["rutUser"], datosFrm["fechaIni"], datosFrm["fechaFin"], datosFrm["motivo"], datosFrm["idSolicitud"] + datosFrm["rutUser"] + datosFrm["idSolicitud"]);
           // htmlCode = "<strong>ID SOLICITUD: test</strong>";
            htmlCode = htmlCode.Replace(System.Environment.NewLine, string.Empty);

            Thread thread = new Thread(() =>
            { pdf.LoadFromHTML(htmlCode, false, setting, htmlLayoutFormat); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            SaveFileDialog MyFiles = new SaveFileDialog();
            MyFiles.Filter = "PDF Files|*.pdf";
            MyFiles.Title = "GUARDAR COMPROBANTE PERMISO";
            MyFiles.DefaultExt = "*.pdf";
            MyFiles.FileName = datosFrm["rutUser"] + "_" + datosFrm["idSolicitud"];
            if (MyFiles.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(MyFiles.FileName))
                {
                    File.Delete(MyFiles.FileName);
                }

                //File.Copy(path, MyFiles.FileName);
                pdf.SaveToFile(MyFiles.FileName);
            }

            
            //System.Diagnostics.Process.Start("output.pdf");


        }

        private void btnSituacionEmp_Click(object sender, EventArgs e)
        {
            DAL.VS_Login.VHWServiceClient VHWS = new DAL.VS_Login.VHWServiceClient();

            try
            {
                string resp = VHWS.getSituacionEmpleado((int)Common.rut);
                MessageBox.Show("Estado Empleado: " + resp);
            }
            catch (Exception)
            {
                
                throw;
            }


        }
    }
}
