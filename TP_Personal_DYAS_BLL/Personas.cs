using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_DAL;

namespace TP_Personal_DYAS_BLL
{
    public class Personas
    {
        public delegate void changeDelegate();
        public event changeDelegate OnChangeEvent;
        private readonly PersonaMapper personaMapper = new PersonaMapper();

        public List<Persona> GetPersonas()
        {
            return personaMapper.Listar();
        }

        public List<Persona> GetPersonas(int nroPersona)
        {
            return personaMapper.Buscar(nroPersona);
        }

        public int CantidadPersonas()
        {
            return personaMapper.CantidadPersonas();
        }

        public int PromedioEdad()
        {
            return personaMapper.PromedioEdad();
        }

        public int EdadMaxima()
        {
            return personaMapper.EdadMaxima();
        }

        public int EdadMinima()
        {
            return personaMapper.EdadMinima();
        }

        public void CreatePersona(Persona persona)
        {
            int affectedRows = personaMapper.Insertar(persona);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo crear la persona");
            }
            OnChangeEvent();
        }

        public void EliminarPersona(Persona persona)
        {
            int affectedRows = personaMapper.Eliminar(persona.NroPersona);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo eliminar la persona");
            }
            OnChangeEvent();
        }

        public void UpdatePersona(Persona persona)
        {
            int affectedRows = personaMapper.Editar(persona);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo editar la persona");
            }
            OnChangeEvent();
        }

    }
}
