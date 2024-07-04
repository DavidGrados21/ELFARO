using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        public void InsertarCliente(entCliente p)
        {
            datCliente.Instancia.InsertarCliente(p);
        }

        public void EliminarCliente(string n)
        {
            datCliente.Instancia.EliminarCliente(n);
        }
        public void EditarCliente(entCliente PL, string nombre)
        {
            datCliente.Instancia.EditarCliente(PL, nombre);
        }
        public string ConsultaCliente(int DNI)
        {
            return datCliente.Instancia.ConsultarCliente(DNI);
        }
        public bool VerificarDNI(int DNI)
        {
            return datCliente.Instancia.VerificarDNI(DNI);
        }
    }
}
