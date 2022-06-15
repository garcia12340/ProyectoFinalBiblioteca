using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LPrestamo
    {
        public int CodPrestamo { get; set; }
        public int CodLector { get; set; }
        public int CodLibro { get; set; }
        public DateTime Fec_Devolucion { get; set; }
    }
}


