using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Entidades
{
    public class CDUsuarios
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
    }
}
