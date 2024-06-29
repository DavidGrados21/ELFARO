using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElFaroV1
{
    public partial class ConsultaPedido : Form
    {
        public ConsultaPedido()
        {
            InitializeComponent();
            mostrar();
        }
        public void mostrar()
        {
            DGVPedido.DataSource = logPedido.Instancia.ListasPedidoC();
            DGVPedido.Columns["Precio"].Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string p = txtNombre.Text;
            int n = (int)NUDMesa.Value;

            if (p != "" || n != 0)
            {
                if (p != "")
                {
                    DGVPedido.DataSource = logPedido.Instancia.FiltrarporPlatillo(p);
                    limpieza();
                }
                else if (n != 0)
                {
                    DGVPedido.DataSource = logPedido.Instancia.FiltrarporMesa(n);
                    limpieza();
                }
            }
        }
        private void limpieza()
        {
            txtNombre.Clear();
            NUDMesa.Value = 0;
        }
    }
}
