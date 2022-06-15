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
    public class DPrestamo
    {
        private DConexion Conexion = new DConexion();
        public DataTable MostrarPrestamo()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarPrestamo", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablaprestamo = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablaprestamo);
                return tablaprestamo;
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

        public DataTable MostrarPrestamoCancelado()
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarPrestamoDevueltos", Conexion.AbrirConexion());
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();
                DataTable tablaprestamo = new DataTable();


                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tablaprestamo);
                return tablaprestamo;
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

        public DataTable MostrarPrestamoDeuda(LPrestamo lprestamo)
        {
            try
            {
                SqlCommand Comando = new SqlCommand("MostrarPrestamoDeudaLecor", Conexion.AbrirConexion());
                Comando.Parameters.AddWithValue("@codlector", lprestamo.CodLector);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.ExecuteNonQuery();

                DataTable tabladeuda = new DataTable();
                SqlDataAdapter adaptar = new SqlDataAdapter(Comando);
                adaptar.Fill(tabladeuda);
                return tabladeuda;
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

        public static bool AgregarPrestamo(LPrestamo lprestamo)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("AgregarPrestamo", oConexion);
                    Comando.Parameters.AddWithValue("@codlector", lprestamo.CodLector);
                    Comando.Parameters.AddWithValue("@codlibro", lprestamo.CodLibro);
                    Comando.Parameters.AddWithValue("@fec_devolucion", lprestamo.Fec_Devolucion);
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

        public static bool ModificarLibro(LPrestamo lprestamo)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarPrestamoRetorno", oConexion);
                    Comando.Parameters.AddWithValue("@codprestamo", lprestamo.CodPrestamo);
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

    }

}

