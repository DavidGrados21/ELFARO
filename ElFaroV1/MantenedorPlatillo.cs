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
                p.Precio = (int)nuPrecio.Value;
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
            nuPrecio.Value = 0;
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

        private void button3_Click(object sender, EventArgs e)
        {
            
                try
                {
                    // Verificar si hay al menos una fila seleccionada en el DataGridView
                    if (dgPlatillo.SelectedRows.Count > 0)
                    {
                        // Obtener la fila seleccionada
                        DataGridViewRow selectedRow = dgPlatillo.SelectedRows[0];

                        // Obtener los valores de las celdas de la fila seleccionada
                        string n = selectedRow.Cells["NombrePlatillo"].Value.ToString();
                        int p = Convert.ToInt32(selectedRow.Cells["Precio"].Value);

                    // Asignar los valores a los controles correspondientes
                    logPlatillo.Instancia.EditarPlatillo(n,p);                        // También podrías asignar estos valores a tu entidad entPlatillo
                        // para usarlos posteriormente si lo deseas.
                        // entPlatillo c = new entPlatillo();
                        // c.NombrePlatillo = nombrePlatillo;
                        // c.Precio = precio;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un platillo en la lista.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                // Llamar a métodos para limpiar y actualizar la visualización
                LimpiarVariables();
                MostrarPlatillos();
            
        }

    }
}
