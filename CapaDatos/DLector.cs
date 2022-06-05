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
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader dr;

        public static List<LLector> MostrarLector()
        {
            List<LLector> mostrar = new List<LLector>();
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                SqlCommand Comando = new SqlCommand("MostrarLectores", oConexion);
                Comando.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        mostrar.Add(new LLector()
                        {

                            CodLector = Convert.ToInt32(dr["CodLector"].ToString()),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Email = dr["Email"].ToString(),
                            Telefono = Convert.ToInt32(dr["Telefono"].ToString())
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
            DataTable tablalector = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerificarLector";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@codlector", LLector.CodLector);
            Comando.ExecuteNonQuery();//Pendiente
            LeerFilas = Comando.ExecuteReader();
            tablalector.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablalector;
        }

        public bool AgregarGeneroLector(LLector llector)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarLector";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@nombres", llector.Nombres);
                Comando.Parameters.AddWithValue("@apellidos", llector.Apellidos);
                Comando.Parameters.AddWithValue("@direccion", llector.Direccion);
                Comando.Parameters.AddWithValue("@email", llector.Email);
                Comando.Parameters.AddWithValue("@telefono", llector.Telefono);
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

        public bool ModificarLector(LLector llector)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ModificarLector";
                Comando.Parameters.AddWithValue("@codlector", llector.CodLector);
                Comando.Parameters.AddWithValue("@nombres", llector.Nombres);
                Comando.Parameters.AddWithValue("@apellidos", llector.Apellidos);
                Comando.Parameters.AddWithValue("@direccion", llector.Direccion);
                Comando.Parameters.AddWithValue("@email", llector.Email);
                Comando.Parameters.AddWithValue("@telefono", llector.Telefono);
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

        public bool EliminarLector(LLector llector)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "EliminarLector";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codlector", llector.CodLector);
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

