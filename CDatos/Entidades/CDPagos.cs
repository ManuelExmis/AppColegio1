using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Entidades
{
    public class CDPagos
    {
        public int IdPago { get; set; }
        public int IdMatricula { get; set; }
        public DateTime Fecha { get; set; }
        public Int16 MesPago { get; set; }
        public long IdFactura { get; set; }
    }
}
