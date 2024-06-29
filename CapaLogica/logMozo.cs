using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMozo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMozo _instancia = new logMozo();
        //privado para evitar la instanciación directa
        public static logMozo Instancia
        {
            get
            {
                return logMozo._instancia;
            }
        }
        #endregion singleton
        public List<entMozo> ListarMozo()
        {
            return datMozo.Instancia.ListarMozo();
        }
        public void InsertarMozo(entMozo p)
        {
            datMozo.Instancia.InsertarMozo(p);
        }

        public void EliminarMozo(string n)
        {
            datMozo.Instancia.EliminarMozo(n);
        }
        public void EditarMozo(entMozo PL, string nombre)
        {
            datMozo.Instancia.EditarMozo(PL, nombre);
        }
    }
}
