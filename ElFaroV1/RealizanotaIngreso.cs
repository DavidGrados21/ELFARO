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
            List<entNotaIngreso> listaNotaIngreso = logNotaIngreso.Instancia.ListarNotaIngreso();

            if (listaNotaIngreso.Count >= 0)
            {
                tablaNotaIngreso.Columns.Clear(); 
                
                tablaNotaIngreso.DataSource = listaNotaIngreso; 

            }
        }
        private void RealizanotaIngreso_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nostasIngreso not = new nostasIngreso();
            not.Show();
        }
    }
}
