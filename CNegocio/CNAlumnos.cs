using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Entidades;
using CDatos.Repositorios;
using System.Data;
using System.Data.SqlClient;
using CNegocio.Peticiones;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CDatos;

namespace CNegocio
{
    public class CNAlumnos
    {
        CDRAlumnos _CDRAlumnos = new CDRAlumnos();

        public DataTable GetAllAlumnos()
        {
            try
            {
                return _CDRAlumnos.GetAllAlumnos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetAllTutoresAlumnos()
        {
            try
            {
                return _CDRAlumnos.GetAllTutoresAlumno();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int insertarAlumno(CNPeticionesAlumnos entityAlumno, List<CNPeticionesTutoresAlumnos> entityTutoresAlumnos)
        {
            try
            {
                CDAlumnos alumno = new CDAlumnos()
                {
                    Nombre = entityAlumno.Nombre,
                    Apellidos = entityAlumno.Apellidos,
                    FechaNacimiento = entityAlumno.FechaNacimiento,
                    Direccion = entityAlumno.Direccion,
                    CodEstudiante = entityAlumno.CodEstudiante
                };
                List<CDTutoresAlumnos> listaTutoresAlumnos = new List<CDTutoresAlumnos>();
                foreach (CNPeticionesTutoresAlumnos tutorAlumno in entityTutoresAlumnos)
                {
                    CDTutoresAlumnos entityTutorAlumno = new CDTutoresAlumnos()
                    {
                        IdTutor = tutorAlumno.IdTutor,
                        Parentesco = tutorAlumno.Parentesco
                    };
                    listaTutoresAlumnos.Add(entityTutorAlumno);
                }

                return _CDRAlumnos.InsertarAlumno(alumno, listaTutoresAlumnos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int actualizarAlumno(CNPeticionesAlumnos entityAlumno, List<CNPeticionesTutoresAlumnos> entityTutoresAlumnos)
        {
            try
            {
                CDAlumnos alumno = new CDAlumnos()
                {
                    IdAlumno = entityAlumno.IdAlumno,
                    Nombre = entityAlumno.Nombre,
                    Apellidos = entityAlumno.Apellidos,
                    FechaNacimiento = entityAlumno.FechaNacimiento,
                    Direccion = entityAlumno.Direccion,
                    CodEstudiante = entityAlumno.CodEstudiante
                };
                List<CDTutoresAlumnos> listaTutoresAlumnos = new List<CDTutoresAlumnos>();
                foreach (CNPeticionesTutoresAlumnos tutorAlumno in entityTutoresAlumnos)
                {
                    CDTutoresAlumnos entityTutorAlumno = new CDTutoresAlumnos()
                    {
                        IdAlumno = alumno.IdAlumno,
                        IdTutor = tutorAlumno.IdTutor,
                        Parentesco = tutorAlumno.Parentesco
                    };
                    if (tutorAlumno.IdTutAlumnos != null && tutorAlumno.IdTutAlumnos > 0)
                    {
                        entityTutorAlumno.IdTutAlumnos = tutorAlumno.IdTutAlumnos;
                    }
                    listaTutoresAlumnos.Add(entityTutorAlumno);
                }

                return _CDRAlumnos.ActualizarAlumno(alumno, listaTutoresAlumnos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
