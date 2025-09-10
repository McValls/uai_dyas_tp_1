using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_DAL;

namespace TP_Personal_DYAS_BLL
{
    public class Nacionalidades
    {
        public delegate void changeDelegate();
        public event changeDelegate OnChangeEvent;

        private readonly NacionalidadMapper nacionalidadMapper = new NacionalidadMapper();

        public List<Nacionalidad> GetNacionalidades()
        {
            return nacionalidadMapper.Listar();
        }

        public Nacionalidad NacionalidadConMasPersonas()
        {
            return nacionalidadMapper.NacionalidadConMasPersonas();
        }
        public Nacionalidad NacionalidadConMenosPersonas()
        {
            return nacionalidadMapper.NacionalidadConMenosPersonas();
        }

        public Dictionary<Nacionalidad, int> PersonasPorNacionalidad()
        {
            return nacionalidadMapper.PersonasPorNacionalidad();
        }

        public Dictionary<Nacionalidad, int> PromedioEdadPorNacionalidad()
        {
            return nacionalidadMapper.PromedioEdadPorNacionalidad();
        }

        public void CreateNacionalidad(Nacionalidad nacionalidad)
        {
            int affectedRows = nacionalidadMapper.Insertar(nacionalidad);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo crear la nacionalidad");
            }
            OnChangeEvent();
        }
        
        public void EliminarNacionalidad(Nacionalidad nacionalidad)
        {
            int affectedRows = nacionalidadMapper.Eliminar(nacionalidad.Id);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo eliminar la nacionalidad");
            }
            OnChangeEvent();
        }

        public void UpdateNacionalidad(Nacionalidad nacionalidad)
        {
            int affectedRows = nacionalidadMapper.Editar(nacionalidad);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo editar la nacionalidad");
            }
            OnChangeEvent();
        }
    }
}
