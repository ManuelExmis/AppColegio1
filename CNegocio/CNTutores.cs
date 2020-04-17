using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CDatos.Repositorios;
using CDatos.Entidades;

namespace CNegocio
{
    public class CNTutores
    {
        public CDRTutores _CDRTutores = new CDRTutores();

        public DataTable GetAllTutores()
        {
            try
            {
                return _CDRTutores.GetAllTututores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertTutor(string nombre, string cedula, string direccion, string telefono, string centroTrabajo)
        {
            try
            {
                CDTutores entity = new CDTutores()
                {
                    Nombre = nombre,
                    Cedula = cedula,
                    Direccion = direccion,
                    Telefono = telefono,
                    CentroTrabajo = centroTrabajo
                };
                int result = _CDRTutores.InsertarTutor(entity);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ActualizarTutor(int idtutor, string nombre, string cedula, string direccion, string telefono, string centroTrabajo)
        {
            try
            {
                CDTutores entity = new CDTutores()
                {
                    IdTutor = idtutor,
                    Nombre = nombre,
                    Cedula = cedula,
                    Direccion = direccion,
                    Telefono = telefono,
                    CentroTrabajo = centroTrabajo
                };
                int result = _CDRTutores.ActualizarTutor(entity);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int EliminarTutor(int idtutor)
        {
            try
            {
                CDTutores entity = new CDTutores()
                {
                    IdTutor = idtutor
                };
                int result = _CDRTutores.EliminarTutor(entity);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
