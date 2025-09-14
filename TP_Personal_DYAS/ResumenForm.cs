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
        PersonaBLL personaBLL = new PersonaBLL();
        NacionalidadBLL nacionalidadBLL = new NacionalidadBLL();
        ProfesionBLL profesionBLL = new ProfesionBLL();

        public ResumenForm()
        {
            InitializeComponent();
        }

        private void ResumenForm_Load(object sender, EventArgs e)
        {
            personasRegistradasTxt.Text = personaBLL.CantidadPersonas().ToString();
            promedioEdadesTxt.Text = personaBLL.PromedioEdad().ToString();
            edadMinimaTxt.Text = personaBLL.EdadMinima().ToString();
            edadMaximaTxt.Text = personaBLL.EdadMaxima().ToString();
            if (nacionalidadBLL.GetNacionalidades().Count > 0)
            {
                nacionalidadConMasPersonasTxt.Text = nacionalidadBLL.NacionalidadConMasPersonas().Descripcion;
                nacionalidadConMenosPersonasTxt.Text = nacionalidadBLL.NacionalidadConMenosPersonas().Descripcion;
            }

            Dictionary<Nacionalidad, int> personasPorNacionalidad = nacionalidadBLL.PersonasPorNacionalidad();
            Dictionary<Nacionalidad, int> promedioEdadPorNacionalidad = nacionalidadBLL.PromedioEdadPorNacionalidad();

            nacionalidadesDataGridView.DataSource = personasPorNacionalidad.Select((nacionalidadPersonas) =>
            {
                int promedioEdad = promedioEdadPorNacionalidad[nacionalidadPersonas.Key];
                return new NacionalidadesDataSource(nacionalidadPersonas.Key.Descripcion, nacionalidadPersonas.Value, promedioEdad);
            }).ToList();

            // Punto adicional:
            if (profesionBLL.GetProfesiones().Count > 0)
            {
                profesionConMasPersonasTxt.Text = profesionBLL.ProfesionConMasPersonas().Descripcion;
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
