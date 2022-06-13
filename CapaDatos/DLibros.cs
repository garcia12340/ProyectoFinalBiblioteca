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
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader dr;

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

        //public DataTable VerificarLibro(LLibros Llibro)
        //{
        //    DataTable tablalector = new DataTable();
        //    Comando.Connection = Conexion.AbrirConexion();
        //    Comando.CommandText = "VerificarLibro";
        //    Comando.CommandType = CommandType.StoredProcedure;

        //    Comando.ExecuteNonQuery();//Pendiente
        //    LeerFilas = Comando.ExecuteReader();
        //    tablalector.Load(LeerFilas);
        //    LeerFilas.Close();
        //    Conexion.CerrarConexion();
        //    return tablalector;
        //}

        public static bool VerificarCantidadLibro(LLibros Llibro)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("VerificarCantidadLibro", oConexion);
                    Comando.Parameters.AddWithValue("@codlibro", Llibro.Codlibro);
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
        //public DataTable VerificarCantidadLibro(LLibros Llibro)
        //{
        //    DataTable tablalector = new DataTable();
        //    Comando.Connection = Conexion.AbrirConexion();
        //    Comando.CommandText = "VerificarCantidadLibro";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    Comando.Parameters.AddWithValue("@codlibro", Llibro.Codlibro);
        //    Comando.ExecuteNonQuery();//Pendiente
        //    LeerFilas = Comando.ExecuteReader();
        //    tablalector.Load(LeerFilas);
        //    LeerFilas.Close();
        //    Conexion.CerrarConexion();
        //    return tablalector;
        //}

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
        //public DataTable MostrarStockLibros()
        //{
        //    DataTable tablalibros = new DataTable();
        //    Comando.Connection = Conexion.AbrirConexion();
        //    Comando.CommandText = "MostrarLibrosStock";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    LeerFilas = Comando.ExecuteReader();
        //    tablalibros.Load(LeerFilas);
        //    LeerFilas.Close();
        //    Conexion.CerrarConexion();
        //    return tablalibros;
        //}

        public bool Agregarlibro(LLibros llibro)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarLibro";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@titulo", llibro.Titulo);
                Comando.Parameters.AddWithValue("@codautor", llibro.CodAutor);
                Comando.Parameters.AddWithValue("@codgenero", llibro.CodGenero);
                Comando.Parameters.AddWithValue("@codeditorial", llibro.CodEditorial);
                Comando.Parameters.AddWithValue("@ubicacion", llibro.Ubicacion);
                Comando.Parameters.AddWithValue("@cantidad", llibro.Cantidad);
                Comando.ExecuteNonQuery();
                dr = Comando.ExecuteReader();

                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }

        }

        public bool ModificarLibro(LLibros llibro)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ModificarLibro";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codlibro", llibro.Codlibro);
                Comando.Parameters.AddWithValue("@titulo", llibro.Titulo);
                Comando.Parameters.AddWithValue("@codautor", llibro.CodAutor);
                Comando.Parameters.AddWithValue("@codgenero", llibro.CodGenero);
                Comando.Parameters.AddWithValue("@codeditorial", llibro.CodEditorial);
                Comando.Parameters.AddWithValue("@ubicacion", llibro.Ubicacion);
                Comando.Parameters.AddWithValue("@cantidad", llibro.Cantidad);
                Comando.ExecuteNonQuery();
                dr = Comando.ExecuteReader();

                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        public bool EliminarLibro(LLibros llibro)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "EliminarLibro";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codlibro", llibro.Codlibro);
                Comando.ExecuteNonQuery();
                dr = Comando.ExecuteReader();

                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

    }
}

