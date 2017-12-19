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
using System.Threading;
using DAL;

namespace Presentacion
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        public static UsuarioBLL negocioUsuario = new UsuarioBLL();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            spnLoad.Visible = false;
            lblLoad.Visible = false;
            this.ActiveControl = txtRut;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (txtRut.Text == "")
            {
                MessageBox.Show("Debe ingresar su usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ThreadStart threadStart = new ThreadStart(Execution);
            Thread thread = new Thread(threadStart);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void Execution()
        {
            CheckForIllegalCrossThreadCalls = false;
            metroButton1.Invoke((MethodInvoker)delegate { spnLoad.Visible = true; lblLoad.Visible = true; metroButton1.Enabled = false; });
            Application.DoEvents();
     
            int rutUsuario = Convert.ToInt32(this.txtRut.Text);
            string password = this.txtContraseña.Text;
            DAL.VS_Login.VHWServiceClient VHWS = new DAL.VS_Login.VHWServiceClient();

            Boolean resp = VHWS.Autenticate(rutUsuario, password);

            //int result = negocioUsuario.validarLoginUsuario(rutUsuario, password);
            //if (result == 1)
            if (resp)
            {
                UsuarioBLL negocio = new UsuarioBLL();
                RolBLL rolNegocio = new RolBLL();
                var usuarioActual = negocio.buscarUsuario(rutUsuario.ToString());
               //var rolAsociado =  rolNegocio.getById(rutUsuario);
               Common.direccion = usuarioActual.DIR_PARTICULAR;
               Common.email = usuarioActual.EMAIL;
               Common.rut = usuarioActual.RUT_USUARIO;
               //Common.cargo = usuarioActual.CARGO;
               Common.rol = (int)usuarioActual.ID_ROL;
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
               Common.LogTxt("Usuario Logueado", Common.rut.ToString());
                this.Hide();
                showFormBusqueda();
            }
            else
            {

                 MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK);
                 metroButton1.Invoke((MethodInvoker)delegate { spnLoad.Visible = false; lblLoad.Visible = false; metroButton1.Enabled = true; });

                
            }
           
       

        }


        public void showFormBusqueda()
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            Application.Run();
        }

        private void btnValidezDocumento_Click(object sender, EventArgs e)
        {
            DAL.VS_Login.VHWServiceClient VHWS = new DAL.VS_Login.VHWServiceClient();

            Boolean resp = VHWS.validateDoc(txtDocValidar.Text);
            //Boolean resp = true;
            if (resp == true)
            {
                MessageBox.Show("Documento Valido. Tenga como consideración la fecha de vencimiento de este");
               
            }
            else
            {
                MessageBox.Show("Documento Vencido y/o Codigo Erroneo. Verifique el correcto ingreso del codigo");
            }
            
        }
    }
}
