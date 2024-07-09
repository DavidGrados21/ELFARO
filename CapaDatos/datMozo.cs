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
    public class datMozo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMozo _instancia = new datMozo();
        //privado para evitar la instanciación directa
        public static datMozo Instancia
        {
            get
            {
                return datMozo._instancia;
            }
        }
        #endregion singleton

        public List<entMozo> ListarMozo()
        {
            SqlCommand cmd = null;
            List<entMozo> lista = new List<entMozo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMozo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMozo Cli = new entMozo();
                    Cli.dni = Convert.ToInt32(dr["DocumentoMozo"].ToString());
                    Cli.nombre = dr["NombreMozo"].ToString();
                    Cli.fecha = Convert.ToDateTime(dr["FechaDeNacimientoMozo"].ToString());
                    Cli.direccion = dr["DireccionMozo"].ToString();
                    Cli.telefono = Convert.ToInt32(dr["TelefonoMozo"].ToString());
                    Cli.correo = dr["Correo_electronicoMozo"].ToString();
                    Cli.NdeCuenta = dr["NdeCuentaMozo"].ToString();
                    Cli.Hdetrabajo = Convert.ToDecimal(dr["Hdetrabajo"].ToString());
                    Cli.pass = Convert.ToInt32(dr["ContraseñaMozo"]);
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
        public Boolean InsertarMozo(entMozo PL)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMozo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoMozo", PL.dni);
                cmd.Parameters.AddWithValue("@NombreMozo", PL.nombre);
                cmd.Parameters.AddWithValue("@FechaDeNacimientoMozo", PL.fecha);
                cmd.Parameters.AddWithValue("@DireccionMozo", PL.direccion);
                cmd.Parameters.AddWithValue("@TelefonoMozo", PL.telefono);
                cmd.Parameters.AddWithValue("@Correo_electronicoMozo", PL.correo);
                cmd.Parameters.AddWithValue("@NdeCuentaMozo", PL.NdeCuenta);
                cmd.Parameters.AddWithValue("@ContraseñaMozo", PL.pass);
                cmd.Parameters.AddWithValue("@Hdetrabajo", PL.Hdetrabajo);
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
        public Boolean EditarMozo(entMozo PL, string nombre)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMozo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NuevoNombre", nombre);
                cmd.Parameters.AddWithValue("@DocumentoMozo", PL.dni);
                cmd.Parameters.AddWithValue("@NombreMozo", PL.nombre);
                cmd.Parameters.AddWithValue("@FechaDeNacimientoMozo", PL.fecha);
                cmd.Parameters.AddWithValue("@DireccionMozo", PL.direccion);
                cmd.Parameters.AddWithValue("@TelefonoMozo", PL.telefono);
                cmd.Parameters.AddWithValue("@Correo_electronicoMozo", PL.correo);
                cmd.Parameters.AddWithValue("@NdeCuentaMozo", PL.NdeCuenta);
                cmd.Parameters.AddWithValue("@ContraseñaMozo", PL.pass);
                cmd.Parameters.AddWithValue("@Hdetrabajo", PL.Hdetrabajo);
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
        public Boolean EliminarMozo(string nombreMozo)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaMozo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreMozo", nombreMozo);
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
        public string IniciaSesionMozo(int DNI, int pass)
        {
            SqlCommand cmd = null;
            string nombreMozo = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("VerificarMozo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocumentoMozo", DNI);
                cmd.Parameters.AddWithValue("@Contraseña", pass);
                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["Nombre"] != DBNull.Value)
                    {
                        nombreMozo = reader["Nombre"].ToString();
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

        public Boolean verificarAdmin(string usuario, string clave)
        {
            string u = "ADMIN";
            string c = "0000";
            bool v;

            if (usuario != u && clave != c)
            {
                v = false;
            }
            else
            {
                v = true;
            }
            return v;
        }

    }
}
