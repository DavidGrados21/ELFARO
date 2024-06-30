using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class datProveedor
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        ////////////////////listado de Clientes
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try { 
            
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Pro = new entProveedor();
                    Pro.Codigo = Convert.ToInt32(dr["Codigo"].ToString());
                    Pro.RazonSocial = dr["RazonSocial"].ToString();
                    Pro.Ruc = Convert.ToInt32(dr["Ruc"].ToString());
                    Pro.Rubro = dr["Rubro"].ToString();
                    Pro.Direccion = dr["Direccion"].ToString();
                    Pro.Telefono = Convert.ToInt32(dr["Telefono"].ToString());
                    lista.Add(Pro);
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

        public Boolean InsertaProveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection p = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProveedor", p);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RazonSocial", Prov.RazonSocial);
                cmd.Parameters.AddWithValue("@Ruc", Prov.Ruc);
                cmd.Parameters.AddWithValue("@Rubro", Prov.Rubro);
                cmd.Parameters.AddWithValue("@Direccion", Prov.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Prov.Telefono);
                
                p.Open();
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

        //////////////////////////////////EditaCliente
        public Boolean EditarProveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Prov.Codigo);
                cmd.Parameters.AddWithValue("@RazonSocial", Prov.RazonSocial);
                cmd.Parameters.AddWithValue("@Ruc", Prov.Ruc);
                cmd.Parameters.AddWithValue("@Rubro", Prov.Rubro);
                cmd.Parameters.AddWithValue("@Direccion", Prov.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Prov.Telefono);
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

        public Boolean DeshabilitarProveedor(entProveedor Prov)
            {
                SqlCommand cmd = null;
                Boolean delete = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spDeshabilitaProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", Prov.Codigo);
   
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

        }




    

}
