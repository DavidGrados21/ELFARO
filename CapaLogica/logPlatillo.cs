using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapaLogica
{
    public class logPlatillo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPlatillo _instancia = new logPlatillo();
        //privado para evitar la instanciación directa
        public static logPlatillo Instancia
        {
            get
            {
                return logPlatillo._instancia;
            }
        }
        #endregion singleton

        ///listado

        public List<entPlatillo> ListarPlatillo()
        {
            return datPlatillo.Instancia.ListarPlatillo();
        }
        public void MostrarPlatillo(ComboBox CB)
        {
           datPlatillo.Instancia.LoadPlatillos(CB);
        }
        public List<entPlatillo> MostrarPedido()
        {
            return datPlatillo.Instancia.ListarPedido();
        }
        public void InsertarPlatillo(entPlatillo p)
        {
            datPlatillo.Instancia.InsertarPlatillo(p);
        }
        public void InsertarPedido(entPlatillo p, int yu)
        {
            datPlatillo.Instancia.InsertarPedido(p,yu);
        }

        public void EliminarPlatillo(string n )
        {
            datPlatillo.Instancia.EliminarPlatillo(n);
        }

        public void EditarPlatillo(entPlatillo PL, string nombre)
        {
            datPlatillo.Instancia.EditarPlatillo(PL, nombre);
        }
        public decimal Obtenerprecio (string nombre)
        {
            decimal p = datPlatillo.Instancia.ObtenerPrecio(nombre);
            return p;
        }
    }
}
