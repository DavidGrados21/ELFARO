using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        ///listado
        public List<entProveedor> ListarProveedorProv()
        {
            return datProveedor.Instancia.ListarProveedor();
        }
        public void InsertaProveedor(entProveedor Prov)
        {
            datProveedor.Instancia.InsertaProveedor(Prov);
        }
        public void Editaproveedor(entProveedor Prov)
        {
            datProveedor.Instancia.EditarProveedor(Prov);
        }
        public bool VerificarProveedor(int Prov)
        {
            return datProveedor.Instancia.VerificarEstadoProveedor(Prov);
        }

        public entProveedor BuscarProveedorId(int idProveedor)
        {
            try
            {
                return datProveedor.Instancia.BuscarProveedorId(idProveedor);
            }
            catch (Exception e) { throw e; }
        }


    }
}

