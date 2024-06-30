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
    public partial class Mantenedores : Form
    {
        public Mantenedores()
        {
            InitializeComponent();
        }

        private void btnMantenedorMozo_Click(object sender, EventArgs e)
        {
            MantenedorMozo mozo= new MantenedorMozo();
            mozo.ShowDialog();
        }

        private void btnMantenedorProveedor_Click(object sender, EventArgs e)
        {
            MantenedorProveedor pro = new MantenedorProveedor();
            pro.ShowDialog();
        }
    }
}
