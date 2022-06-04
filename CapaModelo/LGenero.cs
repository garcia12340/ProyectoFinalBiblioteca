using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LGenero
    {
        public int CodGenero;
        public string Genero;
        public int _CodGenero
        {
            get { return CodGenero; }
            set { CodGenero = value; }
        }
        public string _Genero
        {
            get { return Genero; }
            set { Genero = value; }
        }
    }
}
