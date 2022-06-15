using System;
using CapaDatos;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaDatos
{
    public class DGenero
    {
        private DConexion Conexion = new DConexion();
        public DataTable MostrarGenero()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarGenero", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablagenero = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablagenero);
                return tablagenero;
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

        public static bool AgregarGenero(LGenero lgenero)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarGenero", oConexion);
                    Comando.Parameters.AddWithValue("@genero", lgenero.Genero);
                    Comando.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    Comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    res = false;
                }
                //finally
                //{
                //    oConexion.Close();
                //}

                return res;
            }

        }

        public static bool ModificarGenero(LGenero lgenero)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarGenero", oConexion);
                    Comando.Parameters.AddWithValue("@codgenero", lgenero.CodGenero);
                    Comando.Parameters.AddWithValue("@genero", lgenero.Genero);
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

        public static bool EliminarGenero(LGenero lgenero)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("EliminarGenero", oConexion);
                    Comando.Parameters.AddWithValue("@codgenero", lgenero.CodGenero);
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

