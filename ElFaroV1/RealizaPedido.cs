using CapaEntidad;
using ElFaroV1;
using System;
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
            GBDatosCliente.Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string name = CBPlatillos.Text;
            decimal precio = logPlatillo.Instancia.Obtenerprecio(name);
            int id = logPlatillo.Instancia.ObtenerID(name);
            int c = (int)NUDMesa.Value;
            string cliente = txtDocumentoCliente.Text;
            int dni = int.Parse(txtDNIMozo.Text);
            DateTime fecha = DateTime.Now;

            try
            {
                entPedido p = new entPedido();
                p.NombrePlatillo = name;
                p.Precio = precio;
                p.Mesa = c;
                p.NumeroDeDni = cliente;
                p.HoraCreacion = fecha;
                logPedido.Instancia.InsertarPedido(p, dni, id);
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
            int cliente = int.Parse(txtDocumentoCliente.Text);
            dgvPedidos.DataSource = logPedido.Instancia.DatosBoleta(cliente);
        }
        private void RegistraCliente()
        {
            MantenedorCliente CL = new MantenedorCliente();
            CL.Show();
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDNIMozo.Text);
            int pass = int.Parse(txtPass.Text);
            if (logMozo.Instancia.IniciarSesionMozo(dni, pass) != null)
            {
                string nombre = logMozo.Instancia.IniciarSesionMozo(dni, pass);
                MessageBox.Show("Bienvenido mozo " + nombre, "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GBDatosMozo.Visible = false;
                GBDatosCliente.Visible = true;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas ", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNIMozo.Clear();
                txtPass.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistraCliente();
        }
    }
}
