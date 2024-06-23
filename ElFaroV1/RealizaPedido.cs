using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public partial class RealizaPedido : Form
    {
        private logPedido pedidoActual;

        public RealizaPedido(logPedido pedido)
        {
            InitializeComponent();
            pedidoActual = pedido;
            labelMesa.Text = pedidoActual.MesaId;
            InicializarDataGridView();
            ActualizarDataGridView();
            logPlatillo.Instancia.MostrarPlatillo(CBPlatillos);
            //GBPedido.Enabled = false;
        }

        private void InicializarDataGridView()
        {
            dgvPedidos.Columns.Clear();
            dgvPedidos.Columns.Add("NombrePlatillo", "Nombre del Platillo");
            dgvPedidos.Columns.Add("Precio", "Precio");
        }

        private void ActualizarDataGridView()
        {
            dgvPedidos.Rows.Clear();
            foreach (var item in pedidoActual.Items)
            {
                dgvPedidos.Rows.Add(item);
            }
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
