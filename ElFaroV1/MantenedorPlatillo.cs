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
using System.Windows.Forms.VisualStyles;

namespace ElFaroV1
{
    public partial class MantenedorPlatillo : Form
    {
        public MantenedorPlatillo()
        {
            InitializeComponent();
            MostrarPlatillos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entPlatillo p = new entPlatillo();
                p.NombrePlatillo = txtNPlatillo.Text.Trim();
                p.Precio = int.Parse(txtPrecio.Text.Trim());
                logPlatillo.Instancia.InsertarPlatillo(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();

            MostrarPlatillos();
        }
        public void LimpiarVariables()
        {
            txtNPlatillo.Clear();
            txtPrecio.Clear();
        }

        public void MostrarPlatillos()
        {
            dgPlatillo.DataSource=logPlatillo.Instancia.ListarPlatillo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre =txtNPlatillo.Text.Trim();
            logPlatillo.Instancia.EliminarPlatillo(nombre);

            MostrarPlatillos();

        }

        private void MantenedorPlatillo_Load(object sender, EventArgs e)
        {

        }

        private void dgPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgPlatillo.Rows[e.RowIndex];
            txtNPlatillo.Text = filaActual.Cells[0].Value.ToString();
            NombreFalse.Text = filaActual.Cells[0].Value.ToString();
            txtPrecio.Text = filaActual.Cells[1].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPlatillo c = new entPlatillo();
                c.NombrePlatillo = NombreFalse.Text.Trim();
                string n = txtNPlatillo.Text;
                c.Precio = decimal.Parse(txtPrecio.Text.Trim());
                logPlatillo.Instancia.EditarPlatillo(c, n);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            MostrarPlatillos();

        }
    }
}
