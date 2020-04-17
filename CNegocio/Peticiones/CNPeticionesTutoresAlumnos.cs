using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Peticiones
{
    public class CNPeticionesTutoresAlumnos
    {
        public int IdTutAlumnos { get; set; }
        public int IdTutor { get; set; }
        public int IdAlumno { get; set; }
        public string Parentesco { get; set; }
    }
}
