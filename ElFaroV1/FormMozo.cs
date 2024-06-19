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
    public partial class FormMozo : Form
    {
        private Dictionary<string, logPedido> pedidos;
        public FormMozo()
        {
            InitializeComponent();
            InicializarMesas();
        }

        private void InicializarMesas()
        {
            pedidos = new Dictionary<string, logPedido>();
            for (int i = 1; i <= 24; i++)
            {
                string mesaId = $"MesaA{i}"; // Utiliza la misma convención de claves
                pedidos.Add(mesaId, new logPedido(mesaId));
            }
        }

        private void btnMesaA1_Click(object sender, EventArgs e)
        {
            //FormMesa IS = new FormMesa();
            //IS.ShowDialog();
            string mesaSeleccionada = "MesaA1";
            var formMesa = new FormMesa(pedidos[mesaSeleccionada]);
            formMesa.Show();
        }
    }
}
