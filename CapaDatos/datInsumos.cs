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

        
        public List<entInsumo> ListarInsumos()
        {
            SqlCommand cmd = null;
            List<entInsumo> lista = new List<entInsumo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInsumo insumo = new entInsumo();
                    insumo.idInsumo = Convert.ToInt32(dr["IdInsumo"].ToString());
                    insumo.NombreInsumos = dr["NombreInsumo"].ToString();
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


        public Boolean InsertarInsumos(entInsumo Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreInsumo", Cli.NombreInsumos);
                cmd.Parameters.AddWithValue("@UnidadMedida", Cli.UM);
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
       

        public entInsumo BuscarInsumoId(int idInsumo)
        {
            SqlCommand cmd = null;
            entInsumo ins = new entInsumo();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaridInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdInsumo", idInsumo);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ins.idInsumo = Convert.ToInt32(dr["IdInsumo"].ToString());
                    ins.NombreInsumos = dr["NombreInsumo"].ToString();
                    ins.UM = dr["UnidadMedida"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return ins;
        }
    }
}
