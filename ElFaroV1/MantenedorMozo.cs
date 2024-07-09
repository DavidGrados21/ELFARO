using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
        private void RBefectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBefectivo.Checked)
            {
                GBcuenta.Enabled = false;
                txtCuenta.Text = "0";
            }
            else if (RBtarjeta.Checked)
            {
                GBcuenta.Enabled = true;
                txtCuenta.Clear();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMozo p = new entMozo();
                p.nombre = txtNombre.Text;
                p.dni = int.Parse(txtDNI.Text);
                p.fecha = DTPFecha.Value.ToUniversalTime();
                p.direccion = txtDireccion.Text;
                p.telefono = int.Parse(txtNumero.Text);
                p.correo = txtCorreo.Text;
                p.NdeCuenta = txtCuenta.Text;
                p.pass = int.Parse(txtPass.Text);
                p.Hdetrabajo =  int.Parse(txtHoras.Text);
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
            txtHoras.Text = filaActual.Cells[8].Value.ToString();
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
                c.NdeCuenta = txtCuenta.Text;
                c.pass = int.Parse(txtPass.Text);
                c.Hdetrabajo = int.Parse(txtHoras.Text);
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
            txtCuenta.Clear();
            txtHoras.Clear();
        }

        private void RBContrato_CheckedChanged(object sender, EventArgs e)
        {
            if (RBContrato.Checked)
            {
                GBhoras.Enabled = false;
                txtHoras.Text = "0";

            }
            else if (RBeventual.Checked)
            {
                GBhoras.Enabled = true;
                txtHoras.Clear();
            }
        }
    }
}
