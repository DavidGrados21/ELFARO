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
    public partial class MMCocina : Form
    {
        public MMCocina()
        {
            InitializeComponent();
        }

        private void btnCPlatillo_Click(object sender, EventArgs e)
        {
            MantenedorPlatillo mp = new MantenedorPlatillo();
            mp.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ConsultaPedido mp = new ConsultaPedido();
            mp.ShowDialog();
        }
    }
}
