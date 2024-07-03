using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {
        public int NumeroDeDni { get; set; }
        public string NombrePlatillo { get; set; }
        public decimal Precio { get; set; }
        public int Mesa { get; set; }
        public DateTime HoraCreacion { get; set; }
    }
}
