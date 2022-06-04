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
    class DPrestamo
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
            DataTable tabladeuda = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarPrestamoDeudaLecor";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@codlector", lprestamo._CodLector);
            Comando.ExecuteNonQuery();//Pendiente
            LeerFilas = Comando.ExecuteReader();
            tabladeuda.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabladeuda;
        }

        public bool AgregarPrestamo(LPrestamo lprestamo)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarPrestamo";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codlector", lprestamo._CodLector);
                Comando.Parameters.AddWithValue("@codlibro", lprestamo._CodLibro);
                Comando.Parameters.AddWithValue("@fec_devolucion", lprestamo._Fec_Devolucion);
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

        public bool ModificarLibro(LPrestamo lprestamo)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ModificarPrestamoRetorno";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codprestamo", lprestamo._CodPrestamo);
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

