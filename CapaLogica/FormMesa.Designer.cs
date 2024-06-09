namespace CapaLogica
{
    partial class FormMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMesa));
            this.GBDatosMozo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GBPedido = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.GBDatosMozo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GBPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDatosMozo
            // 
            this.GBDatosMozo.Controls.Add(this.btnIniciarSesion);
            this.GBDatosMozo.Controls.Add(this.textBox2);
            this.GBDatosMozo.Controls.Add(this.textBox1);
            this.GBDatosMozo.Controls.Add(this.label2);
            this.GBDatosMozo.Controls.Add(this.label1);
            this.GBDatosMozo.Location = new System.Drawing.Point(12, 12);
            this.GBDatosMozo.Name = "GBDatosMozo";
            this.GBDatosMozo.Size = new System.Drawing.Size(186, 166);
            this.GBDatosMozo.TabIndex = 0;
            this.GBDatosMozo.TabStop = false;
            this.GBDatosMozo.Text = "Datos Mozo";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(405, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // GBPedido
            // 
            this.GBPedido.Controls.Add(this.dataGridView1);
            this.GBPedido.Controls.Add(this.comboBox1);
            this.GBPedido.Location = new System.Drawing.Point(213, 12);
            this.GBPedido.Name = "GBPedido";
            this.GBPedido.Size = new System.Drawing.Size(439, 314);
            this.GBPedido.TabIndex = 3;
            this.GBPedido.TabStop = false;
            this.GBPedido.Text = "Pedido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(45, 137);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(89, 23);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // FormMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBPedido);
            this.Controls.Add(this.GBDatosMozo);
            this.Name = "FormMesa";
            this.Text = "FormMesa";
            this.Load += new System.EventHandler(this.FormMesa_Load);
            this.GBDatosMozo.ResumeLayout(false);
            this.GBDatosMozo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GBPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDatosMozo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GBPedido;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}