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
    public class DLibros
    {
        private DConexion Conexion = new DConexion();

        public DataTable MostrarLibros()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarLibros", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablagenerada = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablagenerada);
                return tablagenerada;
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
 
        public DataTable VerificarLibro(LLibros Llibro)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("VerificarLibro", Conexion.AbrirConexion());
                Comando.Parameters.AddWithValue("@codlibro", Llibro.Codlibro);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();

                DataTable tablalecto = new DataTable();

                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablalecto);
                return tablalecto;

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

        public DataTable VerificarCantidadLibro(LLibros Llibro)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("VerificarCantidadLibro", Conexion.AbrirConexion());
                Comando.Parameters.AddWithValue("@codlibro", Llibro.Codlibro);
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

        public DataTable MostrarStockLibros()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarLibrosStock", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablalibros = new DataTable();


                SqlDataAdapter tablal = new SqlDataAdapter(Comando);
                tablal.Fill(tablalibros);
                return tablalibros;
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
 
        public static bool Agregarlibro(LLibros llibro)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarLibro", oConexion);
                    Comando.Parameters.AddWithValue("@titulo", llibro.Titulo);
                    Comando.Parameters.AddWithValue("@codautor", llibro.CodAutor);
                    Comando.Parameters.AddWithValue("@codgenero", llibro.CodGenero);
                    Comando.Parameters.AddWithValue("@codeditorial", llibro.CodEditorial);
                    Comando.Parameters.AddWithValue("@ubicacion", llibro.Ubicacion);
                    Comando.Parameters.AddWithValue("@cantidad", llibro.Cantidad);
                    Comando.Parameters.AddWithValue("@nroEdicion", llibro.Nro_Edicion);
                    Comando.Parameters.AddWithValue("@añoEdicion", llibro.AñoEdicion);
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

        public static bool ModificarLibro(LLibros llibro)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarLibro", oConexion);
                    Comando.Parameters.AddWithValue("@codlibro", llibro.Codlibro);
                    Comando.Parameters.AddWithValue("@titulo", llibro.Titulo);
                    Comando.Parameters.AddWithValue("@codautor", llibro.CodAutor);
                    Comando.Parameters.AddWithValue("@codgenero", llibro.CodGenero);
                    Comando.Parameters.AddWithValue("@codeditorial", llibro.CodEditorial);
                    Comando.Parameters.AddWithValue("@ubicacion", llibro.Ubicacion);
                    Comando.Parameters.AddWithValue("@cantidad", llibro.Cantidad);
                    Comando.Parameters.AddWithValue("@nroEdicion", llibro.Nro_Edicion);
                    Comando.Parameters.AddWithValue("@añoEdicion", llibro.AñoEdicion);
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

        public static bool EliminarLibro(LLibros llibro)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("EliminarLibro", oConexion);
                    Comando.Parameters.AddWithValue("@codlibro", llibro.Codlibro);
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

