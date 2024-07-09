namespace ElFaroV1
{
    partial class MMMoza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMMoza));
            this.btnCPlatillo = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPlatillo
            // 
            this.btnCPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPlatillo.Location = new System.Drawing.Point(55, 203);
            this.btnCPlatillo.Name = "btnCPlatillo";
            this.btnCPlatillo.Size = new System.Drawing.Size(240, 38);
            this.btnCPlatillo.TabIndex = 5;
            this.btnCPlatillo.Text = "Crear Pedido";
            this.btnCPlatillo.UseVisualStyleBackColor = true;
            this.btnCPlatillo.Click += new System.EventHandler(this.btnCPlatillo_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(55, 80);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(240, 43);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Consulta Platillo";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MMMoza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 327);
            this.Controls.Add(this.btnCPlatillo);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MMMoza";
            this.Text = "MMMoza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCPlatillo;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}