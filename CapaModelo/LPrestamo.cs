using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LPrestamo
    {
        public int CodPrestamo;
        public int CodLector;
        public int CodLibro;
        public DateTime Fec_Devolucion;

        public int _CodPrestamo
        {
            get { return CodPrestamo; }
            set { CodPrestamo = value; }

        }
        public int _CodLector
        {
            get { return CodLector; }
            set { CodLector = value; }

        }
        public int _CodLibro
        {
            get { return CodLibro; }
            set { CodLibro = value; }

        }
        public DateTime _Fec_Devolucion
        {
            get { return Fec_Devolucion; }
            set { Fec_Devolucion = value; }
        }
    }
}
