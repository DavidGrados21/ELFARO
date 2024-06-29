using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class datPlatillo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPlatillo _instancia = new datPlatillo();
        //privado para evitar la instanciación directa
        public static datPlatillo Instancia
        {
            get
            {
                return datPlatillo._instancia;
            }
        }
        #endregion singleton

        ////////////////////listado de Clientes
        public List<entPlatillo> ListarPlatillo()
        {
            SqlCommand cmd = null;
            List<entPlatillo> lista = new List<entPlatillo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlatillo Cli = new entPlatillo();
                    Cli.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    Cli.Precio = Convert.ToDecimal(dr["Precio"]);
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
        public void LoadPlatillos(ComboBox comboBox)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open(); // Abre la conexión antes de ejecutar el comando

                    using (SqlCommand cmd = new SqlCommand("SELECT NombrePlatillo FROM Platillo", cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader["NombrePlatillo"].ToString());
                            }
                        }
                    }

                    cn.Close(); // Cierra la conexión después de usarla
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public Boolean InsertarPlatillo(entPlatillo PL)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombrePlatillo", PL.NombrePlatillo);
                cmd.Parameters.AddWithValue("@Precio", PL.Precio);
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
        public Boolean EliminarPlatillo(string nombrePlatillo)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombrePlatillo", nombrePlatillo);
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
        
        public Boolean EditarPlatillo(entPlatillo Cli, string nombre)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
        try
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("spEditaPlatillo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombrePlatillo", Cli.NombrePlatillo);
            cmd.Parameters.AddWithValue("@NuevoNombrePlatillo", nombre);
            cmd.Parameters.AddWithValue("@Precio ", Cli.Precio);
        
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
        public decimal ObtenerPrecio(string nombrePlatillo)
        {
            decimal precio = 0;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("spObtenerPrecioPlatillo", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro @p_nombre_platillo y asignarle el valor
                    cmd.Parameters.AddWithValue("@p_nombre_platillo", nombrePlatillo);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read() && dr["PrecioDelPlatillo"] != DBNull.Value)
                        {
                            precio = Convert.ToDecimal(dr["PrecioDelPlatillo"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el precio del platillo", e);
            }

            return precio;
        }
 
    }
}
