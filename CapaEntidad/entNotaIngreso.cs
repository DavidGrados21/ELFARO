using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class entNotaIngreso
    {

        public int idNotaIngreso { get; set; }
        public DateTime fechNotaIngreso { get; set; }

        public entProveedor idProveedor { get; set; }

        public Double TotNotaIngreso { get; set; }
        //public 
        public Boolean estNotaIngreso { get; set; }
        public List<entDetalleNotaDeIngreso> DetNota { get; set; }
    }
}
