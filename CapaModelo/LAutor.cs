﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LAutor
    {
        public string Autor;
        public int CodAutor;

        //metodos get y set
        public int _CodAutor
        {
            get { return CodAutor; }
            set { CodAutor = value; }
        }

        public string _Autor
        {
            get { return Autor; }
            set { Autor = value; }
        }
    }
}