using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElFaroV1
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            MostrarClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente p = new entCliente();
                p.Nombre = txtNombre.Text;
                p.NumeroDeDni = int.Parse(txtDNI.Text);
                p.Telefono = txtTelefono.Text;
                p.CorreoElectronico = txtCorreo.Text;
                logCliente.Instancia.InsertarCliente(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();

            MostrarClientes();
        }
        public void MostrarClientes()
        {
            dgCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgCliente.Rows[e.RowIndex];
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtDNI.Text = filaActual.Cells[1].Value.ToString();
            txtCorreo.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            logCliente.Instancia.EliminarCliente(nombre);

            MostrarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                string n = txtNombre.Text;
                c.Nombre = txtNombre.Text;
                c.NumeroDeDni = int.Parse(txtDNI.Text);
                c.Telefono = txtTelefono.Text;
                c.CorreoElectronico = txtCorreo.Text;
                logCliente.Instancia.EditarCliente(c, n);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            MostrarClientes();
        }
        public void LimpiarVariables()
        {
            txtNombre.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }
    }

}
