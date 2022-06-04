﻿using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class DAutor
    {
        public static List<LAutor> MostrarAutor()
        {
            List<LAutor> rptListaAlumno = new List<LAutor>();
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                SqlCommand Comando = new SqlCommand("MostrarAutor", oConexion);
                Comando.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        rptListaAlumno.Add(new LAutor()
                        {
                            Autor = dr["autor"].ToString(),
                            CodAutor = Convert.ToInt32(dr["Codigo"].ToString())
                        });
                    }
                    dr.Close();

                    return rptListaAlumno;
                }
                catch (Exception ex)
                {
                    rptListaAlumno = null;
                    return rptListaAlumno;
                }
            }
        }

        public static bool AgregarAutor(LAutor lautor)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarAutor", oConexion);
                    Comando.Parameters.AddWithValue("@autor", lautor.Autor);
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

        public static bool ModificarAutor(LAutor lautor)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarAutor", oConexion);
                    Comando.Parameters.AddWithValue("@codautor", lautor._CodAutor);
                    Comando.Parameters.AddWithValue("@autor", lautor._Autor);
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

        public static bool EliminarAutor(int CodAutor)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("EliminarAutor", oConexion);
                    Comando.Parameters.AddWithValue("@codautor", CodAutor);
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
