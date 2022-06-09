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
                SqlCommand cmd = new SqlCommand("MostrarLibros", Conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                DataTable tablagenerada = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
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
        //public static List<LLibros> MostrarLibros()
        //{
        //    List<LLibros> rptListaLibros = new List<LLibros>();
        //    using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
        //    {
        //        SqlCommand Comando = new SqlCommand("MostrarLibros", oConexion);
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        try
        //        {
        //            oConexion.Open();
        //            SqlDataReader dr = Comando.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                rptListaLibros.Add(new LLibros()
        //                {
        //                    Titulo = dr["Titulo"].ToString(),
        //                    CodAutor = Convert.ToInt32(dr["autor"].ToString()),
        //                    CodGenero = Convert.ToInt32(dr["genero"].ToString()),
        //                    CodEditorial = Convert.ToInt32(dr["editorial"].ToString()),
        //                    Ubicacion = dr["Ubicacion"].ToString(),
        //                    Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
        //                });
        //            }
        //            dr.Close();

        //            return rptListaLibros;
        //        }
        //        catch (Exception ex)
        //        {
        //            rptListaLibros = null;
        //            return rptListaLibros;
        //        }
        //    }
        //}

        public DataTable VerificarLibro(LLibros Llibro)
        {
            DataTable tablalector = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerificarLibro";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@codlibro", Llibro.Codlibro);
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
            Comando.Parameters.AddWithValue("@codlibro", Llibro.Codlibro);
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

