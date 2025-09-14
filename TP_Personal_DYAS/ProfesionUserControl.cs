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
    public partial class ProfesionUserControl : UserControl
    {
        ProfesionBLL profesiones;

        public ProfesionUserControl()
        {
            InitializeComponent();
            profesiones = new ProfesionBLL();

            profesiones.OnChangeEvent += RefrescarTabla;
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
                Profesion profesion = new Profesion(descripcion);
                profesiones.CreateProfesion(profesion);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error creando la profesion: {ex.Message}");
            }
        }
        public void RefrescarTabla()
        {
            ProfesionDataSourceGrid.DataSource = profesiones.GetProfesiones()
                .Select(profesion => new ProfesionDataSource(profesion))
                .ToList();
        }
        private void ProfesionDataSourceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProfesionDataSourceGrid.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                HandleDelete(e);   
            }
            if (ProfesionDataSourceGrid.Columns[e.ColumnIndex].HeaderText == "Editar")
            {
                HandleEdit(e);
            }
        }

        private void HandleDelete(DataGridViewCellEventArgs e)
        {
            try
            {
                ProfesionDataSource profesionDS = (ProfesionDataSource)ProfesionDataSourceGrid.Rows[e.RowIndex].DataBoundItem;
                Profesion profesion = new Profesion(profesionDS.Id);
                profesiones.EliminarProfesion(profesion);
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error intentando eliminar la profesión: {ex.Message}");
            }
        }

        private void HandleEdit(DataGridViewCellEventArgs e)
        {
            try
            {
                ProfesionDataSource profesionDS = (ProfesionDataSource)ProfesionDataSourceGrid.Rows[e.RowIndex].DataBoundItem;
                Profesion profesion = new Profesion(profesionDS.Id, profesionDS.Descripcion);
                if (profesion.Descripcion.Trim().Length == 0)
                {
                    MessageBox.Show($"La descripción no puede estar vacía");
                    return;
                }
                profesiones.UpdateProfesion(profesion);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error intentando actualizar la profesión: {ex.Message}");
            }
        }

        class ProfesionDataSource
        {
            private int id;
            private string descripcion;

            public ProfesionDataSource(Profesion profesion)
            {
                this.id = profesion.Id;
                this.descripcion = profesion.Descripcion;
            }

            public int Id { get => id; set => id = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
        }

    }
}
