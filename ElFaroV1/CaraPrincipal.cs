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
    public partial class CaraPrincipal : Form
    {
        public CaraPrincipal()
        {
            InitializeComponent();
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            FormMozo Mozo= new FormMozo();
            Mozo.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ISAdmin admin = new ISAdmin();
            admin.ShowDialog();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            FormAlmacen Alma= new FormAlmacen();
            Alma.ShowDialog();
        }
    }
}
