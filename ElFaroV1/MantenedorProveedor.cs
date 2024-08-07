﻿using CapaEntidad;
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
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            listarProveedor();
            txtCodigoproveedor.Enabled = false;
        }
        public void listarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedorProv();
        }
        private void MantenedorProveedor_Load(object sender, EventArgs e)
        {

        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex]; //
            txtCodigoproveedor.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txtRuc.Text = filaActual.Cells[2].Value.ToString();
            cbRubro.Text = filaActual.Cells[3].Value.ToString();
            txtDireccion.Text = filaActual.Cells[4].Value.ToString();
            txtTelefono.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.RazonSocial = txtRazonSocial.Text.Trim();
                p.Ruc = txtRuc.Text.Trim();
                p.Rubro = cbRubro.Text.Trim();
                p.Direccion = txtDireccion.Text.Trim();
                p.Telefono = int.Parse(txtTelefono.Text.Trim());
                p.estado = true;
                logProveedor.Instancia.InsertaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.RazonSocial = txtRazonSocial.Text.Trim();
                p.Ruc = txtRuc.Text.Trim();
                p.Rubro = cbRubro.Text.Trim();
                p.Direccion = txtDireccion.Text.Trim();
                p.Telefono = int.Parse(txtTelefono.Text.Trim());
                p.estado = true;
                logProveedor.Instancia.Editaproveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            int codPRO = int.Parse(txtCodigoproveedor.Text.Trim());
            try
            {
                if (logProveedor.Instancia.VerificarProveedor(codPRO))
                {
                    bool a = false;
                    entProveedor prov = new entProveedor();
                    prov.Codigo = int.Parse(txtCodigoproveedor.Text.Trim());
                    prov.RazonSocial = txtRazonSocial.Text.Trim();
                    prov.Ruc = (txtRuc.Text.Trim());
                    prov.Rubro = cbRubro.Text.Trim();
                    prov.Direccion = txtDireccion.Text.Trim();
                    prov.Telefono = int.Parse(txtTelefono.Text.Trim());
                    prov.estado = a;
                    logProveedor.Instancia.Editaproveedor(prov);

                }
                else
                {
                    bool a = true;
                    entProveedor prov = new entProveedor();
                    prov.Codigo = int.Parse(txtCodigoproveedor.Text.Trim());
                    prov.RazonSocial = txtRazonSocial.Text.Trim();
                    prov.Ruc = (txtRuc.Text.Trim());
                    prov.Rubro = cbRubro.Text.Trim();
                    prov.Direccion = txtDireccion.Text.Trim();
                    prov.Telefono = int.Parse(txtTelefono.Text.Trim());
                    prov.estado = a;
                    logProveedor.Instancia.Editaproveedor(prov);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();

            listarProveedor();
        }
        private void LimpiarVariables()
        {
            txtCodigoproveedor.Text = "";
            txtRazonSocial.Text = "";
            cbRubro.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtRuc.Text = "";
            //cbkEstadoCliente.Checked = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
