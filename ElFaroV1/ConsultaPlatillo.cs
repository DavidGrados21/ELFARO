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
    public partial class ConsultaPlatillo : Form
    {
        public ConsultaPlatillo()
        {
            InitializeComponent();
            MostrarPlatillo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarPlatillo();
        }
        public void MostrarPlatillo ()
        {
            DGPlatillo.DataSource = logPlatillo.Instancia.ListarPlatillo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DGPlatillo.DataSource = logPlatillo.Instancia.BusquedadPlatillo(nombre);
        }
    }
}
