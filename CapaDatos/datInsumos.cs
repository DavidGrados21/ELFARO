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
    public class datInsumos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datInsumos _instancia = new datInsumos();
        //privado para evitar la instanciación directa
        public static datInsumos Instancia
        {
            get
            {
                return datInsumos._instancia;
            }
        }
        #endregion singleton

        ////////////////////listado de Clientes
        public List<entInsumos> ListarInsumos()
        {
            SqlCommand cmd = null;
            List<entInsumos> lista = new List<entInsumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaInsumos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInsumos insumo = new entInsumos();
                    insumo.NombreInsumos = dr["NombreInsumo"].ToString();
                    insumo.Cantidad = Convert.ToDouble(dr["CantidadInsumo"]);
                    insumo.UM = dr["UnidadMedida"].ToString(); 
                    lista.Add(insumo);
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
            return lista;
        }

        /////////////////////////InsertaCliente
        public Boolean InsertarInsumos(entInsumos Cli, string UM)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreInsumo", Cli.NombreInsumos);
                cmd.Parameters.AddWithValue("@CantidadInsumo", Cli.Cantidad);
                cmd.Parameters.AddWithValue("@UnidadMedida", UM);
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
        public Boolean EliminarInsumo(string nombreInsumo)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreInsumo", nombreInsumo);
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
