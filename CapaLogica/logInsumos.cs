using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logInsumos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logInsumos _instancia = new logInsumos();
        //privado para evitar la instanciación directa
        public static logInsumos Instancia
        {
            get
            {
                return logInsumos._instancia;
            }
        }
        #endregion singleton

        ///listado
        public List<entInsumos> ListarInsumosCL()
        {
            return datInsumos.Instancia.ListarInsumos();
        }

        ///inserta
        public void InsertaInsumosCL(entInsumos Cli, string UM)
        {
            datInsumos.Instancia.InsertarInsumos(Cli, UM);
        }

        public void DeshabilitarCliente(string Cli)
        {
            datInsumos.Instancia.EliminarInsumo(Cli);
        }
    }
}
