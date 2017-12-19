namespace Presentacion
{
    partial class frmAutorizarPermisos
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
            this.grdUnidadInterna = new MetroFramework.Controls.MetroGrid();
            this.iDSOLICITUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINSOLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUTUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLSOLICITUDPERMISOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAutorizarPermisoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAutorizarPermiso = new Presentacion.DataSetAutorizarPermiso();
            this.tBLSOLICITUDPERMISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SOLICITUDPERMISOTableAdapter = new Presentacion.DataSetAutorizarPermisoTableAdapters.TBL_SOLICITUDPERMISOTableAdapter();
            this.tBLESTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_ESTADOTableAdapter = new Presentacion.DataSetAutorizarPermisoTableAdapters.TBL_ESTADOTableAdapter();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.cboEstado = new MetroFramework.Controls.MetroComboBox();
            this.tBLESTADOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEstados = new Presentacion.DataSetEstados();
            this.tBL_ESTADOTableAdapter1 = new Presentacion.DataSetEstadosTableAdapters.TBL_ESTADOTableAdapter();
            this.Responsable = new MetroFramework.Controls.MetroLabel();
            this.lblEstado = new MetroFramework.Controls.MetroLabel();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnVerPermiso = new MetroFramework.Controls.MetroButton();
            this.btnSituacionEmp = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidadInterna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSOLICITUDPERMISOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutorizarPermisoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutorizarPermiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSOLICITUDPERMISOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLESTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLESTADOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUnidadInterna
            // 
            this.grdUnidadInterna.AllowUserToAddRows = false;
            this.grdUnidadInterna.AllowUserToDeleteRows = false;
            this.grdUnidadInterna.AllowUserToOrderColumns = true;
            this.grdUnidadInterna.AllowUserToResizeRows = false;
            this.grdUnidadInterna.AutoGenerateColumns = false;
            this.grdUnidadInterna.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdUnidadInterna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUnidadInterna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdUnidadInterna.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUnidadInterna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUnidadInterna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnidadInterna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSOLICITUDDataGridViewTextBoxColumn,
            this.fECHAINICIODataGridViewTextBoxColumn,
            this.fECHAFINSOLDataGridViewTextBoxColumn,
            this.rUTUSUARIODataGridViewTextBoxColumn,
            this.mOTIVODataGridViewTextBoxColumn});
            this.grdUnidadInterna.DataSource = this.tBLSOLICITUDPERMISOBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUnidadInterna.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdUnidadInterna.EnableHeadersVisualStyles = false;
            this.grdUnidadInterna.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdUnidadInterna.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdUnidadInterna.Location = new System.Drawing.Point(37, 79);
            this.grdUnidadInterna.Name = "grdUnidadInterna";
            this.grdUnidadInterna.ReadOnly = true;
            this.grdUnidadInterna.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUnidadInterna.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdUnidadInterna.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdUnidadInterna.RowTemplate.Height = 24;
            this.grdUnidadInterna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUnidadInterna.Size = new System.Drawing.Size(884, 189);
            this.grdUnidadInterna.TabIndex = 10;
            this.grdUnidadInterna.SelectionChanged += new System.EventHandler(this.grdUnidadInterna_SelectionChanged);
            // 
            // iDSOLICITUDDataGridViewTextBoxColumn
            // 
            this.iDSOLICITUDDataGridViewTextBoxColumn.DataPropertyName = "ID_SOLICITUD";
            this.iDSOLICITUDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDSOLICITUDDataGridViewTextBoxColumn.Name = "iDSOLICITUDDataGridViewTextBoxColumn";
            this.iDSOLICITUDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAINICIODataGridViewTextBoxColumn
            // 
            this.fECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.HeaderText = "FECHA INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.Name = "fECHAINICIODataGridViewTextBoxColumn";
            this.fECHAINICIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAFINSOLDataGridViewTextBoxColumn
            // 
            this.fECHAFINSOLDataGridViewTextBoxColumn.DataPropertyName = "FECHA_FIN_SOL";
            this.fECHAFINSOLDataGridViewTextBoxColumn.HeaderText = "FECHA FIN";
            this.fECHAFINSOLDataGridViewTextBoxColumn.Name = "fECHAFINSOLDataGridViewTextBoxColumn";
            this.fECHAFINSOLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rUTUSUARIODataGridViewTextBoxColumn
            // 
            this.rUTUSUARIODataGridViewTextBoxColumn.DataPropertyName = "RUT_USUARIO";
            this.rUTUSUARIODataGridViewTextBoxColumn.HeaderText = "RUT ASOCIADO";
            this.rUTUSUARIODataGridViewTextBoxColumn.Name = "rUTUSUARIODataGridViewTextBoxColumn";
            this.rUTUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOTIVODataGridViewTextBoxColumn
            // 
            this.mOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.HeaderText = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.Name = "mOTIVODataGridViewTextBoxColumn";
            this.mOTIVODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBLSOLICITUDPERMISOBindingSource1
            // 
            this.tBLSOLICITUDPERMISOBindingSource1.DataMember = "TBL_SOLICITUDPERMISO";
            this.tBLSOLICITUDPERMISOBindingSource1.DataSource = this.dataSetAutorizarPermisoBindingSource;
            // 
            // dataSetAutorizarPermisoBindingSource
            // 
            this.dataSetAutorizarPermisoBindingSource.DataSource = this.dataSetAutorizarPermiso;
            this.dataSetAutorizarPermisoBindingSource.Position = 0;
            // 
            // dataSetAutorizarPermiso
            // 
            this.dataSetAutorizarPermiso.DataSetName = "DataSetAutorizarPermiso";
            this.dataSetAutorizarPermiso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSOLICITUDPERMISOBindingSource
            // 
            this.tBLSOLICITUDPERMISOBindingSource.DataMember = "TBL_SOLICITUDPERMISO";
            this.tBLSOLICITUDPERMISOBindingSource.DataSource = this.dataSetAutorizarPermisoBindingSource;
            // 
            // tBL_SOLICITUDPERMISOTableAdapter
            // 
            this.tBL_SOLICITUDPERMISOTableAdapter.ClearBeforeFill = true;
            // 
            // tBLESTADOBindingSource
            // 
            this.tBLESTADOBindingSource.DataMember = "TBL_ESTADO";
            this.tBLESTADOBindingSource.DataSource = this.dataSetAutorizarPermisoBindingSource;
            // 
            // tBL_ESTADOTableAdapter
            // 
            this.tBL_ESTADOTableAdapter.ClearBeforeFill = true;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Enabled = false;
            this.txtResponsable.Location = new System.Drawing.Point(121, 322);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(100, 22);
            this.txtResponsable.TabIndex = 11;
            this.txtResponsable.Visible = false;
            // 
            // cboEstado
            // 
            this.cboEstado.DataSource = this.tBLESTADOBindingSource1;
            this.cboEstado.DisplayMember = "DESC_ESTADO";
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 24;
            this.cboEstado.Location = new System.Drawing.Point(121, 361);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(155, 30);
            this.cboEstado.TabIndex = 22;
            this.cboEstado.UseSelectable = true;
            this.cboEstado.ValueMember = "ID_ESTADO_SOL";
            // 
            // tBLESTADOBindingSource1
            // 
            this.tBLESTADOBindingSource1.DataMember = "TBL_ESTADO";
            this.tBLESTADOBindingSource1.DataSource = this.dataSetEstados;
            // 
            // dataSetEstados
            // 
            this.dataSetEstados.DataSetName = "DataSetEstados";
            this.dataSetEstados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_ESTADOTableAdapter1
            // 
            this.tBL_ESTADOTableAdapter1.ClearBeforeFill = true;
            // 
            // Responsable
            // 
            this.Responsable.AutoSize = true;
            this.Responsable.Location = new System.Drawing.Point(9, 322);
            this.Responsable.Name = "Responsable";
            this.Responsable.Size = new System.Drawing.Size(87, 20);
            this.Responsable.TabIndex = 23;
            this.Responsable.Text = "Responsable";
            this.Responsable.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(9, 371);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 20);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(501, 370);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVerPermiso
            // 
            this.btnVerPermiso.Location = new System.Drawing.Point(316, 371);
            this.btnVerPermiso.Name = "btnVerPermiso";
            this.btnVerPermiso.Size = new System.Drawing.Size(179, 23);
            this.btnVerPermiso.TabIndex = 26;
            this.btnVerPermiso.Text = "Guardar Comprobante PDF";
            this.btnVerPermiso.UseSelectable = true;
            this.btnVerPermiso.Click += new System.EventHandler(this.btnVerPermiso_Click);
            // 
            // btnSituacionEmp
            // 
            this.btnSituacionEmp.Location = new System.Drawing.Point(582, 368);
            this.btnSituacionEmp.Name = "btnSituacionEmp";
            this.btnSituacionEmp.Size = new System.Drawing.Size(179, 23);
            this.btnSituacionEmp.TabIndex = 27;
            this.btnSituacionEmp.Text = "Verificar Situacion Empleado";
            this.btnSituacionEmp.UseSelectable = true;
            this.btnSituacionEmp.Click += new System.EventHandler(this.btnSituacionEmp_Click);
            // 
            // frmAutorizarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 399);
            this.Controls.Add(this.btnSituacionEmp);
            this.Controls.Add(this.btnVerPermiso);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.Responsable);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.grdUnidadInterna);
            this.Name = "frmAutorizarPermisos";
            this.Text = "Permisos Funcionarios";
            this.Load += new System.EventHandler(this.AutorizarPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidadInterna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSOLICITUDPERMISOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutorizarPermisoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutorizarPermiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSOLICITUDPERMISOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLESTADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLESTADOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdUnidadInterna;
        private System.Windows.Forms.BindingSource dataSetAutorizarPermisoBindingSource;
        private DataSetAutorizarPermiso dataSetAutorizarPermiso;
        private System.Windows.Forms.BindingSource tBLSOLICITUDPERMISOBindingSource;
        private DataSetAutorizarPermisoTableAdapters.TBL_SOLICITUDPERMISOTableAdapter tBL_SOLICITUDPERMISOTableAdapter;
        private System.Windows.Forms.BindingSource tBLESTADOBindingSource;
        private DataSetAutorizarPermisoTableAdapters.TBL_ESTADOTableAdapter tBL_ESTADOTableAdapter;
        private System.Windows.Forms.BindingSource tBLSOLICITUDPERMISOBindingSource1;
        private System.Windows.Forms.TextBox txtResponsable;
        private MetroFramework.Controls.MetroComboBox cboEstado;
        private DataSetEstados dataSetEstados;
        private System.Windows.Forms.BindingSource tBLESTADOBindingSource1;
        private DataSetEstadosTableAdapters.TBL_ESTADOTableAdapter tBL_ESTADOTableAdapter1;
        private MetroFramework.Controls.MetroLabel Responsable;
        private MetroFramework.Controls.MetroLabel lblEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSOLICITUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINSOLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUTUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnVerPermiso;
        private MetroFramework.Controls.MetroButton btnSituacionEmp;

    }
}