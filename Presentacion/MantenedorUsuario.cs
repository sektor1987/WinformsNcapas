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
    public partial class MantenedorUsuario : MetroFramework.Forms.MetroForm
    {
        public static UsuarioBLL negocioUsuario = new UsuarioBLL();
        public MantenedorUsuario()
        {
            InitializeComponent();
        }

        private void MantenedorUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.TBL_ROLUSUARIO' Puede moverla o quitarla según sea necesario.
            this.tBL_ROLUSUARIOTableAdapter.Fill(this.dataSet5.TBL_ROLUSUARIO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetUsuarios.TBL_USUARIO' Puede moverla o quitarla según sea necesario.
            this.tBL_USUARIOTableAdapter.Fill(this.dataSetUsuarios.TBL_USUARIO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetRol.TBL_ROL' Puede moverla o quitarla según sea necesario.
            this.tBL_ROLTableAdapter.Fill(this.dataSetRol.TBL_ROL);
            // TODO: esta línea de código carga datos en la tabla 'dataSetUnidadInterna.TBL_UNIDADINTERNA' Puede moverla o quitarla según sea necesario.
            this.tBL_UNIDADINTERNATableAdapter.Fill(this.dataSetUnidadInterna.TBL_UNIDADINTERNA);
            Dictionary<string, string> listadoUsuarios = new Dictionary<string, string>();
            UsuarioBLL negocio = new UsuarioBLL();
            listadoUsuarios = negocio.ListadoUsuarios();
            cboUsuario.DataSource = new BindingSource(listadoUsuarios, null);
            cboUsuario.DisplayMember = "Value";
            cboUsuario.ValueMember = "Key";


        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try 
	{	        
		  int rut = Convert.ToInt32(txtRut.Text);
            string apPaterno = txtApPat.Text;
            string apMaterno = txtApMat.Text;
            string nombre = txtNombre.Text;
            string telParticular = txtTelPart.Text;
            string telInstituto = txtTelIns.Text;
            string direccion = txtDir.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;
            int UnidadInterna = Convert.ToInt32(cboUnidad.SelectedValue);
            int rolUsuario = Convert.ToInt32(cboRol.SelectedValue);
            KeyValuePair<string, string> selectedUser = (KeyValuePair<string, string>)cboUsuario.SelectedItem;
            string keySearch = selectedUser.Key;
            string valueSearch = selectedUser.Value;
            int tipoAccion = 0;
            string resultado_ = "agregado";
            if (negocioUsuario.verificarUserExistente(rut) && keySearch == "999") {
                MessageBox.Show("el rut asociado ya existe");
                return;
            }
            if (keySearch != "999") { tipoAccion = 1; resultado_ = "actualizado"; }
            int resultadoInsert = negocioUsuario.agregarUsuario2(rut, apPaterno, apPaterno, nombre, telParticular, telInstituto, direccion, UnidadInterna, email, cargo, rolUsuario,tipoAccion);
            MessageBox.Show("Usuario "+ resultado_+" correctamente");
            this.Hide();
            MantenedorUsuario mu = new MantenedorUsuario();
            mu.Show();
	}
	catch (Exception ex)
	{
		
		MessageBox.Show("Se produjo un error: "+ex.ToString());
	}
          
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string key = "";
            ComboBox comboBox = (ComboBox)sender;


            KeyValuePair<string, string> selectedUser = (KeyValuePair<string, string>)cboUsuario.SelectedItem;
            string keySearch = selectedUser.Key;
            string valueSearch = selectedUser.Value;

            if (keySearch != "999")
            {
                //EmpresaServicio servicio = new EmpresaServicio();
                //Usuarios_empresas usuario_empresa = new Usuarios_empresas();
                //usuario_empresa = servicio.buscarUsuario(keySearch);
                //this.txtPasword.Text = usuario_empresa.uem_password;
                //this.txtUsuario.Text = usuario_empresa.uem_rut;
                //cboEmpresa.SelectedValue = usuario_empresa.uem_emp_id.ToString();
                UsuarioBLL negocio = new UsuarioBLL();
                RolBLL rolNegocio = new RolBLL();
                var usuarioActual = negocio.buscarUsuario(keySearch);
                txtApMat.Text = usuarioActual.AP_MATERNO;
                txtApPat.Text = usuarioActual.AP_PATERNO;
                //txtCargo.Text = usuarioActual.CARGO;
                txtDir.Text = usuarioActual.DIR_PARTICULAR;
                txtEmail.Text = usuarioActual.EMAIL;
                txtNombre.Text = usuarioActual.NOMBRE;
                txtTelIns.Text = usuarioActual.TEL_INSTITUCIONAL;
                txtTelPart.Text = usuarioActual.TEL_PARTICULAR;
                txtCargo.Text = usuarioActual.CARGO;
                txtRut.Text = usuarioActual.RUT_USUARIO.ToString();
                cboUnidad.SelectedValue = usuarioActual.ID_UNIDAD_INTERNA;
                try
                {
                    cboRol.SelectedValue = usuarioActual.ID_ROL;
                }
                catch (Exception)
                {

                    cboRol.SelectedValue = 1;
                }
                //cboRol.SelectedValue = ((new System.Collections.Generic.HashSetDebugView<DAL.TBL_ROL>(usuarioActual.TBL_ROL as System.Collections.Generic.HashSet<DAL.TBL_ROL>)).Items[0]).ID_ROL;

              
              //int rol = rolNegocio.obtenerRolPorUsuario((int)usuarioActual.RUT_USUARIO);
                //var results = from r in db.Roles
                //              where roleIds.Contains(r.Id)
                //              select r.Employees;


            }
            else
            {
                txtApMat.Text = "";
                txtApPat.Text = "";
                txtCargo.Text = "";
                txtDir.Text = "";
                txtEmail.Text = "";
                txtNombre.Text = "";
                txtRut.Text = "";
                txtTelIns.Text = "";
                txtTelPart.Text = "";
                cboRol.SelectedValue = 1;
                cboUnidad.SelectedValue = 1;
                txtCargo.Text = "";
            }
            //if (cboEmpresa.SelectedItem != null)
            //{
            //    KeyValuePair<string, string> selectedEmpresar = (KeyValuePair<string, string>)cboEmpresa.SelectedItem;
            //    string keySearchEmpresa = selectedUser.Key;
            //    string valueSearchEmpresa = selectedUser.Value;

            //}


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> selectedUser = (KeyValuePair<string, string>)cboUsuario.SelectedItem;
            string keySearch = selectedUser.Key;
            string valueSearch = selectedUser.Value;
            if (keySearch == "999")
            {
                MessageBox.Show("Debe seleccionar un usuario ya existente");
                return;
            }
            DialogResult mensaje = MessageBox.Show("Está seguro?", "Eliminar Empresa", MessageBoxButtons.YesNo);

            if (mensaje == DialogResult.Yes)
            {
                //do something
                UsuarioBLL negocio = new UsuarioBLL();
                Boolean result = negocio.eliminarUsuario(keySearch);

                if (result)
                {
                    MessageBox.Show("Usuario Eliminado Correctamente");
                    this.Refresh();
                    Refresh();
                    this.Hide();
                    MantenedorUsuario mu = new MantenedorUsuario();
                    mu.Show();
                }
                else
                {
                    MessageBox.Show("Se ha producido un error.");
                }
            }
        }
    }
}
