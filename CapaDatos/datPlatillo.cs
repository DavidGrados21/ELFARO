using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    Cli.NombrePlatillo = dr["NombreDelPlatillo"].ToString();
                    Cli.Precio = Convert.ToDouble(dr["PrecioDelPlatillo"]);;
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

    }
}