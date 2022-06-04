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
    class DLector
    {
        private DConexion Conexion = new DConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader dr;

        public DataTable MostrarLector()
        {
            DataTable tablalector = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarLectores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tablalector.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tablalector;
        }

        public DataTable VerificarLector(LLector LLector)
        {
            DataTable tablalector = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerificarLector";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@codlector", LLector._CodLector);
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
                Comando.Parameters.AddWithValue("@nombres", llector._Nombres);
                Comando.Parameters.AddWithValue("@apellidos", llector._Apellidos);
                Comando.Parameters.AddWithValue("@direccion", llector._Direccion);
                Comando.Parameters.AddWithValue("@email", llector._Email);
                Comando.Parameters.AddWithValue("@telefono", llector._Telefono);
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
                Comando.Parameters.AddWithValue("@codlector", llector._CodLector);
                Comando.Parameters.AddWithValue("@nombres", llector._Nombres);
                Comando.Parameters.AddWithValue("@apellidos", llector._Apellidos);
                Comando.Parameters.AddWithValue("@direccion", llector._Direccion);
                Comando.Parameters.AddWithValue("@email", llector._Email);
                Comando.Parameters.AddWithValue("@telefono", llector._Telefono);
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
                Comando.Parameters.AddWithValue("@codlector", llector._CodLector);
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

