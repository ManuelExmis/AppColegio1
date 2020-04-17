using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CDatos.Repositorios
{
    public class CDRAlumnos : CDConexion
    {
        public DataTable GetAllAlumnos()
        {
            using(var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spAlumnoGetAll";
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

        public DataTable GetAllTutoresAlumno()
        {
            using(var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using(var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spTutoresAlumnosGetAll";
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

        public int InsertarAlumno(CDAlumnos entityAlumno, List<CDTutoresAlumnos> entityTutoresAlumnos)
        {
            try
            {
                using(var connection = GetConnection())
                {
                    connection.Open();
                    using(var command = new SqlCommand())
                    {
                        SqlTransaction transaction;
                        // iniciar transaccion
                        transaction = connection.BeginTransaction("trx");
                        command.Connection = connection;
                        command.Transaction = transaction;
                        try
                        {
                            int lineasAfectadas = 0;
                            string err = "";
                            command.CommandText = "spAlumnoInsert";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Nombre", entityAlumno.Nombre);
                            command.Parameters.AddWithValue("@Apellidos", entityAlumno.Apellidos);
                            command.Parameters.AddWithValue("@FechaNacimiento", entityAlumno.FechaNacimiento);
                            command.Parameters.AddWithValue("@Direccion", entityAlumno.Direccion);
                            command.Parameters.AddWithValue("@CodEstudiante", entityAlumno.CodEstudiante);
                            command.Parameters.Add("@IdAlumno", SqlDbType.Int);
                            command.Parameters["@IdAlumno"].Direction = ParameterDirection.Output;
                            int result = command.ExecuteNonQuery();
                            int idAlumno = 0;
                            if (result == 1)
                            {
                                idAlumno = int.Parse(command.Parameters["@IdAlumno"].Value.ToString());
                                command.Parameters.Clear();
                                command.CommandText = "";
                                lineasAfectadas++;
                                foreach(CDTutoresAlumnos tutorAlumno in entityTutoresAlumnos)
                                {
                                    command.CommandText = "spTutoresAlumnosInsert";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@IdTutor", tutorAlumno.IdTutor);
                                    command.Parameters.AddWithValue("@IdAlumno", idAlumno);
                                    command.Parameters.AddWithValue("@Parentesco", tutorAlumno.Parentesco);
                                    int r = command.ExecuteNonQuery();
                                    command.Parameters.Clear();
                                    command.CommandText = "";
                                    if (r == 1)
                                    {
                                        lineasAfectadas++;
                                    } else
                                    {
                                        err += "\nerror en spTutoresAlumnosInsert";
                                    }
                                }
                                transaction.Commit();
                            } else
                            {
                                transaction.Rollback();
                                err += "\nerror en spTutoresAlumnosInsert";
                            }
                            if (err != "")
                            {
                                System.Windows.Forms.MessageBox.Show(err, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                                return -1;
                            }
                            return lineasAfectadas;
                        }
                        catch (Exception ex2)
                        {
                            System.Windows.Forms.MessageBox.Show(ex2.Message, "Error en la transaccion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex3)
                            {
                                System.Windows.Forms.MessageBox.Show(ex3.Message, "Error al hacer el rollback", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                                throw ex3;
                            }
                            throw ex2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public int ActualizarAlumno(CDAlumnos entityAlumno, List<CDTutoresAlumnos> entityTutoresAlumnos)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        SqlTransaction transaction;
                        // iniciar transaccion
                        transaction = connection.BeginTransaction("trx");
                        command.Connection = connection;
                        command.Transaction = transaction;
                        try
                        {
                            int lineasAfectadas = 0;
                            string err = "";
                            command.CommandText = "spAlumnoUpdate";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdAlumno", entityAlumno.IdAlumno);
                            command.Parameters.AddWithValue("@Nombres", entityAlumno.Nombre);
                            command.Parameters.AddWithValue("@Apellidos", entityAlumno.Apellidos);
                            command.Parameters.AddWithValue("@FechaNacimiento", entityAlumno.FechaNacimiento);
                            command.Parameters.AddWithValue("@Direccion", entityAlumno.Direccion);
                            command.Parameters.AddWithValue("@CodEstudiante", entityAlumno.CodEstudiante);
                            command.Parameters.Add("@Mensaje", SqlDbType.VarChar, 1000);
                            command.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                            int result = command.ExecuteNonQuery();
                            if (result >= 1)
                            {
                                lineasAfectadas++;
                                foreach (CDTutoresAlumnos tutorAlumno in entityTutoresAlumnos)
                                {
                                    command.Parameters.Clear();
                                    command.CommandText = "";
                                    command.CommandText = (tutorAlumno.IdTutAlumnos != null && tutorAlumno.IdTutAlumnos > 0) ? "spTutoresAlumnosUpdate" : "spTutoresAlumnosInsert";
                                    command.CommandType = CommandType.StoredProcedure;
                                    if (tutorAlumno.IdTutAlumnos != null && tutorAlumno.IdTutAlumnos > 0)
                                    {
                                        command.Parameters.AddWithValue("@IdTutAlumnos", tutorAlumno.IdTutAlumnos);
                                    }
                                    command.Parameters.AddWithValue("@IdAlumno", entityAlumno.IdAlumno);
                                    command.Parameters.AddWithValue("@IdTutor", tutorAlumno.IdTutor);
                                    command.Parameters.AddWithValue("@Parentesco", tutorAlumno.Parentesco);
                                    command.Parameters.Add("@Mensaje", SqlDbType.VarChar, 1000);
                                    command.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                                    int r = command.ExecuteNonQuery();
                                    if (r == 1)
                                    {
                                        lineasAfectadas++;
                                    }
                                    else
                                    {
                                        err += "\nerror en actualizar o insertar Tutor, "+ command.Parameters["@Mensaje"].Value.ToString();
                                    }
                                }
                                transaction.Commit();
                            }
                            else
                            {
                                transaction.Rollback();
                                err += "\n"+ command.Parameters["@IdAlumno"].Value.ToString();
                            }
                            if (err != "")
                            {
                                System.Windows.Forms.MessageBox.Show(err, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                                return -1;
                            }
                            return lineasAfectadas;
                        }
                        catch (Exception ex2)
                        {
                            System.Windows.Forms.MessageBox.Show(ex2.Message, "Error en la transaccion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex3)
                            {
                                System.Windows.Forms.MessageBox.Show(ex3.Message, "Error al hacer el rollback", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                                throw ex3;
                            }
                            throw ex2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
