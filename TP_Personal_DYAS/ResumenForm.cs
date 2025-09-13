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
    public partial class ResumenForm : Form
    {
        Personas personas = new Personas();
        Nacionalidades nacionalidades = new Nacionalidades();
        Profesiones profesiones = new Profesiones();

        public ResumenForm()
        {
            InitializeComponent();
        }

        private void ResumenForm_Load(object sender, EventArgs e)
        {
            personasRegistradasTxt.Text = personas.CantidadPersonas().ToString();
            promedioEdadesTxt.Text = personas.PromedioEdad().ToString();
            edadMinimaTxt.Text = personas.EdadMinima().ToString();
            edadMaximaTxt.Text = personas.EdadMaxima().ToString();
            if (nacionalidades.GetNacionalidades().Count > 0)
            {
                nacionalidadConMasPersonasTxt.Text = nacionalidades.NacionalidadConMasPersonas().Descripcion;
                nacionalidadConMenosPersonasTxt.Text = nacionalidades.NacionalidadConMenosPersonas().Descripcion;
            }

            Dictionary<Nacionalidad, int> personasPorNacionalidad = nacionalidades.PersonasPorNacionalidad();
            Dictionary<Nacionalidad, int> promedioEdadPorNacionalidad = nacionalidades.PromedioEdadPorNacionalidad();

            nacionalidadesDataGridView.DataSource = personasPorNacionalidad.Select((nacionalidadPersonas) =>
            {
                int promedioEdad = promedioEdadPorNacionalidad[nacionalidadPersonas.Key];
                return new NacionalidadesDataSource(nacionalidadPersonas.Key.Descripcion, nacionalidadPersonas.Value, promedioEdad);
            }).ToList();

            // Punto adicional:
            if (profesiones.GetProfesiones().Count > 0)
            {
                profesionConMasPersonasTxt.Text = profesiones.ProfesionConMasPersonas().Descripcion;
            }
        }

        private class NacionalidadesDataSource
        {
            private string nacionalidad;
            private int personasRegistradas;
            private int promedioEdad;

            public NacionalidadesDataSource(string nacionalidad, int personasRegistradas, int promedioEdad)
            {
                this.nacionalidad = nacionalidad;
                this.personasRegistradas = personasRegistradas;
                this.promedioEdad = promedioEdad;
            }

            public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
            public int PersonasRegistradas { get => personasRegistradas; set => personasRegistradas = value; }
            public int PromedioEdad { get => promedioEdad; set => promedioEdad = value; }
        }
    }
}
