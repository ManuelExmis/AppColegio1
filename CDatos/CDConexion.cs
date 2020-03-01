using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CDatos
{
    public abstract class CDConexion
    {
        private string connectionString { get; set; }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-9CA44ML;Initial Catalog=Colegio;Integrated Security=True");
        }
    }
}
