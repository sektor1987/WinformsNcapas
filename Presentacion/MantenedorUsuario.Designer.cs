namespace Presentacion
{
    partial class MantenedorUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRut = new MetroFramework.Controls.MetroTextBox();
            this.txtApPat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtApMat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTelPart = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTelIns = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCargo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cboUsuario = new MetroFramework.Controls.MetroComboBox();
            this.cboUnidad = new MetroFramework.Controls.MetroComboBox();
            this.tBLUNIDADINTERNABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUnidadInterna = new Presentacion.DataSetUnidadInterna();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.tBL_UNIDADINTERNATableAdapter = new Presentacion.DataSetUnidadInternaTableAdapters.TBL_UNIDADINTERNATableAdapter();
            this.cboRol = new MetroFramework.Controls.MetroComboBox();
            this.tBLROLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRol = new Presentacion.DataSetRol();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tBL_ROLTableAdapter = new Presentacion.DataSetRolTableAdapters.TBL_ROLTableAdapter();
            this.dataSetUsuarios = new Presentacion.DataSetUsuarios();
            this.tBLUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_USUARIOTableAdapter = new Presentacion.DataSetUsuariosTableAdapters.TBL_USUARIOTableAdapter();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.dataSet5 = new Presentacion.DataSet5();
            this.tBLROLUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_ROLUSUARIOTableAdapter = new Presentacion.DataSet5TableAdapters.TBL_ROLUSUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUNIDADINTERNABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadInterna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLROLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLROLUSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 129);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(26, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "rut";
            // 
            // txtRut
            // 
            // 
            // 
            // 
            this.txtRut.CustomButton.Image = null;
            this.txtRut.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtRut.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtRut.CustomButton.Name = "";
            this.txtRut.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRut.CustomButton.TabIndex = 1;
            this.txtRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRut.CustomButton.UseSelectable = true;
            this.txtRut.CustomButton.Visible = false;
            this.txtRut.Lines = new string[0];
            this.txtRut.Location = new System.Drawing.Point(141, 121);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4);
            this.txtRut.MaxLength = 32767;
            this.txtRut.Name = "txtRut";
            this.txtRut.PasswordChar = '\0';
            this.txtRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRut.SelectedText = "";
            this.txtRut.SelectionLength = 0;
            this.txtRut.SelectionStart = 0;
            this.txtRut.ShortcutsEnabled = true;
            this.txtRut.Size = new System.Drawing.Size(219, 28);
            this.txtRut.TabIndex = 1;
            this.txtRut.UseSelectable = true;
            this.txtRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApPat
            // 
            // 
            // 
            // 
            this.txtApPat.CustomButton.Image = null;
            this.txtApPat.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtApPat.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtApPat.CustomButton.Name = "";
            this.txtApPat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtApPat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApPat.CustomButton.TabIndex = 1;
            this.txtApPat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApPat.CustomButton.UseSelectable = true;
            this.txtApPat.CustomButton.Visible = false;
            this.txtApPat.Lines = new string[0];
            this.txtApPat.Location = new System.Drawing.Point(141, 156);
            this.txtApPat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApPat.MaxLength = 32767;
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.PasswordChar = '\0';
            this.txtApPat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApPat.SelectedText = "";
            this.txtApPat.SelectionLength = 0;
            this.txtApPat.SelectionStart = 0;
            this.txtApPat.ShortcutsEnabled = true;
            this.txtApPat.Size = new System.Drawing.Size(219, 28);
            this.txtApPat.TabIndex = 3;
            this.txtApPat.UseSelectable = true;
            this.txtApPat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApPat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 164);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Apellido Paterno";
            // 
            // txtApMat
            // 
            // 
            // 
            // 
            this.txtApMat.CustomButton.Image = null;
            this.txtApMat.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtApMat.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtApMat.CustomButton.Name = "";
            this.txtApMat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtApMat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApMat.CustomButton.TabIndex = 1;
            this.txtApMat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApMat.CustomButton.UseSelectable = true;
            this.txtApMat.CustomButton.Visible = false;
            this.txtApMat.Lines = new string[0];
            this.txtApMat.Location = new System.Drawing.Point(141, 192);
            this.txtApMat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApMat.MaxLength = 32767;
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.PasswordChar = '\0';
            this.txtApMat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApMat.SelectedText = "";
            this.txtApMat.SelectionLength = 0;
            this.txtApMat.SelectionStart = 0;
            this.txtApMat.ShortcutsEnabled = true;
            this.txtApMat.Size = new System.Drawing.Size(219, 28);
            this.txtApMat.TabIndex = 5;
            this.txtApMat.UseSelectable = true;
            this.txtApMat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApMat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 200);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Apellido Materno";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtNombre.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(141, 231);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(219, 28);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 239);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 20);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Nombre";
            // 
            // txtTelPart
            // 
            // 
            // 
            // 
            this.txtTelPart.CustomButton.Image = null;
            this.txtTelPart.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtTelPart.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelPart.CustomButton.Name = "";
            this.txtTelPart.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTelPart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelPart.CustomButton.TabIndex = 1;
            this.txtTelPart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelPart.CustomButton.UseSelectable = true;
            this.txtTelPart.CustomButton.Visible = false;
            this.txtTelPart.Lines = new string[0];
            this.txtTelPart.Location = new System.Drawing.Point(141, 267);
            this.txtTelPart.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelPart.MaxLength = 32767;
            this.txtTelPart.Name = "txtTelPart";
            this.txtTelPart.PasswordChar = '\0';
            this.txtTelPart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelPart.SelectedText = "";
            this.txtTelPart.SelectionLength = 0;
            this.txtTelPart.SelectionStart = 0;
            this.txtTelPart.ShortcutsEnabled = true;
            this.txtTelPart.Size = new System.Drawing.Size(219, 28);
            this.txtTelPart.TabIndex = 9;
            this.txtTelPart.UseSelectable = true;
            this.txtTelPart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelPart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 275);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(129, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Telefono  Particular";
            // 
            // txtTelIns
            // 
            // 
            // 
            // 
            this.txtTelIns.CustomButton.Image = null;
            this.txtTelIns.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtTelIns.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelIns.CustomButton.Name = "";
            this.txtTelIns.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTelIns.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelIns.CustomButton.TabIndex = 1;
            this.txtTelIns.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelIns.CustomButton.UseSelectable = true;
            this.txtTelIns.CustomButton.Visible = false;
            this.txtTelIns.Lines = new string[0];
            this.txtTelIns.Location = new System.Drawing.Point(141, 303);
            this.txtTelIns.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelIns.MaxLength = 32767;
            this.txtTelIns.Name = "txtTelIns";
            this.txtTelIns.PasswordChar = '\0';
            this.txtTelIns.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelIns.SelectedText = "";
            this.txtTelIns.SelectionLength = 0;
            this.txtTelIns.SelectionStart = 0;
            this.txtTelIns.ShortcutsEnabled = true;
            this.txtTelIns.Size = new System.Drawing.Size(219, 28);
            this.txtTelIns.TabIndex = 11;
            this.txtTelIns.UseSelectable = true;
            this.txtTelIns.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelIns.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelIns.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 311);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(116, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Telefono Instituto";
            // 
            // txtDir
            // 
            // 
            // 
            // 
            this.txtDir.CustomButton.Image = null;
            this.txtDir.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtDir.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDir.CustomButton.Name = "";
            this.txtDir.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDir.CustomButton.TabIndex = 1;
            this.txtDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDir.CustomButton.UseSelectable = true;
            this.txtDir.CustomButton.Visible = false;
            this.txtDir.Lines = new string[0];
            this.txtDir.Location = new System.Drawing.Point(141, 346);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtDir.MaxLength = 32767;
            this.txtDir.Name = "txtDir";
            this.txtDir.PasswordChar = '\0';
            this.txtDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDir.SelectedText = "";
            this.txtDir.SelectionLength = 0;
            this.txtDir.SelectionStart = 0;
            this.txtDir.ShortcutsEnabled = true;
            this.txtDir.Size = new System.Drawing.Size(219, 28);
            this.txtDir.TabIndex = 13;
            this.txtDir.UseSelectable = true;
            this.txtDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDir.Click += new System.EventHandler(this.metroTextBox7_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 354);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 20);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Direccion";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 394);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(100, 20);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Unidad Interna";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(141, 422);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(219, 28);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Click += new System.EventHandler(this.metroTextBox9_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(16, 430);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(42, 20);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Email";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // txtCargo
            // 
            // 
            // 
            // 
            this.txtCargo.CustomButton.Image = null;
            this.txtCargo.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtCargo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.CustomButton.Name = "";
            this.txtCargo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCargo.CustomButton.TabIndex = 1;
            this.txtCargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCargo.CustomButton.UseSelectable = true;
            this.txtCargo.CustomButton.Visible = false;
            this.txtCargo.Lines = new string[0];
            this.txtCargo.Location = new System.Drawing.Point(141, 458);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.MaxLength = 32767;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PasswordChar = '\0';
            this.txtCargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCargo.SelectedText = "";
            this.txtCargo.SelectionLength = 0;
            this.txtCargo.SelectionStart = 0;
            this.txtCargo.ShortcutsEnabled = true;
            this.txtCargo.Size = new System.Drawing.Size(219, 28);
            this.txtCargo.TabIndex = 19;
            this.txtCargo.UseSelectable = true;
            this.txtCargo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCargo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCargo.Click += new System.EventHandler(this.metroTextBox10_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(12, 466);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 20);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Cargo";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.Coral;
            this.metroLabel11.Location = new System.Drawing.Point(489, 31);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(127, 20);
            this.metroLabel11.TabIndex = 22;
            this.metroLabel11.Text = "Seleccione Usuario";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.ItemHeight = 24;
            this.cboUsuario.Location = new System.Drawing.Point(449, 65);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(185, 30);
            this.cboUsuario.TabIndex = 21;
            this.cboUsuario.UseSelectable = true;
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // cboUnidad
            // 
            this.cboUnidad.DataSource = this.tBLUNIDADINTERNABindingSource;
            this.cboUnidad.DisplayMember = "DESC_UNIDAD_INTERNA";
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.ItemHeight = 24;
            this.cboUnidad.Location = new System.Drawing.Point(141, 384);
            this.cboUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(219, 30);
            this.cboUnidad.TabIndex = 23;
            this.cboUnidad.UseSelectable = true;
            this.cboUnidad.ValueMember = "ID_UNIDAD_INTERNA";
            // 
            // tBLUNIDADINTERNABindingSource
            // 
            this.tBLUNIDADINTERNABindingSource.DataMember = "TBL_UNIDADINTERNA";
            this.tBLUNIDADINTERNABindingSource.DataSource = this.dataSetUnidadInterna;
            // 
            // dataSetUnidadInterna
            // 
            this.dataSetUnidadInterna.DataSetName = "DataSetUnidadInterna";
            this.dataSetUnidadInterna.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(453, 533);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(195, 28);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tBL_UNIDADINTERNATableAdapter
            // 
            this.tBL_UNIDADINTERNATableAdapter.ClearBeforeFill = true;
            // 
            // cboRol
            // 
            this.cboRol.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLROLUSUARIOBindingSource, "ID_ROL", true));
            this.cboRol.DataSource = this.tBLROLBindingSource;
            this.cboRol.DisplayMember = "NOMBRE_ROL";
            this.cboRol.FormattingEnabled = true;
            this.cboRol.ItemHeight = 24;
            this.cboRol.Location = new System.Drawing.Point(141, 503);
            this.cboRol.Margin = new System.Windows.Forms.Padding(4);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(219, 30);
            this.cboRol.TabIndex = 26;
            this.cboRol.UseSelectable = true;
            this.cboRol.ValueMember = "ID_ROL";
            // 
            // tBLROLBindingSource
            // 
            this.tBLROLBindingSource.DataMember = "TBL_ROL";
            this.tBLROLBindingSource.DataSource = this.dataSetRol;
            // 
            // dataSetRol
            // 
            this.dataSetRol.DataSetName = "DataSetRol";
            this.dataSetRol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(12, 513);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(13, 20);
            this.metroLabel12.TabIndex = 25;
            this.metroLabel12.Text = " ";
            // 
            // tBL_ROLTableAdapter
            // 
            this.tBL_ROLTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetUsuarios
            // 
            this.dataSetUsuarios.DataSetName = "DataSetUsuarios";
            this.dataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLUSUARIOBindingSource
            // 
            this.tBLUSUARIOBindingSource.DataMember = "TBL_USUARIO";
            this.tBLUSUARIOBindingSource.DataSource = this.dataSetUsuarios;
            // 
            // tBL_USUARIOTableAdapter
            // 
            this.tBL_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 538);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 23);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLROLUSUARIOBindingSource
            // 
            this.tBLROLUSUARIOBindingSource.DataMember = "TBL_ROLUSUARIO";
            this.tBLROLUSUARIOBindingSource.DataSource = this.dataSet5;
            // 
            // tBL_ROLUSUARIOTableAdapter
            // 
            this.tBL_ROLUSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // MantenedorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 577);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboUnidad);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtTelIns);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtTelPart);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtApMat);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtApPat);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorUsuario";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "MantenedorUsuario";
            this.Load += new System.EventHandler(this.MantenedorUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLUNIDADINTERNABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadInterna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLROLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLROLUSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRut;
        private MetroFramework.Controls.MetroTextBox txtApPat;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtApMat;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTelPart;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtTelIns;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtDir;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtCargo;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cboUsuario;
        private MetroFramework.Controls.MetroComboBox cboUnidad;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private DataSetUnidadInterna dataSetUnidadInterna;
        private System.Windows.Forms.BindingSource tBLUNIDADINTERNABindingSource;
        private DataSetUnidadInternaTableAdapters.TBL_UNIDADINTERNATableAdapter tBL_UNIDADINTERNATableAdapter;
        private MetroFramework.Controls.MetroComboBox cboRol;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private DataSetRol dataSetRol;
        private System.Windows.Forms.BindingSource tBLROLBindingSource;
        private DataSetRolTableAdapters.TBL_ROLTableAdapter tBL_ROLTableAdapter;
        private DataSetUsuarios dataSetUsuarios;
        private System.Windows.Forms.BindingSource tBLUSUARIOBindingSource;
        private DataSetUsuariosTableAdapters.TBL_USUARIOTableAdapter tBL_USUARIOTableAdapter;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource tBLROLUSUARIOBindingSource;
        private DataSet5TableAdapters.TBL_ROLUSUARIOTableAdapter tBL_ROLUSUARIOTableAdapter;
    }
}