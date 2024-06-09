using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    internal class logPlatillo
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
    }
}
