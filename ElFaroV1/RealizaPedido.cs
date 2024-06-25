using CapaEntidad;
using ElFaroV1;
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
        int c = 0;
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
            string name = CBPlatillos.Text;
            decimal precio = logPlatillo.Instancia.Obtenerprecio(name);
            c ++;
            //textBox3.Text = precio.ToString();

            try
            {
                entPlatillo p = new entPlatillo();
                p.NombrePlatillo = name;
                p.Precio = precio;
                logPlatillo.Instancia.InsertarPedido(p,c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            MostrarPedido();
        }

        private void RealizaPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MantenedorFormaDePago FDP = new MantenedorFormaDePago();
            FDP.Show();
        }
        public void MostrarPedido()
        {
            dgvPedidos.DataSource = logPlatillo.Instancia.MostrarPedido();
        }
    }
}
