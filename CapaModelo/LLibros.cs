using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LLibros
    {
        public string Titulo;
        public string Ubicacion;
        public int Codlibro;
        public int CodAutor;
        public int CodGenero;
        public int CodEditorial;
        public int Cantidad;

        public string _Titulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }
        public string _Ubicacion
        {
            get { return Ubicacion; }
            set { Ubicacion = value; }
        }
        public int _Codlibro
        {
            get { return Codlibro; }
            set { Codlibro = value; }
        }
        public int _CodAutor
        {
            get { return CodAutor; }
            set { CodAutor = value; }
        }
        public int _CodGenero
        {
            get { return CodGenero; }
            set { CodGenero = value; }
        }
        public int _CodEditorial
        {
            get { return CodEditorial; }
            set { CodEditorial = value; }
        }
        public int _Cantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
    }
}
