using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Personal_DYAS_BE;

namespace TP_Personal_DYAS_DAL
{
    public class NacionalidadMapper : Mapper<Nacionalidad, int>
    {
        public NacionalidadMapper() : base(
            "id", 
            "GetNacionalidades", 
            "CreateNacionalidad", 
            "UpdateNacionalidad", 
            "DeleteNacionalidad")
        {
        }

        public Nacionalidad NacionalidadConMasPersonas()
        {
            DataTable dataTable = acceso.Leer("NacionalidadMasPersonas");
            foreach(DataRow row in dataTable.Rows)
            {
                return ParseRow(row);
            }
            return null;
        }

        public Nacionalidad NacionalidadConMenosPersonas()
        {
            DataTable dataTable = acceso.Leer("NacionalidadMenosPersonas");
            foreach (DataRow row in dataTable.Rows)
            {
                return ParseRow(row);
            }
            return null;
        }

        public Dictionary<Nacionalidad, int> PersonasPorNacionalidad()
        {
            DataTable dataTable = acceso.Leer("PersonasPorNacionalidad");
            Dictionary<Nacionalidad, int> personasPorNacionalidad = new Dictionary<Nacionalidad, int>();
            foreach (DataRow row in dataTable.Rows)
            {
                Nacionalidad nacionalidad = ParseRow(row);
                int cantidadPersonas = int.Parse(row["CantidadPersonas"].ToString());

                personasPorNacionalidad.Add(nacionalidad, cantidadPersonas);
            }
            return personasPorNacionalidad;
        }
        public Dictionary<Nacionalidad, int> PromedioEdadPorNacionalidad()
        {
            DataTable dataTable = acceso.Leer("PromedioEdadPorNacionalidad");
            Dictionary<Nacionalidad, int> promedioEdadPorNacionalidad = new Dictionary<Nacionalidad, int>();
            foreach (DataRow row in dataTable.Rows)
            {
                Nacionalidad nacionalidad = ParseRow(row);
                int promedioEdad = int.Parse(row["PromedioEdad"].ToString());

                promedioEdadPorNacionalidad.Add(nacionalidad, promedioEdad);
            }
            return promedioEdadPorNacionalidad;
        }

        protected override SqlParameter[] ParseData(Nacionalidad data)
        {
            SqlParameter[] parametros;
            if (data.Id > 0)
            {
                parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@id", data.Id);
                parametros[1] = new SqlParameter("@descripcion", data.Descripcion);
            } 
            else
            {
                parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@descripcion", data.Descripcion);
            }

            return parametros;
        }

        protected override Nacionalidad ParseRow(DataRow row)
        {
            Nacionalidad nacionalidad = new Nacionalidad(
                int.Parse(row["id"].ToString()), 
                row["descripcion"].ToString());

            return nacionalidad;
        }
    }
}
