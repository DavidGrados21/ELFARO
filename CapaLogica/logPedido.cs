using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPedido
    {
            public string MesaId { get; set; }
            public List<string> Items { get; set; }

            public logPedido(string mesaId)
            {
                MesaId = mesaId;
                Items = new List<string>();
            }

            public void AgregarItem(string item)
            {
                Items.Add(item);
            }

            public override string ToString()
            {
                return $"Mesa {MesaId} - Pedidos: {string.Join(", ", Items)}";
            }
        }

    }
