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
    public partial class MantenedorInsumos : Form
    {
        string insumoSeleccionado;
        public MantenedorInsumos()
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
            dgvAlmacen.DataSource = logInsumo.Instancia.ListarInsumosCL();
        }
        public void LimpiarVariables()
        {
            txtNombreImsumos.Clear();
            CBInsumos.SelectedIndex = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entInsumo c = new entInsumo();
                c.NombreInsumos = txtNombreImsumos.Text.Trim();
                c.UM = CBInsumos.SelectedItem.ToString();
                logInsumo.Instancia.InsertaInsumosCL(c);
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
                logInsumo.Instancia.EliminaInsumo(insumoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarInsumos();

        }

        private void dgvAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvAlmacen.Rows[e.RowIndex];
            txtNombreImsumos.Text = filaActual.Cells[0].Value.ToString();
            txtFalse.Text = filaActual.Cells[0].Value.ToString();
            string du = filaActual.Cells[2].Value.ToString();
            if (du == "Kilogramos") { CBInsumos.SelectedIndex = 0; }
            else if (du == "Litros") { CBInsumos.SelectedIndex = 1; }
            else { CBInsumos.SelectedIndex = 2; }
        }
    }
}
