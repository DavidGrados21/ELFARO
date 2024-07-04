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
    public partial class ISAdmin : Form
    {
        int intentos = 3;
        public ISAdmin()
        {
            InitializeComponent();
        }

        private void btnIS_Click(object sender, EventArgs e)
        {
            string u = txtUsuario.Text;
            string c = txtContraseña.Text;

            if (intentos != 0) 
            {
                if (logMozo.Instancia.IniciarSesionAdmin(u, c))
                {
                    MessageBox.Show("Bienvenido Administrador del Restaurante El Faro ", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mantenedores man = new Mantenedores();
                    man.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas (le quedan " + intentos + " intentos)", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos--;
                    txtContraseña.Clear();
                    txtUsuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas , por favor inicie sesion mas tarde", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtUsuario.Clear();
            }

        }
        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIS.PerformClick();
            }
        }
    }
}
