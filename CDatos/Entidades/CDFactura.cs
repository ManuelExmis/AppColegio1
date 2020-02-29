using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class CDFactura
    {
        public long IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}
