using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNotaIngreso
    {
        #region singleton
        private static readonly logNotaIngreso _instancia = new logNotaIngreso();
        public static logNotaIngreso Instancia
        {
            get { return logNotaIngreso._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entNotaIngreso> ListarNotaIngreso()
        {
            try
            {
                return datNotaIngreso.Instancia.ListarNotaIngreso();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int InsertarNotaIngreso(entNotaIngreso Not)
        {
            int a;
            try
            {
                a = datNotaIngreso.Instancia.InsertarNotaIngreso(Not);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        public void InsertarDetNotaIngreso(entDetalleNotaDeIngreso dNot)
        {
            try
            {
                datNotaIngreso.Instancia.InsertarDetalleNotaIngreso(dNot);
            }
            catch (Exception e)
            { throw e; }
        }


        #endregion metodos
    }
}

