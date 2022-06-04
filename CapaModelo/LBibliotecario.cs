using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LBibliotecario
    {
        public string Nombres;
        public string _Nombres
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
        public string Apellidos;
        public string _Apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        public string Direccion;
        public string _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string Email;
        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string Nro_Carnet;
        public string _Nro_Carnet
        {
            get { return Nro_Carnet; }
            set { Nro_Carnet = value; }
        }
        public string Contrasena;
        public string _Contrasena
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }
        public int CodBibliotecario;
        public int _CodBibliotecario
        {
            get { return CodBibliotecario; }
            set { CodBibliotecario = value; }
        }
        public int Telefono;
        public int _Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public int Dni;
        public int _Dni
        {
            get { return Dni; }
            set { Dni = value; }
        }
    }
}

