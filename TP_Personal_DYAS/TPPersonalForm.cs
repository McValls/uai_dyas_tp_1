using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Personal_DYAS
{
    public partial class TPPersonalForm : Form
    {
        public TPPersonalForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonaUserControl personaUserControl = new PersonaUserControl();
            personaUserControl.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(personaUserControl);
        }

        private void nacionalidadesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            NacionalidadUserControl nacionalidadUserControl = new NacionalidadUserControl();
            nacionalidadUserControl.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(nacionalidadUserControl);
        }

        private void profesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfesionUserControl profesionUserControl = new ProfesionUserControl();
            profesionUserControl.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(profesionUserControl);
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonaUserControl personaUserControl = new PersonaUserControl();
            personaUserControl.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(personaUserControl);
        }

        private void verResumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumenUserControl resumenUserControl = new ResumenUserControl();
            resumenUserControl.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(resumenUserControl);
        }
    }
}
