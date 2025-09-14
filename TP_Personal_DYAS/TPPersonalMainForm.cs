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
    public partial class TPPersonalMainForm : Form
    {
        public TPPersonalMainForm()
        {
            InitializeComponent();
        }

        private void TPPersonalMainForm_Load(object sender, EventArgs e)
        {
            PersonaForm personaForm = new PersonaForm();
            personaForm.MdiParent = this;
            personaForm.Show();
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NacionalidadForm nacionalidadForm = new NacionalidadForm();
            nacionalidadForm.MdiParent = this;
            nacionalidadForm.Show();
        }

        private void profesionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
            ProfesionForm profesionForm = new ProfesionForm();
            profesionForm.MdiParent = this;
            profesionForm.Show();
        }

        private void verResumenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResumenForm resumenForm = new ResumenForm();
            resumenForm.MdiParent = this;
            resumenForm.Show();
        }

        private void personalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PersonaForm personaForm = new PersonaForm();
            personaForm.MdiParent = this;
            personaForm.Show();
        }
    }
}
