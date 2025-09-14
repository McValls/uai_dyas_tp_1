using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personal_DYAS_DAL
{
    public abstract class Mapper<T, K>
    {
        protected readonly Acceso acceso = new Acceso();
        protected readonly string columnaPK;
        protected readonly string obtenerStoreProcedure;
        protected readonly string insertarStoreProcedure;
        protected readonly string editarStoreProcedure;
        protected readonly string eliminarStoreProcedure;

        protected Mapper(string columnaPK,
            string obtenerStoreProcedure,
            string insertarStoreProcedure,
            string editarStoreProcedure,
            string eliminarStoreProcedure)
        {
            this.columnaPK = columnaPK;
            this.obtenerStoreProcedure = obtenerStoreProcedure;
            this.insertarStoreProcedure = insertarStoreProcedure;
            this.editarStoreProcedure = editarStoreProcedure;
            this.eliminarStoreProcedure = eliminarStoreProcedure;
        }

        public List<T> Listar()
        {
            DataTable dataTable = acceso.Leer(obtenerStoreProcedure);
            List<T> list = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                T t = ParseRow(row);
                list.Add(t);
            }

            return list;
        }

        public List<T> Buscar(string storeProcedure, SqlParameter[] parametros)
        {
            DataTable dataTable = acceso.Leer(storeProcedure, parametros);
            List<T> list = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                T t = ParseRow(row);
                list.Add(t);
            }

            return list;
        }

        protected abstract T ParseRow(DataRow row);

        public void IniciarTransaccion()
        {
            acceso.IniciarTransaccion();
        }

        public void Commit()
        {
            acceso.CommitTransaccion();
        }

        public void Rollback()
        {
            acceso.RollbackTransaccion();
        }

        public int Insertar(T t)
        {

            int affectedRows = 0;
            SqlParameter[] parametro = ParseData(t);
            affectedRows = acceso.Escribir(insertarStoreProcedure, parametro);

            return affectedRows;
        }

        public int Editar(T t)
        {
            int affectedRows = 0;
            SqlParameter[] parametro = ParseData(t);
            affectedRows = acceso.Escribir(editarStoreProcedure, parametro);

            return affectedRows;
        }

        public int Eliminar(K pk)
        {
            int affectedRows = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter($"@{columnaPK.ToLower()}", pk);
            affectedRows = acceso.Escribir(eliminarStoreProcedure, parametro);

            return affectedRows;
        }

        protected abstract SqlParameter[] ParseData(T data);
    }
}
