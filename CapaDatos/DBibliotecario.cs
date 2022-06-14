using System;
using CapaModelo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DBibliotecario
    {
        private DConexion Conexion = new DConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader dr;

        public bool AccederBibliotecario(LBibliotecario lbibliotecario)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AccederBibliotecario";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@user", lbibliotecario.Nro_Carnet);
                Comando.Parameters.AddWithValue("@clave", lbibliotecario.Contrasena);
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

        public DataTable GenerarCarnet()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NroCarnetBibliotecario",Conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                DataTable tablagenerada = new DataTable();
                

                SqlDataAdapter adaptar = new SqlDataAdapter(cmd);
                adaptar.Fill(tablagenerada);
                return tablagenerada;
            }
            catch (Exception )
            {
                return null;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        public static List<LBibliotecario> MostrarBibliotecarios()
        {
            List<LBibliotecario> mostrar = new List<LBibliotecario>();
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                SqlCommand Comando = new SqlCommand("MostrarBibliotecarios", oConexion);
                Comando.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        mostrar.Add(new LBibliotecario()
                        {
                           CodBibliotecario = Convert.ToInt32(dr["CodBibliotecario"].ToString()),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Email = dr["Email"].ToString(),
                            Telefono = Convert.ToInt32(dr["Telefono"].ToString()),
                            Dni = Convert.ToInt32(dr["Dni"].ToString()),
                            Nro_Carnet = dr["Nro_Carnet"].ToString(),
                            Contrasena = dr["Clave"].ToString()
                        });
                    }
                    dr.Close();

                    return mostrar;
                }
                catch (Exception ex)
                {
                    mostrar = null;
                    return mostrar;
                }
            }
        }

        public static bool AgregarBibliotecario(LBibliotecario lbibliotecario)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarBibliotecario", oConexion);
                    Comando.Parameters.AddWithValue("@nombres", lbibliotecario.Nombres);
                    Comando.Parameters.AddWithValue("@apellidos", lbibliotecario.Apellidos);
                    Comando.Parameters.AddWithValue("@direccion", lbibliotecario.Direccion);
                    Comando.Parameters.AddWithValue("@email", lbibliotecario.Email);
                    Comando.Parameters.AddWithValue("@telefono", lbibliotecario.Telefono);
                    Comando.Parameters.AddWithValue("@dni", lbibliotecario.Dni);
                    Comando.Parameters.AddWithValue("@nro_carnet", lbibliotecario.Nro_Carnet);
                    Comando.Parameters.AddWithValue("@contrasena", lbibliotecario.Contrasena);
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

        public static bool ModificarBibliotecario(LBibliotecario lbibliotecario)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarBibliotecario", oConexion);
                    Comando.Parameters.AddWithValue("@codbibliotecario", lbibliotecario.CodBibliotecario);
                    Comando.Parameters.AddWithValue("@nombres", lbibliotecario.Nombres);
                    Comando.Parameters.AddWithValue("@apellidos", lbibliotecario.Apellidos);
                    Comando.Parameters.AddWithValue("@direccion", lbibliotecario.Direccion);
                    Comando.Parameters.AddWithValue("@email", lbibliotecario.Email);
                    Comando.Parameters.AddWithValue("@telefono", lbibliotecario.Telefono);
                    Comando.Parameters.AddWithValue("@dni", lbibliotecario.Dni);
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
 
        public static bool EliminarBibliotecario(LBibliotecario lbibliotecario)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("EliminarBibliotecario", oConexion);
                    Comando.Parameters.AddWithValue("@codbibliotecario", lbibliotecario.CodBibliotecario);

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

