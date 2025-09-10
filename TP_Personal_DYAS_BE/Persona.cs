using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personal_DYAS_BE
{
    public class Persona
    {
        private int nroPersona;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private Sexo sexo;
        private int idNacionalidad;
        private int idProfesion;

        public Persona(int nroPersona)
        {
            this.NroPersona = nroPersona;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, Sexo sexo, int idNacionalidad, int idProfesion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.IdNacionalidad = idNacionalidad;
            this.IdProfesion = idProfesion;
        }

        public Persona(int nroPersona, string nombre, string apellido, DateTime fechaNacimiento, Sexo sexo, int idNacionalidad, int idProfesion)
        {
            this.NroPersona = nroPersona;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.IdNacionalidad = idNacionalidad;
            this.IdProfesion = idProfesion;
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
