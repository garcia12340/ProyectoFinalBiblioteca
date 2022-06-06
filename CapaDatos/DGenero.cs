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
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader dr;

        public static List<LGenero> MostrarGenero()
        {
            List<LGenero> rptListaGenero = new List<LGenero>();
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                SqlCommand Comando = new SqlCommand("MostrarGenero", oConexion);
                Comando.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        rptListaGenero.Add(new LGenero()
                        {
                            CodGenero = Convert.ToInt32(dr["Codigo"].ToString()),
                            Genero = dr["genero"].ToString()
                        });
                    }
                    dr.Close();

                    return rptListaGenero;
                }
                catch (Exception ex)
                {
                    rptListaGenero = null;
                    return rptListaGenero;
                }
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
                catch (Exception ex)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }
 
    }
}

