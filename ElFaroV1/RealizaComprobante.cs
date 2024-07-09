using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace ElFaroV1
{
    public partial class RealizaComprobante : Form
    {
        public RealizaComprobante()
        {
            InitializeComponent();
            txtDni.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtMonto.ReadOnly = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int mesa = int.Parse(txtMesa.Text);
            decimal subtotal = logPedido.Instancia.Subtotal(mesa);
            int dni = logPedido.Instancia.GeneraDni(mesa);
            txtMonto.Text = subtotal.ToString();
            txtDni.Text = dni.ToString();
            txtNombre.Text = logCliente.Instancia.ConsultaCliente(dni);

            DGdescripcion.DataSource = logPedido.Instancia.FiltrarporMesa(mesa);
            DGdescripcion.Columns[0].Visible = false;
        }
        public static string NumeroEnLetras(decimal numero)
        {
            if (numero == 0) return "cero";

            long entero = (long)numero;
            int decimales = (int)((numero - entero) * 100);

            string letrasEntero = ConvertirEnteroALetras(entero);
            string letrasDecimales = decimales > 0 ? $"con {ConvertirEnteroALetras(decimales)} céntimos" : "";

            return $"{letrasEntero} {letrasDecimales}".Trim();
        }

        private static string ConvertirEnteroALetras(long numero)
        {
            if (numero == 0) return "";

            if (numero < 0) return $"menos {ConvertirEnteroALetras(Math.Abs(numero))}";

            string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] centenas = { "", "cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

            if (numero < 10) return unidades[numero];
            if (numero < 20) return new string[] { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" }[numero - 10];
            if (numero < 100) return $"{decenas[numero / 10]}{(numero % 10 > 0 ? $" y {ConvertirEnteroALetras(numero % 10)}" : "")}";
            if (numero < 1000) return $"{centenas[numero / 100]}{(numero % 100 > 0 ? $" {ConvertirEnteroALetras(numero % 100)}" : "")}";

            string[] sufijos = { "", "mil", "millón", "mil millones", "billón" }; // hasta billón, expandible si es necesario

            for (int i = 1; i < sufijos.Length; i++)
            {
                long divisor = (long)Math.Pow(1000, i);
                if (numero < divisor * 1000)
                {
                    return $"{ConvertirEnteroALetras(numero / divisor)} {sufijos[i]} {(numero % divisor > 0 ? ConvertirEnteroALetras(numero % divisor) : "")}".Trim();
                }
            }

            return "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int texto = int.Parse(txtDni.Text);

            var datosFiltrados = logPedido.Instancia.DatosBoleta(texto);
            DGdescripcion.DataSource = datosFiltrados;

            StringBuilder sb = new StringBuilder();
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            string hora = DateTime.Now.ToString("HH:mm");

            // Agregar el encabezado
            sb.AppendLine("Cevicheria Restaurante - El Faro");
            sb.AppendLine("AV AMERICA NORTE 2333 URB LAS QUINTANAS");
            sb.AppendLine("La Libertad - Trujillo");
            sb.AppendLine("Cel: 950488293 - 044 372436");
            sb.AppendLine();
            sb.AppendLine("BOLETA DE VENTA ELECTRONICA ");
            sb.AppendLine(fecha + "        " + hora);
            sb.AppendLine("Usuario: " + txtNombre.Text + "        " + " UBI: mesa " + txtMesa.Text);
            sb.AppendLine("Forma de Pago: " + CBPago.Text);
            sb.AppendLine();
            // Agregar los encabezados de las columnas de la tabla
            foreach (DataGridViewColumn column in DGdescripcion.Columns)
            {
                sb.Append(column.HeaderText + "\t");
            }
            sb.AppendLine();

            // Obtener las filas de datos
            foreach (DataGridViewRow row in DGdescripcion.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value?.ToString() + "\t");
                }
                sb.AppendLine();
            }

            // Agregar el monto total

            int mesa = int.Parse(txtMesa.Text);
            decimal subTotal = logPedido.Instancia.Subtotal(mesa);
            decimal igv = subTotal * 0.10m;
            decimal total = subTotal + igv;
            string palabra = NumeroEnLetras(total).ToUpperInvariant();
            sb.AppendLine();
            sb.AppendLine($"Op.GRAVADAS: {subTotal:C}");
            sb.AppendLine($"Igv 10.00%:{igv:C}");
            sb.AppendLine($"Total:{total:C}");
            sb.AppendLine("Son:" + palabra + " CON 00/100 soles");

            // Mostrar un diálogo para seleccionar la ubicación y el nombre del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "BOLETA DE PAGO";
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    // Escribir el texto en el archivo seleccionado
                    File.WriteAllText(fileName, sb.ToString());
                    MessageBox.Show("Texto guardado correctamente.", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RealizaComprobante_Load(object sender, EventArgs e)
        {

        }
    }
}
