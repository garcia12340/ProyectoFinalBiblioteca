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
    class DLibros
    {
        private DConexion Conexion = new DConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader dr;

        public DataTable MostrarLibros()
        {
            DataTable tablalibros = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarLibros";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tablalibros.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablalibros;
        }

        public DataTable VerificarLibro(LLibros Llibro)
        {
            DataTable tablalector = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerificarLibro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@codlibro", Llibro._Codlibro);
            Comando.ExecuteNonQuery();//Pendiente
            LeerFilas = Comando.ExecuteReader();
            tablalector.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablalector;
        }

        public DataTable VerificarCantidadLibro(LLibros Llibro)
        {
            DataTable tablalector = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerificarCantidadLibro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@codlibro", Llibro._Codlibro);
            Comando.ExecuteNonQuery();//Pendiente
            LeerFilas = Comando.ExecuteReader();
            tablalector.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablalector;
        }

        public DataTable MostrarStockLibros()
        {
            DataTable tablalibros = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarLibrosStock";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tablalibros.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablalibros;
        }

        public bool Agregarlibro(LLibros llibro)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarLibro";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@titulo", llibro._Titulo);
                Comando.Parameters.AddWithValue("@codautor", llibro._CodAutor);
                Comando.Parameters.AddWithValue("@codgenero", llibro._CodGenero);
                Comando.Parameters.AddWithValue("@codeditorial", llibro._CodEditorial);
                Comando.Parameters.AddWithValue("@ubicacion", llibro._Ubicacion);
                Comando.Parameters.AddWithValue("@cantidad", llibro._Cantidad);
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
                Comando.Parameters.AddWithValue("@codlibro", llibro._Codlibro);
                Comando.Parameters.AddWithValue("@titulo", llibro._Titulo);
                Comando.Parameters.AddWithValue("@codautor", llibro._CodAutor);
                Comando.Parameters.AddWithValue("@codgenero", llibro._CodGenero);
                Comando.Parameters.AddWithValue("@codeditorial", llibro._CodEditorial);
                Comando.Parameters.AddWithValue("@ubicacion", llibro._Ubicacion);
                Comando.Parameters.AddWithValue("@cantidad", llibro._Cantidad);
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
                Comando.Parameters.AddWithValue("@codlibro", llibro._Codlibro);
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

