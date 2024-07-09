using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleNotaDeIngreso
    {

        
            public int idDetNotaIngreso { get; set; }
            public int idNotaIngreso{ get; set; }
            public int cantInsumos { get; set; }
            public Decimal precInsumo { get; set; }
            public entInsumo idInsumo { get; set; }
        
    }
}
