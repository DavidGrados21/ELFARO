using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.NumeroDeDni = Convert.ToInt32(dr["DocumentoCliente"].ToString());
                    Cli.Nombre = dr["NombreCliente"].ToString();
                    Cli.CorreoElectronico = dr["CorreoElectronicoCliente"].ToString();
                    Cli.Telefono = Convert.ToInt32(dr["TelefonoCliente"].ToString());
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean InsertarCliente(entCliente CL)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoCliente", CL.NumeroDeDni);
                cmd.Parameters.AddWithValue("@NombreCliente", CL.Nombre);
                cmd.Parameters.AddWithValue("@CorreoElectronicoCliente", CL.CorreoElectronico);
                cmd.Parameters.AddWithValue("@TelefonoCliente", CL.Telefono);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }
        public Boolean EditarCliente(entCliente CL, string nombre)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NuevoNombre", nombre);
                cmd.Parameters.AddWithValue("@DocumentoCliente", CL.NumeroDeDni);
                cmd.Parameters.AddWithValue("@NombreCliente", CL.Nombre);
                cmd.Parameters.AddWithValue("@CorreoElectronicoCliente", CL.CorreoElectronico);
                cmd.Parameters.AddWithValue("@TelefonoCliente", CL.Telefono);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean EliminarCliente(string nombreCliente)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminacliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;

        }
        public string ConsultarCliente(int DNI)
        {
            SqlCommand cmd = null;
            string nombreMozo = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ConsultaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoCliente", DNI);
                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["NombreCliente"] != DBNull.Value)
                    {
                        nombreMozo = reader["NombreCliente"].ToString();
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return nombreMozo;
        }
        public bool VerificarDNI(int DNI)
        {
            SqlCommand cmd = null;
            bool existe = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("VerificarDni", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoCliente", DNI);

                SqlParameter outputParam = new SqlParameter("@Existe", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cn.Open();
                cmd.ExecuteNonQuery();

                existe = (bool)cmd.Parameters["@Existe"].Value;
            }
            catch (Exception e)
            {
                // Manejo de excepciones
                throw new Exception("Error al verificar DNI", e);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return existe;
        }
    }
}
