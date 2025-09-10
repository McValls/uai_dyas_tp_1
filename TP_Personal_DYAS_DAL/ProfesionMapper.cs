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
    public class ProfesionMapper : Mapper<Profesion, int>
    {
        public ProfesionMapper() : base("id",
            "GetProfesiones",
            "CreateProfesion",
            "UpdateProfesion",
            "DeleteProfesion"
            )
        {
        }

        public Profesion ProfesionConMasPersonas()
        {
            DataTable dataTable = acceso.Leer("ProfesionMasPersonas");
            foreach (DataRow row in dataTable.Rows)
            {
                return ParseRow(row);
            }
            return null;
        }

        protected override SqlParameter[] ParseData(Profesion data)
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

        protected override Profesion ParseRow(DataRow row)
        {
            int id = int.Parse(row["id"].ToString());
            string descripcion = row["descripcion"].ToString();
            Profesion profesion = new Profesion(id, descripcion);

            return profesion;
        }
    }
}
