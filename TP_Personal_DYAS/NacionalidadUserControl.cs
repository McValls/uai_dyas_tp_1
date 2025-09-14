using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_BLL;

namespace TP_Personal_DYAS
{
    public partial class NacionalidadUserControl : UserControl
    {
        private NacionalidadBLL nacionalidades;

        public NacionalidadUserControl()
        {
            InitializeComponent();
            nacionalidades = new NacionalidadBLL();
            nacionalidades.OnChangeEvent += RefrescarTabla;

            RefrescarTabla();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = descripcionTxt.Text;
                if (descripcion.Trim().Length == 0)
                {
                    MessageBox.Show($"La descripción no puede estar vacía");
                    return;
                }
                Nacionalidad nacionalidad = new Nacionalidad(descripcion);
                nacionalidades.CreateNacionalidad(nacionalidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error creando la nacionalidad: {ex.Message}");
            }
        }
        public void RefrescarTabla()
        {
            NacionalidadDataSourceGrid.DataSource = nacionalidades.GetNacionalidades()
                .Select(nacionalidad => new NacionalidadDataSource(nacionalidad))
                .ToList();
        }

        private void NacionalidadDataSourceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NacionalidadDataSourceGrid.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                HandleDelete(e);
            }
            if (NacionalidadDataSourceGrid.Columns[e.ColumnIndex].HeaderText == "Editar")
            {
                HandleEdit(e);
            }
        }

        private void HandleDelete(DataGridViewCellEventArgs e)
        {
            try
            {
                NacionalidadDataSource nacionalidadDS = (NacionalidadDataSource)NacionalidadDataSourceGrid.Rows[e.RowIndex].DataBoundItem;
                Nacionalidad nacionalidad = new Nacionalidad(nacionalidadDS.Id);
                nacionalidades.EliminarNacionalidad(nacionalidad);
            } catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error intentando eliminar la nacionalidad: {ex.Message}");
            }
        }

        private void HandleEdit(DataGridViewCellEventArgs e)
        {
            try
            {
                NacionalidadDataSource nacionalidadDS = (NacionalidadDataSource)NacionalidadDataSourceGrid.Rows[e.RowIndex].DataBoundItem;
                Nacionalidad nacionalidad = new Nacionalidad(nacionalidadDS.Id, nacionalidadDS.Descripcion);
                if (nacionalidad.Descripcion.Trim().Length == 0)
                {
                    MessageBox.Show($"La descripción no puede estar vacía");
                    return;
                }

                nacionalidades.UpdateNacionalidad(nacionalidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error intentando actualizar la nacionalidad: {ex.Message}");
            }
        }

        class NacionalidadDataSource
        {
            private int id;
            private string descripcion;

            public NacionalidadDataSource(Nacionalidad nacionalidad)
            {
                this.id = nacionalidad.Id;
                this.descripcion = nacionalidad.Descripcion;
            }

            public int Id { get => id; set => id = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
        }

    }
}
