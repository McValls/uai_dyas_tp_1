using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_DAL;

namespace TP_Personal_DYAS_BLL
{
    public class Profesiones
    {
        public delegate void changeDelegate();
        public event changeDelegate OnChangeEvent;

        private readonly ProfesionMapper profesionMapper = new ProfesionMapper();

        public List<Profesion> GetProfesiones()
        {
            return profesionMapper.Listar();
        }

        public Profesion ProfesionConMasPersonas()
        {
            return profesionMapper.ProfesionConMasPersonas();
        }

        public void CreateProfesion(Profesion profesion)
        {
            int affectedRows = profesionMapper.Insertar(profesion);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo crear la profesion");
            }
            OnChangeEvent();
        }

        public void EliminarProfesion(Profesion profesion)
        {
            int affectedRows = profesionMapper.Eliminar(profesion.Id);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo eliminar la profesion");
            }
            OnChangeEvent();
        }

        public void UpdateProfesion(Profesion profesion)
        {
            int affectedRows = profesionMapper.Editar(profesion);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo editar la profesion");
            }
            OnChangeEvent();
        }
    }
}
