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
    public partial class MantenedorMozo : Form
    {
        public MantenedorMozo()
        {
            InitializeComponent();

            MostrarMozos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMozo p = new entMozo();
                p.nombre = txtNombre.Text;
                p.dni = int.Parse(txtDNI.Text);
                p.fecha = DTPFecha.Value.ToUniversalTime();
                p.direccion = txtDireccion.Text;
                p.telefono = int.Parse(txtNumero.Text);
                p.correo = txtCorreo.Text;
                p.NdeCuenta = int.Parse(txtCuenta.Text);
                p.pass = int.Parse(txtPass.Text);
                logMozo.Instancia.InsertarMozo(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();

            MostrarMozos();
        }
        public void MostrarMozos()
        {
            dgMozo.DataSource = logMozo.Instancia.ListarMozo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            logMozo.Instancia.EliminarMozo(nombre);

            MostrarMozos();
        }

        private void dgMozo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgMozo.Rows[e.RowIndex];
            NombreFalse.Text = filaActual.Cells[0].Value.ToString();
            txtDNI.Text = filaActual.Cells[1].Value.ToString();
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            DTPFecha.Text = filaActual.Cells[2].Value.ToString();
            txtDireccion.Text = filaActual.Cells[3].Value.ToString();
            txtNumero.Text = filaActual.Cells[4].Value.ToString();
            txtCorreo.Text = filaActual.Cells[5].Value.ToString();
            txtCuenta.Text = filaActual.Cells[6].Value.ToString();
            txtPass.Text = filaActual.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entMozo c = new entMozo();
                c.nombre = NombreFalse.Text;
                string n = txtNombre.Text;
                c.dni = int.Parse(txtDNI.Text);
                c.fecha = DTPFecha.Value.ToUniversalTime();
                c.direccion = txtDireccion.Text;
                c.telefono = int.Parse(txtNumero.Text);
                c.correo = txtCorreo.Text;
                c.NdeCuenta = int.Parse(txtCuenta.Text);
                c.pass = int.Parse(txtPass.Text);
                logMozo.Instancia.EditarMozo(c, n);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            MostrarMozos();
        }

        public void LimpiarVariables()
        {
            txtNombre.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtNumero.Clear();
            txtCorreo.Clear();
            txtCuenta.Clear();
            txtPass.Clear();
            txtNumero.Clear();
        }
    }
}
