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
            GBDatosCliente.Visible = false;
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDNI.Text);
            int pass = int.Parse(txtPass.Text);
            if(logMozo.Instancia.IniciarSesionMozo(dni, pass) != null)
            {
                string nombre = logMozo.Instancia.IniciarSesionMozo(dni, pass);
                MessageBox.Show("Bienvenido mozo " + nombre, "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GBDatosMozo.Visible = false;
                GBDatosCliente.Visible = true;
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
            int cliente = int.Parse(txtDniCliente.Text);
            DateTime fecha = DateTime.Now;

            try
            {
                entPedido p = new entPedido();
                p.NombrePlatillo = name;
                p.Precio = precio;
                p.Mesa = c;
                p.NumeroDeDni = cliente;
                p.HoraCreacion = fecha;
                logPedido.Instancia.InsertarPedido(p);
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
            int cliente = int.Parse(txtDniCliente.Text);
            dgvPedidos.DataSource = logPedido.Instancia.DatosBoleta(cliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDniCliente.Text);
            if (logCliente.Instancia.VerificarDNI(dni))
            {
                GBPedido.Enabled = true;
                GBDatosCliente.Enabled = false;
                MostrarPedido();
            }
            else
            {
                MessageBox.Show("Cliente No Registrado ", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistraCliente();
            }
        }
        private void RegistraCliente()
        {
            MantenedorCliente CL = new MantenedorCliente();
            CL.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistraCliente();
        }
    }
}
