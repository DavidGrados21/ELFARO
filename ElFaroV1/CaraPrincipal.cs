﻿using CapaLogica;
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
            MantenedorPlatillo mp = new MantenedorPlatillo();
            mp.ShowDialog();


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ISAdmin admin = new ISAdmin();
            admin.ShowDialog();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            MantenedorInsumos Alma= new MantenedorInsumos();
            Alma.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
           RealizaPedido rp= new RealizaPedido();   
           rp.ShowDialog();
            
        }
    }
}
