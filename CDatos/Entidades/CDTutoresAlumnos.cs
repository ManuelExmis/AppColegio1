using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Entidades
{
    public class CDTutoresAlumnos
    {
        public int IdTutAlumnos { get; set; }
        public int IdTutor { get; set; }
        public int IdAlumno { get; set; }
        public string Parentesco { get; set; }
    }
}
