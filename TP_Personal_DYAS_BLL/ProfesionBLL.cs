using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_DAL;

namespace TP_Personal_DYAS_BLL
{
    public class ProfesionBLL
    {
        public delegate void changeDelegate();
        public event changeDelegate OnChangeEvent;

        private readonly ProfesionMapper mapper = new ProfesionMapper();

        public List<Profesion> GetProfesiones()
        {
            return mapper.Listar();
        }

        public Profesion ProfesionConMasPersonas()
        {
            return mapper.ProfesionConMasPersonas();
        }

        public void CreateProfesion(Profesion profesion)
        {
            int affectedRows = mapper.Insertar(profesion);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo crear la profesion");
            }
            OnChangeEvent();
        }

        public void EliminarProfesion(Profesion profesion)
        {
            int affectedRows = mapper.Eliminar(profesion.Id);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo eliminar la profesion");
            }
            OnChangeEvent();
        }

        public void UpdateProfesion(Profesion profesion)
        {
            int affectedRows = mapper.Editar(profesion);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo editar la profesion");
            }
            OnChangeEvent();
        }
    }
}
