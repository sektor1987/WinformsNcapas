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
    public partial class frmResumenPermisoUI : MetroFramework.Forms.MetroForm
    {
        public frmResumenPermisoUI()
        {
            InitializeComponent();
        }

        private void frmResumenPermisoUI_Load(object sender, EventArgs e)
        {
            DAL.VS_Login.VHWServiceClient VHWS = new DAL.VS_Login.VHWServiceClient();

            var resp = VHWS.lstCantidadPermisoEstado().ToList();



            //foreach (var item in resp)
            //{
            //    item.estado = "gola";
            //    //aux.Add(item);
            //}
            var source = new BindingSource(resp, null);
            grdUnidadInterna.DataSource = source;
           

        }

        private void btnDescargaPdf_Click(object sender, EventArgs e)
        {
            PdfDocument pdf = new PdfDocument();
            PdfHtmlLayoutFormat htmlLayoutFormat = new PdfHtmlLayoutFormat();
            htmlLayoutFormat.IsWaiting = false;
            PdfPageSettings setting = new PdfPageSettings();
            setting.Size = PdfPageSize.A4;
            Dictionary<string, string> datosFrm = new Dictionary<string, string>();
            UsuarioBLL negocioUsuario = new UsuarioBLL();
            DAL.VS_Login.VHWServiceClient VHWS = new DAL.VS_Login.VHWServiceClient();

            var resp = VHWS.lstCantidadPermisoEstado().ToList();
            //datosFrm = negocioUsuario.frmPermisoUsuario(1061);
            //string idSolicitud = (new System.Collections.Generic.Mscorlib_DictionaryDebugView<string, string>(datosFrm)).Items[0].Value;
            //string rutFuncionario = (new System.Collections.Generic.Mscorlib_DictionaryDebugView<string, string>(datosFrm)).Items[3].Value;
            //string htmlCode = File.ReadAllText("..\\..\\2.html");
            string htmlCode = @"<h1 style='text-align: center;'><span style='text-decoration: underline;'>Resumen de permisos por unidad interna</span></h1><p>&nbsp;</p>";
            
            foreach (var item in resp) { 

                htmlCode = htmlCode+@"<p style='text-align: center;'><em><strong>ID UNIDAD INTERNA: {0}</strong></em></p>
<p style='text-align: center;'>&nbsp;</p>
<p style='text-align: center;'><em><strong>CANTIDAD: {1}</strong></em></p>
<p style='text-align: center;'>&nbsp;</p>
<p style='text-align: center;'><em><strong>RECURSO LEGAL: {2}</strong></em></p>
<p>&nbsp;</p>
<p>&nbsp;</p>";
                htmlCode = string.Format(htmlCode, item.unidadInterna, item.cantidad, item.recursoLegal);

            }
               
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
            MyFiles.FileName = "resumenPermisoUnidadInterna";
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
    }
}
