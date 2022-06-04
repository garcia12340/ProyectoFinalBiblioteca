using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LLector
    {
        public int CodLector;
        public int Telefono;
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public string Email;

        public int _CodLector
        {
            get { return CodLector; }
            set { CodLector = value; }
        }
        public int _Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public string _Nombres
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
        public string _Apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        public string _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
