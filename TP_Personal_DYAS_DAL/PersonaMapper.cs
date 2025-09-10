
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
    public class PersonaMapper : Mapper<Persona, int>
    {
        public PersonaMapper() : base("nro_persona", 
                "GetPersonas", 
                "CreatePersona", 
                "UpdatePersona", 
                "DeletePersona")
        {
        }

        public List<Persona> Buscar(int nroPersona)
        {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@nro_persona", nroPersona);
            return base.Buscar("SearchPersonas", parametro);
        }

        public int CantidadPersonas()
        {
            DataTable dataTable = acceso.Leer("CantidadPersonas");
            foreach(DataRow row in dataTable.Rows)
            {
                return int.Parse(row["Cantidad"].ToString());
            }
            return 0;
        }

        public int PromedioEdad()
        {
            DataTable dataTable = acceso.Leer("PromedioEdadPersonas");
            foreach (DataRow row in dataTable.Rows)
            {
                if (int.TryParse(row["PromedioEdad"].ToString(), out _))
                {
                    return int.Parse(row["PromedioEdad"].ToString());
                }
            }
            return 0;
        }

        public int EdadMaxima()
        {
            DataTable dataTable = acceso.Leer("MaximaEdadPersonas");
            foreach (DataRow row in dataTable.Rows)
            {
                if (int.TryParse(row["MaximaEdad"].ToString(), out _))
                {
                    return int.Parse(row["MaximaEdad"].ToString());
                }
            }
            return 0;
        }

        public int EdadMinima()
        {
            DataTable dataTable = acceso.Leer("MinimaEdadPersonas");
            foreach (DataRow row in dataTable.Rows)
            {
                if (int.TryParse(row["MinimaEdad"].ToString(), out _))
                {
                    return int.Parse(row["MinimaEdad"].ToString());
                }
            }
            return 0;
        }

        protected override SqlParameter[] ParseData(Persona data)
        {
            SqlParameter[] parametros;
            if (data.NroPersona > 0)
            {
                parametros = new SqlParameter[7];
                parametros[0] = new SqlParameter("@nro_persona", data.NroPersona);
                parametros[1] = new SqlParameter("@nombre", data.Nombre);
                parametros[2] = new SqlParameter("@apellido", data.Apellido);
                parametros[3] = new SqlParameter("@fecha_nacimiento", data.FechaNacimiento);
                parametros[4] = new SqlParameter("@sexo", data.Sexo);
                parametros[5] = new SqlParameter("@id_nacionalidad", data.IdNacionalidad);
                parametros[6] = new SqlParameter("@id_profesion", data.IdProfesion);
            } else
            {
                parametros = new SqlParameter[6];
                parametros[0] = new SqlParameter("@nombre", data.Nombre);
                parametros[1] = new SqlParameter("@apellido", data.Apellido);
                parametros[2] = new SqlParameter("@fecha_nacimiento", data.FechaNacimiento);
                parametros[3] = new SqlParameter("@sexo", data.Sexo);
                parametros[4] = new SqlParameter("@id_nacionalidad", data.IdNacionalidad);
                parametros[5] = new SqlParameter("@id_profesion", data.IdProfesion);
            }

            return parametros;
        }

        protected override Persona ParseRow(DataRow row)
        {
            int nroPersona = int.Parse(row["nro_persona"].ToString());
            string nombre = row["nombre"].ToString();
            string apellido = row["apellido"].ToString();
            DateTime fechaNacimiento = DateTime.Parse(row["fecha_nacimiento"].ToString());
            Sexo sexo = (Sexo) Enum.Parse(typeof(Sexo), row["sexo"].ToString());
            int idNacionalidad = int.Parse(row["id_nacionalidad"].ToString());
            int idProfesion= int.Parse(row["id_profesion"].ToString());
            Persona persona = new Persona(nroPersona, nombre, apellido, fechaNacimiento, sexo, idNacionalidad, idProfesion);
            
            return persona;
        }
    }
}
