using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEditorial
    {
        private DConexion Conexion = new DConexion();
        public DataTable MostrarEditorial()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarEditorial", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablaeditorial = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablaeditorial);
                return tablaeditorial;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
 
        public static bool AgregarEditorial(LEditorial leditorial)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarEditorial", oConexion);
                    Comando.Parameters.AddWithValue("@editorial", leditorial.Editorial);
                    Comando.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    Comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    res = false;
                }

                return res;
            }

        }

        public static bool ModificarEditorial(LEditorial leditorial)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarEditorial", oConexion);
                    Comando.Parameters.AddWithValue("@codeditorial", leditorial.CodEditorial);
                    Comando.Parameters.AddWithValue("@editorial", leditorial.Editorial);
                    Comando.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    Comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    res = false;
                }

                return res;
            }

        }

        public static bool EliminarEditorial(LEditorial leditorial)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("EliminarEditorial", oConexion);
                    Comando.Parameters.AddWithValue("@codeditorial", leditorial.CodEditorial);
                    Comando.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    Comando.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

    }

}

