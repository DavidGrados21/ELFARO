using CapaEntidad;
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
    public partial class RealizaNotaDeIgreso : Form
    {
        entNotaIngreso Nota = new entNotaIngreso();
        entDetalleNotaDeIngreso dNota = new entDetalleNotaDeIngreso();
        int idProveedor;
        public RealizaNotaDeIgreso()
        {
            InitializeComponent();
        }
        private List<entDetalleNotaDeIngreso> listaDetNotaIngreso = new List<entDetalleNotaDeIngreso>();

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            txtProveedor.Focus();

            idProveedor = Convert.ToInt32(txtProveedor.Text); // se obtiene el valor de una celda 
            entProveedor P = logProveedor.Instancia.BuscarProveedorId(idProveedor);

            if (P != null)
            {
                txtRazonSocial.Text = Convert.ToString(P.RazonSocial);
            }
            else
                MessageBox.Show("El Proveedor  no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void nostasIngreso_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {

            txtidInsumo.Focus();
            int idInsumo = Convert.ToInt32(txtidInsumo.Text); // se obtiene el valor de una celda 
            entInsumo Ins = logInsumo.Instancia.BuscarInsumosId(idInsumo);
            if (Ins != null)
            {

                txtDescInsumo.Text = Convert.ToString(Ins.NombreInsumos);

            }
            else
                MessageBox.Show("El Insumo no existe or esta inhabilitado, verifique.", "Producto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public static int confilas = 0;
        public static decimal Total = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entDetalleNotaDeIngreso dNot = new entDetalleNotaDeIngreso();
            entInsumo Ins = new entInsumo();

            if ((this.txtProveedor.Text.Trim() != "") && (txtidInsumo.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0))
                {
                    
                    int idInsumo = Convert.ToInt32(txtidInsumo.Text);
                    Ins = logInsumo.Instancia.BuscarInsumosId(idInsumo);

                    if (Ins != null)
                    {
                        decimal precio = Convert.ToDecimal(txtPrecioCompra.Text);

                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(TablaDetalleNotaIngreso);

                        fila.Cells[0].Value = idInsumo; 
                        fila.Cells[1].Value = Ins.NombreInsumos; 
                        fila.Cells[2].Value = Convert.ToInt32(txtCantidad.Text); 
                        fila.Cells[3].Value = precio; 

                        decimal subTotal = Convert.ToDecimal(fila.Cells[2].Value) * Convert.ToDecimal(fila.Cells[3].Value);
                        fila.Cells[4].Value = subTotal; 

                        TablaDetalleNotaIngreso.Rows.Add(fila);

                       CalcularTotal();
                    }
                    else
                    {
                        MessageBox.Show("El Insumo no existe o está inhabilitado, verifique.", "Producto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser mayor que cero.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    

        private void btnGrabarDetalle_Click(object sender, EventArgs e)
        {
            int idNotaIngreso;
            try
            {
                entNotaIngreso Not = new entNotaIngreso();
                
                entProveedor P = new entProveedor();
                entInsumo ins = new entInsumo();
                Not.fechNotaIngreso = Convert.ToDateTime(dateTimePicker1.Value);
                Not.TotNotaIngreso = Convert.ToDouble(txtTotal.Text);
                P.Codigo = int.Parse(txtProveedor.Text);
                Not.idProveedor = P;
                Not.idProveedor.Codigo = P.Codigo;

                Not.estNotaIngreso = true;
                idNotaIngreso = logNotaIngreso.Instancia.InsertarNotaIngreso(Not);

                
                GrabarDetalleNota(idNotaIngreso);


                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw ex;
            }
        }

        private void GrabarDetalleNota(int cod)
        {
            foreach (DataGridViewRow Fila in TablaDetalleNotaIngreso.Rows)
            {
                dNota.idNotaIngreso = cod;
                entInsumo ins = new entInsumo();

                ins.idInsumo = Convert.ToInt32(Fila.Cells[0].Value.ToString());
                
                dNota.idInsumo = ins;
                dNota.idInsumo.idInsumo = ins.idInsumo;

                dNota.cantInsumos = Convert.ToInt32(Fila.Cells[2].Value.ToString());
                dNota.precInsumo = Convert.ToDecimal(Fila.Cells[3].Value.ToString());

                logNotaIngreso.Instancia.InsertarDetNotaIngreso(dNota);

            }
        }

        private void configurarColumnasDataGridView()
        {
            DataGridViewColumn columna0, columna1, columna2, columna3, columna4; 
            columna0 = TablaDetalleNotaIngreso.Columns[0];
            columna0.Visible = true;                           
            columna1 = TablaDetalleNotaIngreso.Columns[1];
            columna1.HeaderText = "idInsumo";
            columna1.Width = 200;
           
            columna2 = TablaDetalleNotaIngreso.Columns[2];
            columna2.HeaderText = "txtDescInsumo";
            columna2.Width = 80;
            columna3 = TablaDetalleNotaIngreso.Columns[3];
            columna3.HeaderText = "Cantidad";
            columna3.Width = 200;
            columna4 = TablaDetalleNotaIngreso.Columns[4];
            columna4.HeaderText = "Precio";
            columna4.Width = 200;

        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in TablaDetalleNotaIngreso.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[4].Value);
                }
            }

            txtTotal.Text = total.ToString();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

