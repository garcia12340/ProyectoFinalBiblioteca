using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LEditorial
    {
        public int CodEditorial;
        public string Editorial;
        public int _CodEditorial
        {
            get { return CodEditorial; }
            set { CodEditorial = value; }
        }


        public string _Editorial
        {
            get { return Editorial; }
            set { Editorial = value; }
        }
    }
}

