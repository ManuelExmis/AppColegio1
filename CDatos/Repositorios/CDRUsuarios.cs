using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CDatos.Entidades;

namespace CDatos.Repositorios
{
    public class CDRUsuarios : CDConexion
    {
        public DataTable GetAllUsuarios()
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spUsuariosGetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    return dataTable;
                }
            }
        }

        public DataTable FindUser(CDUsuarios _CDUsuarios)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spUsuariosFindUser";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", _CDUsuarios.Usuario);
                        command.Parameters.AddWithValue("@Password", _CDUsuarios.Password);
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        reader.Close();
                        return dataTable;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
