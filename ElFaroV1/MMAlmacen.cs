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
    public partial class MMAlmacen : Form
    {
        public MMAlmacen()
        {
            InitializeComponent();
        }

        private void btnCrearInsumos_Click(object sender, EventArgs e)
        {
            MantenedorInsumos Alma = new MantenedorInsumos();
            Alma.ShowDialog();
        }

        private void btnCrearNdeIngreso_Click(object sender, EventArgs e)
        {
            RealizanotaIngreso realizanota = new RealizanotaIngreso();
            realizanota.ShowDialog();
        }
    }
}
