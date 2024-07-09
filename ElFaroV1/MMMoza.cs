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
    public partial class MMMoza : Form
    {
        public MMMoza()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ConsultaPlatillo CP = new ConsultaPlatillo();
            CP.Show();
        }

        private void btnCPlatillo_Click(object sender, EventArgs e)
        {
            RealizaPedido RP = new RealizaPedido();
            RP.Show();
        }
    }
}
