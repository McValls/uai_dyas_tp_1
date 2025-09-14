using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personal_DYAS_DAL
{
    public class Acceso
    {
        
        private readonly string connectionString = "Data Source=DESKTOP-MIQ4GPN\\MSSQLSERVER01;Initial Catalog=Contrataciones;Integrated Security=True;";
        SqlConnection connection = new SqlConnection();
        SqlTransaction transaccion = null;
        private void Conectar()
        {
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        private void Desconectar()
        {
            connection.Close();
        }

        public void IniciarTransaccion()
        {
            Conectar();
            this.transaccion = connection.BeginTransaction();
        }

        public void CommitTransaccion()
        {
            if (this.transaccion == null)
            {
                throw new Exception("No se puede hacer un commit sin una transacción existente");
            }
            this.transaccion.Commit();
            this.transaccion = null;
            Desconectar();
        }

        public void RollbackTransaccion()
        {
            if (this.transaccion == null)
            {
                throw new Exception("No se puede hacer un rollback sin una transacción existente");
            }
            this.transaccion.Rollback();
            this.transaccion = null;
            Desconectar();
        }

        public int Escribir(string sp)
        {
            return Escribir(sp, null);
        }

        public int Escribir(string sp, SqlParameter[] parametro)
        {
            int affectedRows = 0;
                
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Transaction = this.transaccion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            if (parametro != null)
            {
                command.Parameters.AddRange(parametro);
                affectedRows = command.ExecuteNonQuery();
            }
            else
            {
                affectedRows = command.ExecuteNonQuery();
            }
            command.Parameters.Clear();

            return affectedRows;
            
        }

        public DataTable Leer(string sp)
        {
            return Leer(sp, null);
        }

        public DataTable Leer(string sp, SqlParameter[] parametro)
        {
            try
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                Conectar();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sp;

                if (parametro != null)
                {
                    command.Parameters.AddRange(parametro);
                }

                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                return dataTable;
            } finally
            {
                Desconectar();
            }
        }
    }
}
