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
    public partial class PersonaUserControl : UserControl
    {

        public Personas personas = new Personas();
        public Profesiones profesiones = new Profesiones();
        public Nacionalidades nacionalidades = new Nacionalidades();


        public PersonaUserControl()
        {
            InitializeComponent();
            sexoCombo.DataSource = Enum.GetValues(typeof(Sexo));
            Sexo.DataSource = Enum.GetValues(typeof(Sexo));
            List<Profesion> profesionesList = profesiones.GetProfesiones();
            if (profesionesList.Count == 0)
            {
                MessageBox.Show("Antes de comenzar, es necesario que crees al menos 1 profesión");
                this.Enabled = false;
            }

            profesionCombo.DataSource = profesionesList;
            profesionCombo.DisplayMember = "descripcion";
            Profesion.DataSource = profesionesList;
            Profesion.DisplayMember = "descripcion";
            Profesion.ValueMember = "id";

            List<Nacionalidad> nacionalidadesList = nacionalidades.GetNacionalidades();
            if (nacionalidadesList.Count == 0)
            {

                MessageBox.Show("Antes de comenzar, es necesario que crees al menos 1 nacionalidad");
                this.Enabled = false;
            }
            nacionalidadCombo.DataSource = nacionalidadesList;
            nacionalidadCombo.DisplayMember = "descripcion";
            Nacionalidad.DataSource = nacionalidadesList;
            Nacionalidad.DisplayMember = "descripcion";
            Nacionalidad.ValueMember = "id";

            personas.OnChangeEvent += RefrescarTabla;

            RefrescarTabla();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre = nombreTxt.Text;
                string apellido = apellidoTxt.Text;
                DateTime fechaNacimiento = DateTime.Parse(fechaNacimientoTxt.Text);
                Sexo sexo = (Sexo)sexoCombo.SelectedItem;
                int idProfesion = ((Profesion)profesionCombo.SelectedItem).Id;
                int idNacionalidad = ((Nacionalidad)nacionalidadCombo.SelectedItem).Id;

                if (nombre.Trim().Length == 0)
                {
                    MessageBox.Show($"El nombre no puede estar vacío");
                    return;
                }

                if (apellido.Trim().Length == 0)
                {
                    MessageBox.Show($"El apellido no puede estar vacío");
                    return;
                }

                if (fechaNacimiento == null)
                {
                    MessageBox.Show($"La fecha de nacimiento no puede estar vacía");
                    return;
                }

                if (idProfesion == 0)
                {
                    MessageBox.Show($"La profesión es obligatoria. Si aún no cargaste ninguna, dirigite a Configuraciones -> Profesiones");
                    return;
                }
            
                if (idNacionalidad == 0)
                {
                    MessageBox.Show($"La nacionalidad es obligatoria. Si aún no cargaste ninguna, dirigite a Configuraciones -> Nacionalidades");
                    return;
                }

                Persona persona = new Persona(nombre, apellido, fechaNacimiento, sexo, idNacionalidad, idProfesion);
                personas.CreatePersona(persona);
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al crear la persona: {ex.Message}");
            }
        }

        public void RefrescarTabla()
        {
            personasDataGridView.AutoGenerateColumns = false;
            personasDataGridView.DataSource = personas.GetPersonas()
                .Select(persona => new PersonaDataSource(persona))
                .ToList();
        }

        public void RefrescarTabla(int nroPersona)
        {
            personasDataGridView.DataSource = personas.GetPersonas(nroPersona)
                .Select(persona => new PersonaDataSource(persona))
                .ToList();
        }

        private void personasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (personasDataGridView.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                HandleDelete(e);
            }
            if (personasDataGridView.Columns[e.ColumnIndex].HeaderText == "Editar")
            {
                HandleEdit(e);
            }
        }

        private void HandleDelete(DataGridViewCellEventArgs e)
        {
            try
            {
                PersonaDataSource personaDataSource = (PersonaDataSource)personasDataGridView.Rows[e.RowIndex].DataBoundItem;
                Persona persona = new Persona(personaDataSource.NroPersona);
                personas.EliminarPersona(persona);
            } catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al eliminar la persona: {ex.Message}");
            }
        }

        private void HandleEdit(DataGridViewCellEventArgs e)
        {
            try
            {
                PersonaDataSource personaDataSource = (PersonaDataSource)personasDataGridView.Rows[e.RowIndex].DataBoundItem;
                int nroPersona = personaDataSource.NroPersona;
                string nombre = personaDataSource.Nombre;
                string apellido = personaDataSource.Apellido;
                DateTime fechaNacimiento = personaDataSource.FechaNacimiento;
                Sexo sexo = personaDataSource.Sexo;
                int idProfesion = personaDataSource.IdProfesion;
                int idNacionalidad = personaDataSource.IdNacionalidad;

                if (nombre.Trim().Length == 0)
                {
                    MessageBox.Show($"El nombre no puede estar vacío");
                    return;
                }

                if (apellido.Trim().Length == 0)
                {
                    MessageBox.Show($"El apellido no puede estar vacío");
                    return;
                }

                if (fechaNacimiento == null)
                {
                    MessageBox.Show($"La fecha de nacimiento no puede estar vacía");
                    return;
                }

                if (idProfesion == 0)
                {
                    MessageBox.Show($"La profesión es obligatoria. Si aún no cargaste ninguna, dirigite a Configuraciones -> Profesiones");
                    return;
                }

                if (idNacionalidad == 0)
                {
                    MessageBox.Show($"La nacionalidad es obligatoria. Si aún no cargaste ninguna, dirigite a Configuraciones -> Nacionalidades");
                    return;
                }

                Persona persona = new Persona(nroPersona, nombre, apellido, fechaNacimiento, sexo, idNacionalidad, idProfesion);
                personas.UpdatePersona(persona);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al actualizar la persona: {ex.Message}");
            }
        }
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string nroPersonaText = nroPersonaFiltroTxt.Text;
            if (nroPersonaText.Trim().Length == 0 || !int.TryParse(nroPersonaText, out _)) {
                RefrescarTabla();
            } else
            {
                int nroPersona = int.Parse(nroPersonaText);
                RefrescarTabla(nroPersona);
            }
        }

        private class PersonaDataSource
        {
            private int nroPersona;
            private string nombre;
            private string apellido;
            private DateTime fechaNacimiento;
            private Sexo sexo;
            private int idNacionalidad;
            private int idProfesion;

            public PersonaDataSource(Persona persona)
            {
                nroPersona = persona.NroPersona;
                nombre = persona.Nombre;
                apellido = persona.Apellido;
                fechaNacimiento = persona.FechaNacimiento;
                sexo = persona.Sexo;
                idNacionalidad = persona.IdNacionalidad;
                idProfesion = persona.IdProfesion;
            }

            public int NroPersona { get => nroPersona; set => nroPersona = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
            public Sexo Sexo { get => sexo; set => sexo = value; }
            public int IdNacionalidad { get => idNacionalidad; set => idNacionalidad = value; }
            public int IdProfesion { get => idProfesion; set => idProfesion = value; }
        }

    }
}
