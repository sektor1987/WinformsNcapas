namespace Presentacion
{
    partial class frmMantenedorPermisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdPermisos = new MetroFramework.Controls.MetroGrid();
            this.iDPERMISODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECURSOLEGALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLPERMISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Presentacion.DataSet1();
            this.tBL_PERMISOTableAdapter = new Presentacion.DataSet1TableAdapters.TBL_PERMISOTableAdapter();
            this.grdUnidadInterna = new MetroFramework.Controls.MetroGrid();
            this.iDUNIDADINTERNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCUNIDADINTERNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLUNIDADINTERNABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Presentacion.DataSet2();
            this.tBL_UNIDADINTERNATableAdapter = new Presentacion.DataSet2TableAdapters.TBL_UNIDADINTERNATableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarPermiso = new MetroFramework.Controls.MetroButton();
            this.btnEliminarPermiso = new MetroFramework.Controls.MetroButton();
            this.btnActualizarPermiso = new MetroFramework.Controls.MetroButton();
            this.txtIdRecurso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDescUnidadInterna = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregarUnidadInterna = new MetroFramework.Controls.MetroButton();
            this.btnActualizarUnidadInterna = new MetroFramework.Controls.MetroButton();
            this.btnEliminarUnidadInterna = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidadInterna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUNIDADINTERNABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPermisos
            // 
            this.grdPermisos.AllowUserToOrderColumns = true;
            this.grdPermisos.AllowUserToResizeRows = false;
            this.grdPermisos.AutoGenerateColumns = false;
            this.grdPermisos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPERMISODataGridViewTextBoxColumn,
            this.rECURSOLEGALDataGridViewTextBoxColumn});
            this.grdPermisos.DataSource = this.tBLPERMISOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPermisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdPermisos.EnableHeadersVisualStyles = false;
            this.grdPermisos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPermisos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPermisos.Location = new System.Drawing.Point(14, 151);
            this.grdPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.grdPermisos.Name = "grdPermisos";
            this.grdPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPermisos.Size = new System.Drawing.Size(494, 188);
            this.grdPermisos.TabIndex = 8;
            this.grdPermisos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPermisos_CellValueChanged);
            this.grdPermisos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPermisos_RowEnter);
            // 
            // iDPERMISODataGridViewTextBoxColumn
            // 
            this.iDPERMISODataGridViewTextBoxColumn.DataPropertyName = "ID_PERMISO";
            this.iDPERMISODataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPERMISODataGridViewTextBoxColumn.Name = "iDPERMISODataGridViewTextBoxColumn";
            // 
            // rECURSOLEGALDataGridViewTextBoxColumn
            // 
            this.rECURSOLEGALDataGridViewTextBoxColumn.DataPropertyName = "RECURSO_LEGAL";
            this.rECURSOLEGALDataGridViewTextBoxColumn.HeaderText = "RECURSO LEGAL";
            this.rECURSOLEGALDataGridViewTextBoxColumn.Name = "rECURSOLEGALDataGridViewTextBoxColumn";
            // 
            // tBLPERMISOBindingSource
            // 
            this.tBLPERMISOBindingSource.DataMember = "TBL_PERMISO";
            this.tBLPERMISOBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_PERMISOTableAdapter
            // 
            this.tBL_PERMISOTableAdapter.ClearBeforeFill = true;
            // 
            // grdUnidadInterna
            // 
            this.grdUnidadInterna.AllowUserToOrderColumns = true;
            this.grdUnidadInterna.AllowUserToResizeRows = false;
            this.grdUnidadInterna.AutoGenerateColumns = false;
            this.grdUnidadInterna.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdUnidadInterna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUnidadInterna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdUnidadInterna.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUnidadInterna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdUnidadInterna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnidadInterna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUNIDADINTERNADataGridViewTextBoxColumn,
            this.dESCUNIDADINTERNADataGridViewTextBoxColumn});
            this.grdUnidadInterna.DataSource = this.tBLUNIDADINTERNABindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUnidadInterna.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdUnidadInterna.EnableHeadersVisualStyles = false;
            this.grdUnidadInterna.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdUnidadInterna.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdUnidadInterna.Location = new System.Drawing.Point(538, 151);
            this.grdUnidadInterna.Name = "grdUnidadInterna";
            this.grdUnidadInterna.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUnidadInterna.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdUnidadInterna.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdUnidadInterna.RowTemplate.Height = 24;
            this.grdUnidadInterna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUnidadInterna.Size = new System.Drawing.Size(441, 189);
            this.grdUnidadInterna.TabIndex = 9;
            // 
            // iDUNIDADINTERNADataGridViewTextBoxColumn
            // 
            this.iDUNIDADINTERNADataGridViewTextBoxColumn.DataPropertyName = "ID_UNIDAD_INTERNA";
            this.iDUNIDADINTERNADataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDUNIDADINTERNADataGridViewTextBoxColumn.Name = "iDUNIDADINTERNADataGridViewTextBoxColumn";
            // 
            // dESCUNIDADINTERNADataGridViewTextBoxColumn
            // 
            this.dESCUNIDADINTERNADataGridViewTextBoxColumn.DataPropertyName = "DESC_UNIDAD_INTERNA";
            this.dESCUNIDADINTERNADataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCUNIDADINTERNADataGridViewTextBoxColumn.Name = "dESCUNIDADINTERNADataGridViewTextBoxColumn";
            // 
            // tBLUNIDADINTERNABindingSource
            // 
            this.tBLUNIDADINTERNABindingSource.DataMember = "TBL_UNIDADINTERNA";
            this.tBLUNIDADINTERNABindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_UNIDADINTERNATableAdapter
            // 
            this.tBL_UNIDADINTERNATableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(144, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 20);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Permisos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(666, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 20);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Unidad Interna";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(273, 120);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPermiso.TabIndex = 14;
            this.btnAgregarPermiso.Text = "Agregar";
            this.btnAgregarPermiso.UseSelectable = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Location = new System.Drawing.Point(179, 345);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPermiso.TabIndex = 15;
            this.btnEliminarPermiso.Text = "Eliminar";
            this.btnEliminarPermiso.UseSelectable = true;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // btnActualizarPermiso
            // 
            this.btnActualizarPermiso.Location = new System.Drawing.Point(14, 345);
            this.btnActualizarPermiso.Name = "btnActualizarPermiso";
            this.btnActualizarPermiso.Size = new System.Drawing.Size(151, 23);
            this.btnActualizarPermiso.TabIndex = 16;
            this.btnActualizarPermiso.Text = "Actualizar Seleccionado";
            this.btnActualizarPermiso.UseSelectable = true;
            this.btnActualizarPermiso.Click += new System.EventHandler(this.btnActualizarPermiso_Click);
            // 
            // txtIdRecurso
            // 
            // 
            // 
            // 
            this.txtIdRecurso.CustomButton.Image = null;
            this.txtIdRecurso.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txtIdRecurso.CustomButton.Name = "";
            this.txtIdRecurso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdRecurso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdRecurso.CustomButton.TabIndex = 1;
            this.txtIdRecurso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdRecurso.CustomButton.UseSelectable = true;
            this.txtIdRecurso.CustomButton.Visible = false;
            this.txtIdRecurso.Lines = new string[0];
            this.txtIdRecurso.Location = new System.Drawing.Point(144, 120);
            this.txtIdRecurso.MaxLength = 32767;
            this.txtIdRecurso.Name = "txtIdRecurso";
            this.txtIdRecurso.PasswordChar = '\0';
            this.txtIdRecurso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdRecurso.SelectedText = "";
            this.txtIdRecurso.SelectionLength = 0;
            this.txtIdRecurso.SelectionStart = 0;
            this.txtIdRecurso.ShortcutsEnabled = true;
            this.txtIdRecurso.Size = new System.Drawing.Size(110, 23);
            this.txtIdRecurso.TabIndex = 21;
            this.txtIdRecurso.UseSelectable = true;
            this.txtIdRecurso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdRecurso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 20);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Recuros Legal";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(538, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 20);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Descripcion";
            // 
            // txtDescUnidadInterna
            // 
            // 
            // 
            // 
            this.txtDescUnidadInterna.CustomButton.Image = null;
            this.txtDescUnidadInterna.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txtDescUnidadInterna.CustomButton.Name = "";
            this.txtDescUnidadInterna.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescUnidadInterna.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescUnidadInterna.CustomButton.TabIndex = 1;
            this.txtDescUnidadInterna.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescUnidadInterna.CustomButton.UseSelectable = true;
            this.txtDescUnidadInterna.CustomButton.Visible = false;
            this.txtDescUnidadInterna.Lines = new string[0];
            this.txtDescUnidadInterna.Location = new System.Drawing.Point(666, 118);
            this.txtDescUnidadInterna.MaxLength = 32767;
            this.txtDescUnidadInterna.Name = "txtDescUnidadInterna";
            this.txtDescUnidadInterna.PasswordChar = '\0';
            this.txtDescUnidadInterna.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescUnidadInterna.SelectedText = "";
            this.txtDescUnidadInterna.SelectionLength = 0;
            this.txtDescUnidadInterna.SelectionStart = 0;
            this.txtDescUnidadInterna.ShortcutsEnabled = true;
            this.txtDescUnidadInterna.Size = new System.Drawing.Size(110, 23);
            this.txtDescUnidadInterna.TabIndex = 24;
            this.txtDescUnidadInterna.UseSelectable = true;
            this.txtDescUnidadInterna.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescUnidadInterna.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAgregarUnidadInterna
            // 
            this.btnAgregarUnidadInterna.Location = new System.Drawing.Point(795, 118);
            this.btnAgregarUnidadInterna.Name = "btnAgregarUnidadInterna";
            this.btnAgregarUnidadInterna.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUnidadInterna.TabIndex = 23;
            this.btnAgregarUnidadInterna.Text = "Agregar";
            this.btnAgregarUnidadInterna.UseSelectable = true;
            this.btnAgregarUnidadInterna.Click += new System.EventHandler(this.btnAgregarUnidadInterna_Click);
            // 
            // btnActualizarUnidadInterna
            // 
            this.btnActualizarUnidadInterna.Location = new System.Drawing.Point(538, 346);
            this.btnActualizarUnidadInterna.Name = "btnActualizarUnidadInterna";
            this.btnActualizarUnidadInterna.Size = new System.Drawing.Size(151, 23);
            this.btnActualizarUnidadInterna.TabIndex = 27;
            this.btnActualizarUnidadInterna.Text = "Actualizar Seleccionado";
            this.btnActualizarUnidadInterna.UseSelectable = true;
            this.btnActualizarUnidadInterna.Click += new System.EventHandler(this.btnActualizarUnidadInterna_Click);
            // 
            // btnEliminarUnidadInterna
            // 
            this.btnEliminarUnidadInterna.Location = new System.Drawing.Point(703, 346);
            this.btnEliminarUnidadInterna.Name = "btnEliminarUnidadInterna";
            this.btnEliminarUnidadInterna.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUnidadInterna.TabIndex = 26;
            this.btnEliminarUnidadInterna.Text = "Eliminar";
            this.btnEliminarUnidadInterna.UseSelectable = true;
            this.btnEliminarUnidadInterna.Click += new System.EventHandler(this.btnEliminarUnidadInterna_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(265, 396);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(501, 20);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Para actualizar un permiso de doble click al valor de la grilla y presione actuli" +
    "zar";
            // 
            // frmMantenedorPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 539);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnActualizarUnidadInterna);
            this.Controls.Add(this.btnEliminarUnidadInterna);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDescUnidadInterna);
            this.Controls.Add(this.btnAgregarUnidadInterna);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtIdRecurso);
            this.Controls.Add(this.btnActualizarPermiso);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Controls.Add(this.btnAgregarPermiso);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grdUnidadInterna);
            this.Controls.Add(this.grdPermisos);
            this.Name = "frmMantenedorPermisos";
            this.Text = "Mantenedor de permisos y unidades";
            this.Load += new System.EventHandler(this.MantenedorPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidadInterna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUNIDADINTERNABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdPermisos;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tBLPERMISOBindingSource;
        private DataSet1TableAdapters.TBL_PERMISOTableAdapter tBL_PERMISOTableAdapter;
        private MetroFramework.Controls.MetroGrid grdUnidadInterna;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tBLUNIDADINTERNABindingSource;
        private DataSet2TableAdapters.TBL_UNIDADINTERNATableAdapter tBL_UNIDADINTERNATableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPERMISODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECURSOLEGALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUNIDADINTERNADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCUNIDADINTERNADataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnAgregarPermiso;
        private MetroFramework.Controls.MetroButton btnEliminarPermiso;
        private MetroFramework.Controls.MetroButton btnActualizarPermiso;
        private MetroFramework.Controls.MetroTextBox txtIdRecurso;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDescUnidadInterna;
        private MetroFramework.Controls.MetroButton btnAgregarUnidadInterna;
        private MetroFramework.Controls.MetroButton btnActualizarUnidadInterna;
        private MetroFramework.Controls.MetroButton btnEliminarUnidadInterna;
        private MetroFramework.Controls.MetroLabel metroLabel5;

    }
}