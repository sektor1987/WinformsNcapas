namespace Presentacion
{
    partial class GeneradorPermiso
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
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.cbMotivoPermiso = new MetroFramework.Controls.MetroComboBox();
            this.tBLPERMISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPermiso = new Presentacion.DSPermiso();
            this.tBLPERMISOUSUARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new Presentacion.DataSet3();
            this.tBLPERMISOUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCodigoMotivoPermiso = new Presentacion.dataSetCodigoMotivoPermiso();
            this.tBL_PERMISOUSUARIOTableAdapter = new Presentacion.dataSetCodigoMotivoPermisoTableAdapters.TBL_PERMISOUSUARIOTableAdapter();
            this.tBL_PERMISOUSUARIOTableAdapter1 = new Presentacion.DataSet3TableAdapters.TBL_PERMISOUSUARIOTableAdapter();
            this.tBL_PERMISOTableAdapter = new Presentacion.DSPermisoTableAdapters.TBL_PERMISOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPermiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOUSUARIOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodigoMotivoPermiso)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(211, 112);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(356, 22);
            this.dtInicio.TabIndex = 0;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(211, 163);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(356, 22);
            this.dtFin.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Fecha Inicio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fecha Inicio";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Motivo Permiso";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(23, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(472, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbMotivoPermiso
            // 
            this.cbMotivoPermiso.DataSource = this.tBLPERMISOBindingSource;
            this.cbMotivoPermiso.DisplayMember = "RECURSO_LEGAL";
            this.cbMotivoPermiso.FormattingEnabled = true;
            this.cbMotivoPermiso.ItemHeight = 24;
            this.cbMotivoPermiso.Location = new System.Drawing.Point(211, 206);
            this.cbMotivoPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.cbMotivoPermiso.Name = "cbMotivoPermiso";
            this.cbMotivoPermiso.Size = new System.Drawing.Size(356, 30);
            this.cbMotivoPermiso.TabIndex = 8;
            this.cbMotivoPermiso.UseSelectable = true;
            this.cbMotivoPermiso.ValueMember = "ID_SOLICITUD";
            this.cbMotivoPermiso.SelectedIndexChanged += new System.EventHandler(this.cbMotivoPermiso_SelectedIndexChanged);
            // 
            // tBLPERMISOBindingSource
            // 
            this.tBLPERMISOBindingSource.DataMember = "TBL_PERMISO";
            this.tBLPERMISOBindingSource.DataSource = this.dSPermiso;
            // 
            // dSPermiso
            // 
            this.dSPermiso.DataSetName = "DSPermiso";
            this.dSPermiso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPERMISOUSUARIOBindingSource1
            // 
            this.tBLPERMISOUSUARIOBindingSource1.DataMember = "TBL_PERMISOUSUARIO";
            this.tBLPERMISOUSUARIOBindingSource1.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPERMISOUSUARIOBindingSource
            // 
            this.tBLPERMISOUSUARIOBindingSource.DataMember = "TBL_PERMISOUSUARIO";
            this.tBLPERMISOUSUARIOBindingSource.DataSource = this.dataSetCodigoMotivoPermiso;
            // 
            // dataSetCodigoMotivoPermiso
            // 
            this.dataSetCodigoMotivoPermiso.DataSetName = "dataSetCodigoMotivoPermiso";
            this.dataSetCodigoMotivoPermiso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_PERMISOUSUARIOTableAdapter
            // 
            this.tBL_PERMISOUSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_PERMISOUSUARIOTableAdapter1
            // 
            this.tBL_PERMISOUSUARIOTableAdapter1.ClearBeforeFill = true;
            // 
            // tBL_PERMISOTableAdapter
            // 
            this.tBL_PERMISOTableAdapter.ClearBeforeFill = true;
            // 
            // GeneradorPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 383);
            this.Controls.Add(this.cbMotivoPermiso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Name = "GeneradorPermiso";
            this.Text = "Generar Permiso";
            this.Load += new System.EventHandler(this.GeneradorPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPermiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOUSUARIOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERMISOUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCodigoMotivoPermiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroComboBox cbMotivoPermiso;
        private dataSetCodigoMotivoPermiso dataSetCodigoMotivoPermiso;
        private System.Windows.Forms.BindingSource tBLPERMISOUSUARIOBindingSource;
        private dataSetCodigoMotivoPermisoTableAdapters.TBL_PERMISOUSUARIOTableAdapter tBL_PERMISOUSUARIOTableAdapter;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource tBLPERMISOUSUARIOBindingSource1;
        private DataSet3TableAdapters.TBL_PERMISOUSUARIOTableAdapter tBL_PERMISOUSUARIOTableAdapter1;
        private DSPermiso dSPermiso;
        private System.Windows.Forms.BindingSource tBLPERMISOBindingSource;
        private DSPermisoTableAdapters.TBL_PERMISOTableAdapter tBL_PERMISOTableAdapter;
    }
}