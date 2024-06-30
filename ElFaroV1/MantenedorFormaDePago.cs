using System;
using System.IO;
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
    public partial class MantenedorFormaDePago : Form
    {
        public MantenedorFormaDePago()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                // Obtener el texto del TextBox
                string texto = txtDescripcion.Text;

                // Verificar si el texto está vacío
                if (string.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("No hay texto para guardar.", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar un diálogo para seleccionar la ubicación y el nombre del archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "BOLETA DE PAGO";
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    try
                    {
                        // Escribir el texto en el archivo seleccionado
                        File.WriteAllText(fileName, texto);
                        MessageBox.Show("Texto guardado correctamente.", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorCliente FDP = new MantenedorCliente();
            FDP.Show();
        }
    }
}
