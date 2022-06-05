using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DConexion
    {
        static public string CadenaConexion = "Server=LAPTOP-GK4LE9BQ;DataBase=dbbiblioteca;Integrated Security=true";
        public SqlConnection Conexion = new SqlConnection(CadenaConexion);
        // public SqlConnection con = new SqlConnection("SERVER=LAPTOP-GK4LE9BQ; DATABASE=dbbiblioteca;Integrated Security = true;");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}

