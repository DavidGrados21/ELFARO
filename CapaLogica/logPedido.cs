﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPedido _instancia = new logPedido();
        //privado para evitar la instanciación directa
        public static logPedido Instancia
        {
            get
            {
                return logPedido._instancia;
            }
        }
        #endregion singleton
        public List<entPedido> ListasPedidoM()
        {
            return datPedido.Instancia.ListarPedidoM();
        }
        public List<entPedido> ListasPedidoC()
        {
            return datPedido.Instancia.ListarPedidoC();
        }
        public List<entPedido> FiltrarporMesa(int m)
        {
            return datPedido.Instancia.FiltrarPedidosPorMesa(m);
        }
        public List<entPedido> FiltrarporPlatillo(string p)
        {
            return datPedido.Instancia.FiltrarPedidosPorNombre(p);
        }
        public void InsertarPedido(entPlatillo p, int yu)
        {
            datPedido.Instancia.InsertarPedido(p, yu);
        }

    }
}
