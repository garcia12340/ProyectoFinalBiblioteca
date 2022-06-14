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
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader dr;
        public DataTable MostrarPrestamo()
        {
            DataTable tablaprestamo = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarPrestamo";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tablaprestamo.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablaprestamo;
        }

        public DataTable MostrarPrestamoCancelado()
        {
            DataTable tablaprestamo = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarPrestamoDevueltos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tablaprestamo.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablaprestamo;
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

        public bool AgregarPrestamo(LPrestamo lprestamo)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarPrestamo";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codlector", lprestamo.CodLector);
                Comando.Parameters.AddWithValue("@codlibro", lprestamo.CodLibro);
                Comando.Parameters.AddWithValue("@fec_devolucion", lprestamo.Fec_Devolucion);
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

        public static bool ModificarLibro(LPrestamo lprestamo)
        {
            bool res = true;
            using (SqlConnection oConexion = new SqlConnection(DConexion.CadenaConexion))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("ModificarAutor", oConexion);
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
            //public bool ModificarLibro(LPrestamo lprestamo)
            //{
            //    try
            //    {
            //        Comando.Connection = Conexion.AbrirConexion();
            //        Comando.CommandText = "ModificarPrestamoRetorno";
            //        Comando.CommandType = CommandType.StoredProcedure;
            //        
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

    }

}

