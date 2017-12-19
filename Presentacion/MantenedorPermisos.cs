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
    public partial class frmMantenedorPermisos : MetroFramework.Forms.MetroForm
    {
        public frmMantenedorPermisos()
        {
            InitializeComponent();
        }

        private void MantenedorPermisos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.TBL_UNIDADINTERNA' Puede moverla o quitarla según sea necesario.
            this.tBL_UNIDADINTERNATableAdapter.Fill(this.dataSet2.TBL_UNIDADINTERNA);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.TBL_PERMISO' Puede moverla o quitarla según sea necesario.
            this.tBL_PERMISOTableAdapter.Fill(this.dataSet1.TBL_PERMISO);

        }

        private void grdPermisos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in grdPermisos.Rows)
                {
                    if (row.Selected)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        PermisoBLL permisosBL = new PermisoBLL();
                        int eliminar = permisosBL.eliminar(id);

                        if (eliminar == 1)
                        {
                            MessageBox.Show("Permiso Eliminado");
                            this.Hide();
                            frmMantenedorPermisos mp = new frmMantenedorPermisos();
                            mp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Permiso no eliminado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error: " + ex.ToString());
            }
    
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {

            if (txtIdRecurso.Text == "") {

                MessageBox.Show("Todos los valores son requeridos");
                return;
            
            }
            int idPermiso = Convert.ToInt32(1);
            string recursoLegal = txtIdRecurso.Text;

            PermisoBLL permisosBL = new PermisoBLL();
            int actualizar = permisosBL.agregar(idPermiso, recursoLegal);

            if (actualizar == 1)
            {
                MessageBox.Show("Permiso Agregado");
                this.Hide();
                frmMantenedorPermisos mp = new frmMantenedorPermisos();
                mp.Show();
            }
            else
            {
                MessageBox.Show("Permiso no Agregado");
            }
           
        }

        private void btnActualizarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdPermisos.Rows)
                {
                    if (row.Selected)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        string recursoLegal = row.Cells[1].Value.ToString();
                        PermisoBLL permisosBL = new PermisoBLL();
                        int actualizar = permisosBL.actualizar(id, recursoLegal);

                        if (actualizar == 1)
                        {
                            MessageBox.Show("Permiso Actualizado");
                            grdPermisos.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Permiso no Actualizado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error: " + ex.ToString());
            }
    
        }

        private void grdPermisos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnActualizarUnidadInterna_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdPermisos.Rows)
                {
                    if (row.Selected)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        string desc = row.Cells[1].Value.ToString();
                        UnidadInternaBLL unidad = new UnidadInternaBLL();
                        int actualizar = unidad.actualizar(id, desc);

                        if (actualizar == 1)
                        {
                            MessageBox.Show("Permiso Actualizado");
                            grdPermisos.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Permiso no Actualizado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error: " + ex.ToString());
            }
    
        }

        private void btnEliminarUnidadInterna_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdUnidadInterna.Rows)
                {
                    if (row.Selected)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        UnidadInternaBLL unidad = new UnidadInternaBLL();
                        int eliminar = unidad.eliminar(id);

                        if (eliminar == 1)
                        {
                            MessageBox.Show("Permiso Eliminado");
                            this.Hide();
                            frmMantenedorPermisos mp = new frmMantenedorPermisos();
                            mp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Permiso no eliminado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error: " + ex.ToString());
            }
    
        }

        private void btnAgregarUnidadInterna_Click(object sender, EventArgs e)
        {
            if (txtDescUnidadInterna.Text == "")
            {

                MessageBox.Show("Todos los valores son requeridos");
                return;

            }
            int idPermiso = Convert.ToInt32(1);
            string recursoLegal = txtDescUnidadInterna.Text;

            UnidadInternaBLL unidad = new UnidadInternaBLL();
            int agregar = unidad.agregar(idPermiso, recursoLegal);

            if (agregar == 1)
            {
                MessageBox.Show("Permiso Agregado");
                this.Hide();
                frmMantenedorPermisos mp = new frmMantenedorPermisos();
                mp.Show();
            }
            else
            {
                MessageBox.Show("Permiso no Agregado");
            }
           
        }

      
    }
}
