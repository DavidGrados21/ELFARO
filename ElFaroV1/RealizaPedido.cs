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
        public RealizaPedido()
        {
            InitializeComponent();
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

        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void RealizaPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
