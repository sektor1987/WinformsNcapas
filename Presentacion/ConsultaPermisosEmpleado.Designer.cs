namespace Presentacion
{
    partial class frmConsultaPermisosEmpleado
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtIdRecurso = new MetroFramework.Controls.MetroTextBox();
            this.grdPermisos = new MetroFramework.Controls.MetroGrid();
            this.rUTUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECURSOLEGALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASAUTORIZADOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMENTARIOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWCANTIDADPERMISOSUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permisosUsuariosDataSet = new Presentacion.PermisosUsuariosDataSet();
            this.vW_CANTIDAD_PERMISOS_USUARIOSTableAdapter = new Presentacion.PermisosUsuariosDataSetTableAdapters.VW_CANTIDAD_PERMISOS_USUARIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCANTIDADPERMISOSUSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosUsuariosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 20);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Recuros Legal";
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
            this.txtIdRecurso.Location = new System.Drawing.Point(154, 94);
            this.txtIdRecurso.MaxLength = 32767;
            this.txtIdRecurso.Name = "txtIdRecurso";
            this.txtIdRecurso.PasswordChar = '\0';
            this.txtIdRecurso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdRecurso.SelectedText = "";
            this.txtIdRecurso.SelectionLength = 0;
            this.txtIdRecurso.SelectionStart = 0;
            this.txtIdRecurso.ShortcutsEnabled = true;
            this.txtIdRecurso.Size = new System.Drawing.Size(110, 23);
            this.txtIdRecurso.TabIndex = 25;
            this.txtIdRecurso.UseSelectable = true;
            this.txtIdRecurso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdRecurso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.rUTUSUARIODataGridViewTextBoxColumn,
            this.nOMBREUSUARIODataGridViewTextBoxColumn,
            this.rECURSOLEGALDataGridViewTextBoxColumn,
            this.dIASAUTORIZADOSDataGridViewTextBoxColumn,
            this.cOMENTARIOSDataGridViewTextBoxColumn});
            this.grdPermisos.DataSource = this.vWCANTIDADPERMISOSUSUARIOSBindingSource;
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
            this.grdPermisos.Location = new System.Drawing.Point(24, 125);
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
            this.grdPermisos.Size = new System.Drawing.Size(666, 367);
            this.grdPermisos.TabIndex = 23;
            // 
            // rUTUSUARIODataGridViewTextBoxColumn
            // 
            this.rUTUSUARIODataGridViewTextBoxColumn.DataPropertyName = "RUT_USUARIO";
            this.rUTUSUARIODataGridViewTextBoxColumn.HeaderText = "RUT_USUARIO";
            this.rUTUSUARIODataGridViewTextBoxColumn.Name = "rUTUSUARIODataGridViewTextBoxColumn";
            // 
            // nOMBREUSUARIODataGridViewTextBoxColumn
            // 
            this.nOMBREUSUARIODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_USUARIO";
            this.nOMBREUSUARIODataGridViewTextBoxColumn.HeaderText = "NOMBRE_USUARIO";
            this.nOMBREUSUARIODataGridViewTextBoxColumn.Name = "nOMBREUSUARIODataGridViewTextBoxColumn";
            // 
            // rECURSOLEGALDataGridViewTextBoxColumn
            // 
            this.rECURSOLEGALDataGridViewTextBoxColumn.DataPropertyName = "RECURSO_LEGAL";
            this.rECURSOLEGALDataGridViewTextBoxColumn.HeaderText = "RECURSO_LEGAL";
            this.rECURSOLEGALDataGridViewTextBoxColumn.Name = "rECURSOLEGALDataGridViewTextBoxColumn";
            // 
            // dIASAUTORIZADOSDataGridViewTextBoxColumn
            // 
            this.dIASAUTORIZADOSDataGridViewTextBoxColumn.DataPropertyName = "DIAS_AUTORIZADOS";
            this.dIASAUTORIZADOSDataGridViewTextBoxColumn.HeaderText = "DIAS_AUTORIZADOS";
            this.dIASAUTORIZADOSDataGridViewTextBoxColumn.Name = "dIASAUTORIZADOSDataGridViewTextBoxColumn";
            // 
            // cOMENTARIOSDataGridViewTextBoxColumn
            // 
            this.cOMENTARIOSDataGridViewTextBoxColumn.DataPropertyName = "COMENTARIOS";
            this.cOMENTARIOSDataGridViewTextBoxColumn.HeaderText = "COMENTARIOS";
            this.cOMENTARIOSDataGridViewTextBoxColumn.Name = "cOMENTARIOSDataGridViewTextBoxColumn";
            // 
            // vWCANTIDADPERMISOSUSUARIOSBindingSource
            // 
            this.vWCANTIDADPERMISOSUSUARIOSBindingSource.DataMember = "VW_CANTIDAD_PERMISOS_USUARIOS";
            this.vWCANTIDADPERMISOSUSUARIOSBindingSource.DataSource = this.permisosUsuariosDataSet;
            // 
            // permisosUsuariosDataSet
            // 
            this.permisosUsuariosDataSet.DataSetName = "PermisosUsuariosDataSet";
            this.permisosUsuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_CANTIDAD_PERMISOS_USUARIOSTableAdapter
            // 
            this.vW_CANTIDAD_PERMISOS_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaPermisosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 551);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtIdRecurso);
            this.Controls.Add(this.grdPermisos);
            this.Name = "frmConsultaPermisosEmpleado";
            this.Text = "Permisos Usuario";
            this.Load += new System.EventHandler(this.ConsultaPermisosEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCANTIDADPERMISOSUSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosUsuariosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtIdRecurso;
        private MetroFramework.Controls.MetroGrid grdPermisos;
        private PermisosUsuariosDataSet permisosUsuariosDataSet;
        private System.Windows.Forms.BindingSource vWCANTIDADPERMISOSUSUARIOSBindingSource;
        private PermisosUsuariosDataSetTableAdapters.VW_CANTIDAD_PERMISOS_USUARIOSTableAdapter vW_CANTIDAD_PERMISOS_USUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUTUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECURSOLEGALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASAUTORIZADOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMENTARIOSDataGridViewTextBoxColumn;
    }
}