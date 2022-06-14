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
        //public static List<LLector> MostrarLector()
        //{
        //    List<LLector> mostrar = new List<LLector>();
        //    using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
        //    {
        //        SqlCommand Comando = new SqlCommand("MostrarLectores", oConexion);
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        try
        //        {
        //            oConexion.Open();
        //            SqlDataReader dr = Comando.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                mostrar.Add(new LLector()
        //                {

        //                    CodLector = Convert.ToInt32(dr["CodLector"].ToString()),
        //                    Nombres = dr["Nombres"].ToString(),
        //                    Apellidos = dr["Apellidos"].ToString(),
        //                    Direccion = dr["Direccion"].ToString(),
        //                    Email = dr["Email"].ToString(),
        //                    Telefono = Convert.ToInt32(dr["Telefono"].ToString())
        //                });
        //            }
        //            dr.Close();

        //            return mostrar;
        //        }
        //        catch (Exception ex)
        //        {
        //            mostrar = null;
        //            return mostrar;
        //        }
        //    }
        //}

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
        //public DataTable MostrarLector()
        //{
        //    DataTable tablalector = new DataTable();
        //    Comando.Connection = Conexion.AbrirConexion();
        //    Comando.CommandText = "MostrarLectores";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    LeerFilas = Comando.ExecuteReader();
        //    tablalector.Load(LeerFilas);
        //    LeerFilas.Close();
        //    Conexion.CerrarConexion();
        //    return tablalector;
        //}


        public DataTable VerificarLector(LLector LLector)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarPrestamoDeudaLecor", Conexion.AbrirConexion());
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
                    SqlCommand Comando = new SqlCommand("EliminarBibliotecario", oConexion);
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

