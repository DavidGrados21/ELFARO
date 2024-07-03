using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

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
        public Boolean InsertarPedido(entPedido PL)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombrePlatillo", PL.NombrePlatillo);
                cmd.Parameters.AddWithValue("@Nmesa", PL.Mesa);
                cmd.Parameters.AddWithValue("@Precio", PL.Precio);
                cmd.Parameters.AddWithValue("@NumeroDeDni", PL.NumeroDeDni);
                cmd.Parameters.AddWithValue("@FechaCreacion",PL.HoraCreacion);
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
                cmd = new SqlCommand("PedidoVistaMozo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Cli = new entPedido();
                    Cli.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    Cli.Precio = Convert.ToInt32(dr["Precio"]);
                    Cli.HoraCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
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
                cmd = new SqlCommand("PedidoVistaMozo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Cli = new entPedido();
                    Cli.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    Cli.Mesa = Convert.ToInt32(dr["Nmesa"]);
                    Cli.NumeroDeDni = Convert.ToInt32(dr["NumeroDeDni"]);
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
        public decimal Subtotal(int mesa)
        {
            SqlCommand cmd = null;
            decimal total = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("CalcularTotal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroMesa", mesa);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    total = dr.GetDecimal(dr.GetOrdinal("TotalPrecio"));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return total;
        }
        public int GeneraDNI(int numeroMesa)
        {
            SqlCommand cmd = null;
            int DNI = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("GeneraDniCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroMesa", numeroMesa); 
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DNI = int.Parse(dr["NumeroDeDni"].ToString());
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return DNI;
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
                    Cli.Precio = Convert.ToDecimal(dr["Precio"]);
                    Cli.NumeroDeDni= Convert.ToInt32(dr["NumeroDeDni"]);
                    Cli.HoraCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
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
        public List<entPedidoBoleta> DatosBoleta(int numeroDeDni)
        {
            SqlCommand cmd = null;
            List<entPedidoBoleta> pedidos = new List<entPedidoBoleta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("DatosBoleta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroDeDni", numeroDeDni);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedidoBoleta pedido = new entPedidoBoleta();
                    pedido.Cant = Convert.ToInt32(dr["Cant"]);
                    pedido.Cod = dr["Cod"].ToString();
                    pedido.Precio = Convert.ToDecimal(dr["Precio"]);
                    pedido.Platillo = dr["Platillo"].ToString();
                    pedidos.Add(pedido);
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
            return pedidos;
        }


    }
}
