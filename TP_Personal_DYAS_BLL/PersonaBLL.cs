using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_DAL;

namespace TP_Personal_DYAS_BLL
{
    public class PersonaBLL
    {
        public delegate void changeDelegate();
        public event changeDelegate OnChangeEvent;
        private readonly PersonaMapper mapper = new PersonaMapper();

        public List<Persona> GetPersonas()
        {
            return mapper.Listar();
        }

        public List<Persona> GetPersonas(int nroPersona)
        {
            return mapper.Buscar(nroPersona);
        }

        public int CantidadPersonas()
        {
            return mapper.CantidadPersonas();
        }

        public int PromedioEdad()
        {
            return mapper.PromedioEdad();
        }

        public int EdadMaxima()
        {
            return mapper.EdadMaxima();
        }

        public int EdadMinima()
        {
            return mapper.EdadMinima();
        }

        public void CreatePersona(Persona persona)
        {
            ValidarPersona(persona);
            mapper.IniciarTransaccion();
            try
            {
                int affectedRows = mapper.Insertar(persona);
                if (affectedRows == 0)
                {
                    throw new Exception("No se pudo crear la persona");
                }
                mapper.Commit();
                OnChangeEvent();
            }
            catch (Exception ex)
            {
                mapper.Rollback();
                throw ex;
            }

        }

        public void EliminarPersona(Persona persona)
        {
            mapper.IniciarTransaccion();
            try
            {
                int affectedRows = mapper.Eliminar(persona.NroPersona);
                if (affectedRows == 0)
                {
                    throw new Exception("No se pudo eliminar la persona");
                }
                mapper.Commit();
                OnChangeEvent();
            }
            catch (Exception ex)
            {
                mapper.Rollback();
                throw ex;
            }
        }

        public void UpdatePersona(Persona persona)
        {
            ValidarPersona(persona);
            mapper.IniciarTransaccion();
            try
            {
                int affectedRows = mapper.Editar(persona);
                if (affectedRows == 0)
                {
                    throw new Exception("No se pudo editar la persona");
                }
                mapper.Commit();
                OnChangeEvent();

            }
            catch (Exception ex)
            {
                mapper.Rollback();
                throw ex;
            }
        }

        private void ValidarPersona(Persona persona)
        {
            if (persona.FechaNacimiento.CompareTo(DateTime.Now) > 0)
            {
                throw new Exception("La fecha de nacimiento no puede ser en el futuro");
            }

        }

    }
}
