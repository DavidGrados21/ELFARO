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
                entPlatillo c = new entPlatillo();
                c.NombrePlatillo = txtNPlatillo.Text.Trim();
                c.Precio = decimal.Parse(txtPrecio.Text.Trim());
                logPlatillo.Instancia.EditarPlatillo(c);
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
