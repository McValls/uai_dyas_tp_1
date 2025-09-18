using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TP_Personal_DYAS_BE;
using TP_Personal_DYAS_DAL;

namespace TP_Personal_DYAS_BLL
{
    public class NacionalidadBLL
    {
        public delegate void changeDelegate();
        public event changeDelegate OnChangeEvent;

        private readonly NacionalidadMapper mapper = new NacionalidadMapper();

        public List<Nacionalidad> GetNacionalidades()
        {
            return mapper.Listar();
        }

        public Nacionalidad NacionalidadConMasPersonas()
        {
            return mapper.NacionalidadConMasPersonas();
        }
        public Nacionalidad NacionalidadConMenosPersonas()
        {
            return mapper.NacionalidadConMenosPersonas();
        }

        public Dictionary<Nacionalidad, int> PersonasPorNacionalidad()
        {
            return mapper.PersonasPorNacionalidad();
        }

        public Dictionary<Nacionalidad, int> PromedioEdadPorNacionalidad()
        {
            return mapper.PromedioEdadPorNacionalidad();
        }

        public void CreateNacionalidad(Nacionalidad nacionalidad)
        {
            int affectedRows = mapper.Insertar(nacionalidad);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo crear la nacionalidad");
            }
            OnChangeEvent();
        }
        
        public void EliminarNacionalidad(Nacionalidad nacionalidad)
        {
            int affectedRows = mapper.Eliminar(nacionalidad.Id);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo eliminar la nacionalidad");
            }
            OnChangeEvent();
        }

        public void UpdateNacionalidad(Nacionalidad nacionalidad)
        {
            int affectedRows = mapper.Editar(nacionalidad);
            if (affectedRows == 0)
            {
                throw new Exception("No se pudo editar la nacionalidad");
            }
            OnChangeEvent();
        }
    }
}
