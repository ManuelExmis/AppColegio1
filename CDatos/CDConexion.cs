using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CDatos
{
    public abstract class CDConexion
    {
        private readonly string connectionString;

        public CDConexion()
        {
            connectionString = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
