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
    public partial class FormAlmacen : Form
    {
        string insumoSeleccionado;
        public FormAlmacen()
        {
            InitializeComponent();
            AgregarOpcionesComboBox();
            listarInsumos();
        }
        private void AgregarOpcionesComboBox()
        {
            CBInsumos.Items.Add("Kilogramos");
            CBInsumos.Items.Add("Litros");
            CBInsumos.Items.Add("Unidades");
        }
        public void listarInsumos()
        {
            dgvAlmacen.DataSource = logInsumos.Instancia.ListarInsumosCL();
        }
        public void LimpiarVariables()
        {
            txtNombreImsumos.Clear();
            txtCantidadInsumos.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entInsumos c = new entInsumos();
                c.NombreInsumos = txtNombreImsumos.Text.Trim();
                c.Cantidad = int.Parse(txtCantidadInsumos.Text.Trim());
                string UM = CBInsumos.SelectedItem.ToString();
                logInsumos.Instancia.InsertaInsumosCL(c, UM);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarInsumos();

        }

        private void dgvAlmacen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAlmacen.Rows[e.RowIndex];
                insumoSeleccionado = selectedRow.Cells["NombreInsumos"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                logInsumos.Instancia.DeshabilitarCliente(insumoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarInsumos();

        }
    }
}
