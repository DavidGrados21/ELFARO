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
    public class datNotaIngreso
    {

        #region singleton
        private static readonly datNotaIngreso _instancia = new datNotaIngreso();
        public static datNotaIngreso Instancia
        {
            get { return datNotaIngreso._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entNotaIngreso> ListarNotaIngreso()
        {
            SqlCommand cmd = null;
            List<entNotaIngreso> lista = new List<entNotaIngreso>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entNotaIngreso Not = new entNotaIngreso();
                    
                    entProveedor Prv = new entProveedor();

                    Not.idNotaIngreso = Convert.ToInt32(dr["IdNotaIngreso"]);
                    Not.estNotaIngreso = Convert.ToBoolean(dr["estNotaIngreso"]);
                    Not.fechNotaIngreso = Convert.ToDateTime(dr["FechNotaIngreso"]);  
                    Prv.Codigo = Convert.ToInt32(dr["idProveedor"]);
                    Prv.RazonSocial = dr["RazonSocial"].ToString();
                    Not.idProveedor = Prv;
                    Not.TotNotaIngreso = Convert.ToDouble(dr["TotNotaIngreso"]);
                    lista.Add(Not);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }


        public int InsertarNotaIngreso(entNotaIngreso Not)
        {

            SqlCommand cmd = null;
            int idPed = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idProveedor", Not.idProveedor.Codigo);
                cmd.Parameters.AddWithValue("@fechNotaIngreso", Not.fechNotaIngreso);
                cmd.Parameters.AddWithValue("@TotNotaIngreso", Not.TotNotaIngreso);
                cmd.Parameters.AddWithValue("@estNotaIngreso ", Not.estNotaIngreso);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idPed = Convert.ToInt16(cmd.Parameters["@retorno"].Value);
                return idPed;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

        }
        public Boolean InsertarDetalleNotaIngreso(entDetalleNotaDeIngreso dNota)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarDetalleNotaIngreso", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idNotaIngreso", dNota.idNotaIngreso);
                cmd.Parameters.AddWithValue("@idInsumo", dNota.idInsumo.idInsumo);
                cmd.Parameters.AddWithValue("@cantInsumos", dNota.cantInsumos);
                cmd.Parameters.AddWithValue("@precInsumo", dNota.precInsumo);  ;
                

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        #endregion metodos

     }

}

