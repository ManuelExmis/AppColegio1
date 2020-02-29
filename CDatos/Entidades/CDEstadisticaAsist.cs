using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class CDEstadisticaAsist
    {
        public int IdEstadisticaAsist { get; set; }
        public int IdGrado { get; set; }
        public int IdParcial { get; set; }
        public Int16 DiasHabiles { get; set; }
        public Int16 NEstudiantesAS { get; set; }
        public Int16 NEstudiatesF { get; set; }
        public Int16 InasitenciasAS { get; set; }
        public Int16 InasistenciaF { get; set; }
        public DateTime Fecha { get; set; }
    }
}
