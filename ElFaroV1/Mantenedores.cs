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
            OpenMantenedorMozo();
        }

        private void btnMantenedorProveedor_Click(object sender, EventArgs e)
        {
            OpenMantenedorProveedor();
        }

        private void OpenMantenedorProveedor()
        {
            Close();

            // Abrir el formulario MantenedorProveedor
            MantenedorProveedor pro = new MantenedorProveedor();
            pro.ShowDialog();
        }

        private void OpenMantenedorMozo()
        {
            Close();

            // Abrir el formulario MantenedorProveedor
            MantenedorMozo mozo = new MantenedorMozo();
            mozo.ShowDialog();
        }
    }
}
