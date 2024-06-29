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
    public class datPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPedido _instancia = new datPedido();
        //privado para evitar la instanciación directa
        public static datPedido Instancia
        {
            get
            {
                return datPedido._instancia;
            }
        }
        #endregion singleton
        public Boolean InsertarPedido(entPlatillo PL, int M)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombrePlatillo", PL.NombrePlatillo);
                cmd.Parameters.AddWithValue("@Nmesa", M);
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
        public List<entPedido> ListarPedidoM()
        {
            SqlCommand cmd = null;
            List<entPedido> Pedido = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarNombrePrecioPlatillos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Cli = new entPedido();
                    Cli.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    Cli.Precio = Convert.ToInt32(dr["Precio"]);
                    Pedido.Add(Cli);
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
            return Pedido;
        }

        public List<entPedido> ListarPedidoC()
        {
            SqlCommand cmd = null;
            List<entPedido> Pedido = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarNombreMesaPlatillos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Cli = new entPedido();
                    Cli.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    Cli.Mesa = Convert.ToInt32(dr["Nmesa"]);
                    Pedido.Add(Cli);
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
            return Pedido;
        }
        public List<entPedido> FiltrarPedidosPorMesa(int m)
        {
            SqlCommand cmd = null;
            List<entPedido> Pedido = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("FiltrarPorMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroMesa", m);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Cli = new entPedido();
                    Cli.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    Cli.Mesa = Convert.ToInt32(dr["Nmesa"]);
                    Pedido.Add(Cli);
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
            return Pedido;
        }
        public List<entPedido> FiltrarPedidosPorNombre(string nombre)
        {
            SqlCommand cmd = null;
            List<entPedido> Pedido = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("FiltrarPorPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nmesa", nombre);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Cli = new entPedido();
                    Cli.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    Cli.Mesa = Convert.ToInt32(dr["Nmesa"]);
                    Pedido.Add(Cli);
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
            return Pedido;
        }

    }
}
