using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logInsumo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logInsumo _instancia = new logInsumo();
        //privado para evitar la instanciación directa
        public static logInsumo Instancia
        {
            get
            {
                return logInsumo._instancia;
            }
        }
        #endregion singleton

        public List<entInsumo> ListarInsumosCL()
        {
            return datInsumos.Instancia.ListarInsumos();
        }

        ///inserta
        public void InsertaInsumosCL(entInsumo Cli)
        {
            datInsumos.Instancia.InsertarInsumos(Cli);
        }

        public void EliminaInsumo(string Cli)
        {
            datInsumos.Instancia.EliminarInsumo(Cli);
        }


        public entInsumo BuscarInsumosId(int idInsumo)
        {
            return datInsumos.Instancia.BuscarInsumoId(idInsumo);
        }
    }
}
