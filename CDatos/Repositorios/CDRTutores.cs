using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CDatos.Entidades;

namespace CDatos.Repositorios
{
    public class CDRTutores : CDConexion
    {
        public DataTable GetAllTututores()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spTutoresGetAll";
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);
                        reader.Close();
                        return table;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int InsertarTutor(CDTutores entity)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spTutoresInsert";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", entity.Nombre);
                        command.Parameters.AddWithValue("@Cedula", entity.Cedula);
                        command.Parameters.AddWithValue("@Direccion", entity.Direccion);
                        command.Parameters.AddWithValue("@Telefono", entity.Telefono);
                        command.Parameters.AddWithValue("@CentroTrabajo", entity.CentroTrabajo);
                        command.Parameters.Add("@Mensaje", SqlDbType.VarChar, 50);
                        command.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                        int result = command.ExecuteNonQuery();
                        if ( result != 1)
                        {
                            string mensaje = command.Parameters["@Mensaje"].Value.ToString();
                            System.Windows.Forms.MessageBox.Show("" + mensaje, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        }
                        return result;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public int ActualizarTutor(CDTutores entity)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spTutoresUpdate";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdTutor", entity.IdTutor);
                        command.Parameters.AddWithValue("@Nombre", entity.Nombre);
                        command.Parameters.AddWithValue("@Cedula", entity.Cedula);
                        command.Parameters.AddWithValue("@Direccion", entity.Direccion);
                        command.Parameters.AddWithValue("@Telefono", entity.Telefono);
                        command.Parameters.AddWithValue("@CentroTrabajo", entity.CentroTrabajo);
                        command.Parameters.Add("@Mensaje", SqlDbType.VarChar, 50);
                        command.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                        int result = command.ExecuteNonQuery();
                        if (result != 1)
                        {
                            string mensaje = command.Parameters["@Mensaje"].Value.ToString();
                            System.Windows.Forms.MessageBox.Show("" + mensaje, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        }
                        return result;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public int EliminarTutor(CDTutores entity)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spTutoresDelete";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IdTutor", entity.IdTutor);
                        command.Parameters.Add("@Mensaje", SqlDbType.VarChar, 250);
                        command.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                        int result = command.ExecuteNonQuery();
                        if (result != 1)
                        {
                            string mensaje = command.Parameters["@Mensaje"].Value.ToString();
                            System.Windows.Forms.MessageBox.Show("" + mensaje, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        }
                        return result;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
