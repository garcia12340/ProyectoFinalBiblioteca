using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CapaDatos
{
    public class DUsuario
    {
        // private DConexion dconexion = new DConexion();
        public static int LoginUsuario(string Usuario, string Clave)
        {
            int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("LoginUsuario", oConexion);
                    cmd.Parameters.AddWithValue("Usuario", Usuario);
                    cmd.Parameters.AddWithValue("Clave", Clave);
                    cmd.Parameters.Add("IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToInt32(cmd.Parameters["IdUsuario"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                }

            }

            return respuesta;

        }



        public static List<LUsuario> ObtenerUsuarios()
        {
            List<LUsuario> rptListaUsuario = new List<LUsuario>();
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ObtenerUsuario", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rptListaUsuario.Add(new LUsuario()
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString()),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            LoginUsuario = dr["LoginUsuario"].ToString(),
                            Clave = dr["LoginClave"].ToString(),
                            IdRol = Convert.ToInt32(dr["IdRol"].ToString()),
                            oRol = new LRol() { Descripcion = dr["DescripcionRol"].ToString() },
                            Activo = Convert.ToBoolean(dr["Activo"]),
                            DescripcionReferencia = dr["DescripcionReferencia"].ToString()
                        });
                    }
                    dr.Close();

                    return rptListaUsuario;

                }
                catch (Exception ex)
                {
                    rptListaUsuario = null;
                    return rptListaUsuario;
                }
            }
        }


        public static bool RegistrarUsuario(LUsuario oUsuario)
        {

            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("RegistrarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("Nombres", oUsuario.Nombres);
                    cmd.Parameters.AddWithValue("Apellidos", oUsuario.Apellidos);
                    cmd.Parameters.AddWithValue("IdRol", oUsuario.IdRol);
                    cmd.Parameters.AddWithValue("Usuario", oUsuario.LoginUsuario);
                    cmd.Parameters.AddWithValue("Clave", oUsuario.Clave);
                    cmd.Parameters.AddWithValue("DescripcionReferencia", oUsuario.DescripcionReferencia);
                    cmd.Parameters.AddWithValue("IdReferencia", oUsuario.IdReferencia);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public static bool ModificarUsuario(LUsuario oUsuario)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ModificarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("Nombres", oUsuario.Nombres);
                    cmd.Parameters.AddWithValue("Apellidos", oUsuario.Apellidos);
                    cmd.Parameters.AddWithValue("IdRol", oUsuario.IdRol);
                    cmd.Parameters.AddWithValue("Usuario", oUsuario.LoginUsuario);
                    cmd.Parameters.AddWithValue("Clave", oUsuario.Clave);
                    cmd.Parameters.AddWithValue("DescripcionReferencia", oUsuario.DescripcionReferencia);
                    cmd.Parameters.AddWithValue("IdReferencia", oUsuario.IdReferencia);
                    cmd.Parameters.AddWithValue("Activo", oUsuario.Activo);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;

        }

        public static bool EliminarUsuario(int IdUsuario)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EliminarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", IdUsuario);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public static LUsuario ObtenerDetalleUsuario(int IdUsuario)
        {
            LUsuario rptUsuario = new LUsuario();
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ObtenerDetalleUsuario", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                try
                {
                    oConexion.Open();
                    using (XmlReader dr = cmd.ExecuteXmlReader())
                    {
                        while (dr.Read())
                        {
                            XDocument doc = XDocument.Load(dr);
                            if (doc.Element("Usuario") != null)
                            {
                                rptUsuario = (from dato in doc.Elements("Usuario")
                                              select new LUsuario()
                                              {
                                                  IdUsuario = int.Parse(dato.Element("IdUsuario").Value),
                                                  Nombres = dato.Element("Nombres").Value,
                                                  Apellidos = dato.Element("Apellidos").Value,
                                                  DescripcionReferencia = dato.Element("DescripcionReferencia").Value,
                                                  IdReferencia = int.Parse(dato.Element("IdReferencia").Value)

                                              }).FirstOrDefault();
                                rptUsuario.oRol = doc.Element("Usuario").Elements("DetalleRol") == null ? new LRol() : (from dato in doc.Element("Usuario").Elements("DetalleRol")
                                                                                                                       select new LRol()
                                                                                                                       {
                                                                                                                           Descripcion = dato.Element("Descripcion").Value
                                                                                                                       }).FirstOrDefault();
                                rptUsuario.oListaMenu = doc.Element("Usuario").Element("DetalleMenu") == null ? new List<LMenu>() : (from menu in doc.Element("Usuario").Element("DetalleMenu").Elements("Menu")
                                                                                                                                    select new LMenu()
                                                                                                                                    {
                                                                                                                                        Nombre = menu.Element("NombreMenu").Value,
                                                                                                                                        Icono = menu.Element("Icono").Value,
                                                                                                                                        oSubMenu = (from submenu in menu.Element("DetalleSubMenu").Elements("SubMenu")
                                                                                                                                                    select new LSubMenu()
                                                                                                                                                    {
                                                                                                                                                        Nombre = submenu.Element("NombreSubMenu").Value,
                                                                                                                                                        NombreFormulario = submenu.Element("NombreFormulario").Value,
                                                                                                                                                        Activo = (submenu.Element("Activo").Value.ToString() == "1" ? true : false),

                                                                                                                                                    }).ToList()

                                                                                                                                    }).ToList();
                            }
                            else
                            {
                                rptUsuario = null;
                            }
                        }

                        dr.Close();

                    }

                    return rptUsuario;
                }
                catch (Exception ex)
                {
                    rptUsuario = null;
                    return rptUsuario;
                }
            }
        }
    }
}


