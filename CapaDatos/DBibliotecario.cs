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

        public static bool /*int otra opcion*/AccederBibliotecario(LBibliotecario lbibliotecario)
        {
            bool respuesta = true;
            //int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AccederBibliotecario", oConexion);
                    Comando.Parameters.AddWithValue("@user", lbibliotecario._Nro_Carnet);
                    Comando.Parameters.AddWithValue("@clave", lbibliotecario._Contrasena);
                    Comando.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    Comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    //respuesta = 0;
                    respuesta = false;
                }

            }

            return respuesta;
        }
        //public bool AccederBibliotecario(LBibliotecario lbibliotecario)
        //{
        //    try
        //    {
        //        Comando.Connection = Conexion.AbrirConexion();
        //        Comando.CommandText = "AccederBibliotecario";
        //        //SqlCommand cmd = new SqlCommand("AccederBibliotecario");
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.Parameters.AddWithValue("@user", lbibliotecario._Nro_Carnet);
        //        Comando.Parameters.AddWithValue("@clave", lbibliotecario._Contrasena);
        //        Comando.ExecuteNonQuery();
        //        dr = Comando.ExecuteReader();

        //        if (dr.HasRows)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        Conexion.CerrarConexion();
        //    }
        //}

        public static List<LBibliotecario> GenerarCarnet()
        {
            List<LBibliotecario> generarCarnet = new List<LBibliotecario>();
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                SqlCommand Comando = new SqlCommand("NroCarnetBibliotecario", oConexion);
                Comando.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        generarCarnet.Add(new LBibliotecario()
                        {
                            Nombres = dr["bibliotecario"].ToString(),//antiguocarnet
                            Nro_Carnet = dr["Nro_Carnet"].ToString()
                        });
                    }
                    dr.Close();

                    return generarCarnet;
                }
                catch (Exception ex)
                {
                    generarCarnet = null;
                    return generarCarnet;
                }
            }
        }
            //public DataTable GenerarCarnet() 
            //{
            //  DataTable tablagenerada = new DataTable();
            //  Comando.Connection = Conexion.AbrirConexion();
            //  Comando.CommandText = "NroCarnetBibliotecario";
            //  Comando.CommandType = CommandType.StoredProcedure;
            //  LeerFilas = Comando.ExecuteReader();
            //  tablagenerada.Load(LeerFilas);
            //  LeerFilas.Close();
            //  Conexion.CerrarConexion();
            // return tablagenerada;

            //}

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
                            Nro_Carnet = dr["Nro_Carnet"].ToString()
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

        //public DataTable MostrarBibliotecarios()
        //{
        //    DataTable tablabibliotecarios = new DataTable();
        //    Comando.Connection = Conexion.AbrirConexion();
        //    Comando.CommandText = "MostrarBibliotecarios";
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    LeerFilas = Comando.ExecuteReader();
        //    tablabibliotecarios.Load(LeerFilas);
        //    LeerFilas.Close();
        //    Conexion.CerrarConexion();
        //    return tablabibliotecarios;
        //}

        public static bool AgregarBibliotecario(LBibliotecario lbibliotecario)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarBibliotecario", oConexion);
                    Comando.Parameters.AddWithValue("@nombres", lbibliotecario._Nombres);
                    Comando.Parameters.AddWithValue("@apellidos", lbibliotecario._Apellidos);
                    Comando.Parameters.AddWithValue("@direccion", lbibliotecario._Direccion);
                    Comando.Parameters.AddWithValue("@email", lbibliotecario._Email);
                    Comando.Parameters.AddWithValue("@telefono", lbibliotecario._Telefono);
                    Comando.Parameters.AddWithValue("@dni", lbibliotecario._Dni);
                    Comando.Parameters.AddWithValue("@nro_carnet", lbibliotecario._Nro_Carnet);
                    Comando.Parameters.AddWithValue("@contrasena", lbibliotecario._Contrasena);
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
        //public bool AgregarBibliotecario(LBibliotecario lbibliotecario)
        //{
        //    try
        //    {
        //        Comando.Connection = Conexion.AbrirConexion();
        //        Comando.CommandText = "AgregarBibliotecario";
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.Parameters.AddWithValue("@nombres", lbibliotecario._Nombres);
        //        Comando.Parameters.AddWithValue("@apellidos", lbibliotecario._Apellidos);
        //        Comando.Parameters.AddWithValue("@direccion", lbibliotecario._Direccion);
        //        Comando.Parameters.AddWithValue("@email", lbibliotecario._Email);
        //        Comando.Parameters.AddWithValue("@telefono", lbibliotecario._Telefono);
        //        Comando.Parameters.AddWithValue("@dni", lbibliotecario._Dni);
        //        Comando.Parameters.AddWithValue("@nro_carnet", lbibliotecario._Nro_Carnet);
        //        Comando.Parameters.AddWithValue("@contrasena", lbibliotecario._Contrasena);
        //        Comando.ExecuteNonQuery();
        //        dr = Comando.ExecuteReader();

        //        if (dr.HasRows)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        Conexion.CerrarConexion();
        //    }

        //}
        public static bool ModificarBibliotecario(LBibliotecario lbibliotecario)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarBibliotecario", oConexion);
                    Comando.Parameters.AddWithValue("@codbibliotecario", lbibliotecario._CodBibliotecario);
                    Comando.Parameters.AddWithValue("@nombres", lbibliotecario._Nombres);
                    Comando.Parameters.AddWithValue("@apellidos", lbibliotecario._Apellidos);
                    Comando.Parameters.AddWithValue("@direccion", lbibliotecario._Direccion);
                    Comando.Parameters.AddWithValue("@email", lbibliotecario._Email);
                    Comando.Parameters.AddWithValue("@telefono", lbibliotecario._Telefono);
                    Comando.Parameters.AddWithValue("@dni", lbibliotecario._Dni);
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
        //public bool ModificarBibliotecario(LBibliotecario lbibliotecario)
        //{
        //    try
        //    {
        //        Comando.Connection = Conexion.AbrirConexion();
        //        Comando.CommandText = "ModificarBibliotecario";
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.Parameters.AddWithValue("@codbibliotecario", lbibliotecario._CodBibliotecario);
        //        Comando.Parameters.AddWithValue("@nombres", lbibliotecario._Nombres);
        //        Comando.Parameters.AddWithValue("@apellidos", lbibliotecario._Apellidos);
        //        Comando.Parameters.AddWithValue("@direccion", lbibliotecario._Direccion);
        //        Comando.Parameters.AddWithValue("@email", lbibliotecario._Email);
        //        Comando.Parameters.AddWithValue("@telefono", lbibliotecario._Telefono);
        //        Comando.Parameters.AddWithValue("@dni", lbibliotecario._Dni);
        //        Comando.ExecuteNonQuery();
        //        dr = Comando.ExecuteReader();

        //        if (dr.HasRows)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        Conexion.CerrarConexion();
        //    }
        //}

        public static bool EliminarBibliotecario(LBibliotecario lbibliotecario)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("EliminarBibliotecario", oConexion);
                    Comando.Parameters.AddWithValue("@codbibliotecario", lbibliotecario._CodBibliotecario);

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

