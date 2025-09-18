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

        private readonly List<Form> formsActivos = new List<Form>();

        public TPPersonalMainForm()
        {
            InitializeComponent();
        }

        private void TPPersonalMainForm_Load(object sender, EventArgs e)
        {
            crearForm(new PersonaForm());
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nacionalidadForm = formsActivos.FindLast(f => f is NacionalidadForm);
            if (nacionalidadForm == null)
            {
                nacionalidadForm = crearForm(new NacionalidadForm());
            }
            nacionalidadForm.Activate();
        }

        private void profesionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form profesionForm = formsActivos.FindLast(f => f is ProfesionForm);
            if (profesionForm == null)
            {
                profesionForm = crearForm(new ProfesionForm());
            }
            profesionForm.Activate();
        }

        private void verResumenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form resumenForm = formsActivos.FindLast(f => f is ResumenForm);
            if (resumenForm == null)
            {
                resumenForm = crearForm(new ResumenForm());
            }
            resumenForm.Activate();
        }

        private void personalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form personaForm = formsActivos.FindLast(f => f is PersonaForm);
            if (personaForm == null)
            {
                personaForm = crearForm(new PersonaForm());
            }
            personaForm.Activate();
        }

        private Form crearForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
            form.FormClosed += (s, ev) => formsActivos.Remove(form);
            formsActivos.Add(form);

            return form;
        }
    }
}
