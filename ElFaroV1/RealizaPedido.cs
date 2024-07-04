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
        public RealizaPedido()
        {
            InitializeComponent();
            logPlatillo.Instancia.MostrarPlatillo(CBPlatillos);
            GBPedido.Enabled = false;
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDNI.Text);
            int pass = int.Parse(txtPass.Text);
            if(logMozo.Instancia.IniciarSesionMozo(dni, pass) != null)
            {
                string nombre = logMozo.Instancia.IniciarSesionMozo(dni, pass);
                MessageBox.Show("Bienvenido mozo " + nombre , "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GBPedido.Enabled = true;
                GBDatosMozo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas ", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Clear();
                txtPass.Clear();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string name = CBPlatillos.Text;
            decimal precio = logPlatillo.Instancia.Obtenerprecio(name);
            int c = (int)NUDMesa.Value;
            //textBox3.Text = precio.ToString();

            try
            {
                //entPlatillo p = new entPlatillo();
                //p.NombrePlatillo = name;
                //p.Precio = precio;
                //logPedido.Instancia.InsertarPedido(p);
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
            RealizaComprobante FDP = new RealizaComprobante();
            FDP.Show();
        }
        public void MostrarPedido()
        {
            var pedidos = logPedido.Instancia.ListasPedidoM();

            // Convertir los datos a una lista para poder agregar una columna de índice
            var pedidosConIndice = pedidos
                .Select((p, index) => new
                {
                    Numero = index + 1,
                    NombrePlatillo = p.NombrePlatillo,
                    Precio = p.Precio
                })
                .ToList();

            dgvPedidos.DataSource = pedidosConIndice;
        }

    }
}
