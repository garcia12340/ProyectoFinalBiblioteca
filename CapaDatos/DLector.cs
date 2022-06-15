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
    public class DLector
    {
        private DConexion Conexion = new DConexion();
        public DataTable MostrarLector()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarLectores", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablalector = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablalector);
                return tablalector;
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

        public DataTable VerificarLector(LLector LLector)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("VerificarLector", Conexion.AbrirConexion());
                Comando.Parameters.AddWithValue("@codlector", LLector.CodLector);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();

                DataTable tablalector = new DataTable();
                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablalector);
                return tablalector;
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

        public static bool AgregarLector(LLector llector)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarLector", oConexion);
                    Comando.Parameters.AddWithValue("@nombres", llector.Nombres);
                    Comando.Parameters.AddWithValue("@apellidos", llector.Apellidos);
                    Comando.Parameters.AddWithValue("@direccion", llector.Direccion);
                    Comando.Parameters.AddWithValue("@email", llector.Email);
                    Comando.Parameters.AddWithValue("@telefono", llector.Telefono);
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

        public static bool ModificarLector(LLector llector)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarLector", oConexion);
                    Comando.Parameters.AddWithValue("@codlector", llector.CodLector);
                    Comando.Parameters.AddWithValue("@nombres", llector.Nombres);
                    Comando.Parameters.AddWithValue("@apellidos", llector.Apellidos);
                    Comando.Parameters.AddWithValue("@direccion", llector.Direccion);
                    Comando.Parameters.AddWithValue("@email", llector.Email);
                    Comando.Parameters.AddWithValue("@telefono", llector.Telefono);
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

        public static bool EliminarLector(LLector llector)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("EliminarLector", oConexion);
                    Comando.Parameters.AddWithValue("@codlector", llector.CodLector);
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

