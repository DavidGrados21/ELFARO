﻿namespace CapaLogica
{
    partial class RealizaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizaPedido));
            this.CBPlatillos = new System.Windows.Forms.ComboBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.GBPedido = new System.Windows.Forms.GroupBox();
            this.NUDMesa = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBDatosCliente = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.GBDatosMozo = new System.Windows.Forms.GroupBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDNIMozo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.GBPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBDatosCliente.SuspendLayout();
            this.GBDatosMozo.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBPlatillos
            // 
            this.CBPlatillos.FormattingEnabled = true;
            this.CBPlatillos.Location = new System.Drawing.Point(10, 28);
            this.CBPlatillos.Name = "CBPlatillos";
            this.CBPlatillos.Size = new System.Drawing.Size(207, 21);
            this.CBPlatillos.TabIndex = 1;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(10, 66);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(529, 215);
            this.dgvPedidos.TabIndex = 2;
            // 
            // GBPedido
            // 
            this.GBPedido.Controls.Add(this.NUDMesa);
            this.GBPedido.Controls.Add(this.label3);
            this.GBPedido.Controls.Add(this.btnImprimir);
            this.GBPedido.Controls.Add(this.btnAgregar);
            this.GBPedido.Controls.Add(this.dgvPedidos);
            this.GBPedido.Controls.Add(this.CBPlatillos);
            this.GBPedido.Location = new System.Drawing.Point(213, 12);
            this.GBPedido.Name = "GBPedido";
            this.GBPedido.Size = new System.Drawing.Size(545, 315);
            this.GBPedido.TabIndex = 3;
            this.GBPedido.TabStop = false;
            this.GBPedido.Text = "Pedido";
            // 
            // NUDMesa
            // 
            this.NUDMesa.Location = new System.Drawing.Point(318, 28);
            this.NUDMesa.Name = "NUDMesa";
            this.NUDMesa.Size = new System.Drawing.Size(120, 20);
            this.NUDMesa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesa";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(435, 287);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 22);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Detalle de compra";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(467, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 22);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GBDatosCliente
            // 
            this.GBDatosCliente.Controls.Add(this.button2);
            this.GBDatosCliente.Controls.Add(this.button1);
            this.GBDatosCliente.Controls.Add(this.label4);
            this.GBDatosCliente.Controls.Add(this.txtDocumentoCliente);
            this.GBDatosCliente.Location = new System.Drawing.Point(12, 12);
            this.GBDatosCliente.Name = "GBDatosCliente";
            this.GBDatosCliente.Size = new System.Drawing.Size(186, 166);
            this.GBDatosCliente.TabIndex = 7;
            this.GBDatosCliente.TabStop = false;
            this.GBDatosCliente.Text = "Datos Cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Introduzca el DNI del cliente";
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(20, 61);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(138, 20);
            this.txtDocumentoCliente.TabIndex = 0;
            // 
            // GBDatosMozo
            // 
            this.GBDatosMozo.Controls.Add(this.btnIniciarSesion);
            this.GBDatosMozo.Controls.Add(this.txtPass);
            this.GBDatosMozo.Controls.Add(this.txtDNIMozo);
            this.GBDatosMozo.Controls.Add(this.label2);
            this.GBDatosMozo.Controls.Add(this.label1);
            this.GBDatosMozo.Location = new System.Drawing.Point(12, 12);
            this.GBDatosMozo.Name = "GBDatosMozo";
            this.GBDatosMozo.Size = new System.Drawing.Size(186, 166);
            this.GBDatosMozo.TabIndex = 6;
            this.GBDatosMozo.TabStop = false;
            this.GBDatosMozo.Text = "Datos Mozo";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(45, 137);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(89, 23);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 107);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(156, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtDNIMozo
            // 
            this.txtDNIMozo.Location = new System.Drawing.Point(6, 47);
            this.txtDNIMozo.Name = "txtDNIMozo";
            this.txtDNIMozo.Size = new System.Drawing.Size(156, 20);
            this.txtDNIMozo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de mozo";
            // 
            // RealizaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 337);
            this.Controls.Add(this.GBDatosCliente);
            this.Controls.Add(this.GBDatosMozo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBPedido);
            this.Name = "RealizaPedido";
            this.Text = "RealizaPedido";
            this.Load += new System.EventHandler(this.RealizaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.GBPedido.ResumeLayout(false);
            this.GBPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBDatosCliente.ResumeLayout(false);
            this.GBDatosCliente.PerformLayout();
            this.GBDatosMozo.ResumeLayout(false);
            this.GBDatosMozo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CBPlatillos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox GBPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.NumericUpDown NUDMesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBDatosCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.GroupBox GBDatosMozo;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDNIMozo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}