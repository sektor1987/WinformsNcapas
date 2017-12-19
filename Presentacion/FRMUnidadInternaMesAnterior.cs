using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using BLL;
using System.Threading;
using DAL;
namespace Presentacion
{
    public partial class FRMUnidadInternaMesAnterior : MetroFramework.Forms.MetroForm
    {
        public FRMUnidadInternaMesAnterior()
        {
            InitializeComponent();
        }

        private void FRMUnidadInternaMesAnterior_Load(object sender, EventArgs e)
        {
            DAL.VS_Login.VHWServiceClient VHWS = new DAL.VS_Login.VHWServiceClient();

            var resp = VHWS.getResolucionAllMesAnterior().ToList();



            //foreach (var item in resp)
            //{
            //    item.estado = "gola";
            //    //aux.Add(item);
            //}
            var source = new BindingSource(resp, null);
            grdUnidadInterna.DataSource = source;
           

        }
    }
}
