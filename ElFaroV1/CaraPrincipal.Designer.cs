namespace ElFaroV1
{
    partial class CaraPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaraPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMozo = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnMozo
            // 
            this.btnMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMozo.Location = new System.Drawing.Point(308, 91);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(195, 55);
            this.btnMozo.TabIndex = 2;
            this.btnMozo.Text = "Mozo";
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(308, 30);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(195, 55);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.Location = new System.Drawing.Point(308, 152);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(195, 55);
            this.btnAlmacen.TabIndex = 4;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(308, 293);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(195, 55);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // CaraPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 372);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnAlmacen);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMozo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CaraPrincipal";
            this.Text = "CaraPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnPedidos;
    }
}

