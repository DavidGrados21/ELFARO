using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public partial class FormMesa : Form
    {
        public FormMesa()
        {
            InitializeComponent();
            GBPedido.Enabled = false;
        }

        private void FormMesa_Load(object sender, EventArgs e)
        {

        }
    }
}
