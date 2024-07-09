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
    public partial class RealizanotaIngreso : Form
    {
        public RealizanotaIngreso()
        {
            InitializeComponent();
            ListarNotaingreso();
        }
        public void ListarNotaingreso()
        {
            tablaNotaIngreso.DataSource = logNotaIngreso.Instancia.ListarNotaIngreso();
        }
        private void RealizanotaIngreso_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RealizaNotaDeIgreso not = new RealizaNotaDeIgreso();
            not.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarNotaingreso();
        }
    }
}
