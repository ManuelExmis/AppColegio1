using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Entidades
{
    public class CDMatriculas
    {
        public int IdMatricula { get; set; }
        public int IdAlumnoGrado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Arancel { get; set; }
        public string Turno { get; set; }
        public bool NuevoIngreso { get; set; }
        public int IdUsuario { get; set; }
        public bool Activo { get; set; }
    }
}
