namespace ElFaroV1
{
    partial class MMAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMAlmacen));
            this.btnCrearNdeIngreso = new System.Windows.Forms.Button();
            this.btnCrearInsumos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearNdeIngreso
            // 
            this.btnCrearNdeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNdeIngreso.Location = new System.Drawing.Point(56, 211);
            this.btnCrearNdeIngreso.Name = "btnCrearNdeIngreso";
            this.btnCrearNdeIngreso.Size = new System.Drawing.Size(240, 47);
            this.btnCrearNdeIngreso.TabIndex = 5;
            this.btnCrearNdeIngreso.Text = "Nota De Ingreso";
            this.btnCrearNdeIngreso.UseVisualStyleBackColor = true;
            this.btnCrearNdeIngreso.Click += new System.EventHandler(this.btnCrearNdeIngreso_Click);
            // 
            // btnCrearInsumos
            // 
            this.btnCrearInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearInsumos.Location = new System.Drawing.Point(56, 84);
            this.btnCrearInsumos.Name = "btnCrearInsumos";
            this.btnCrearInsumos.Size = new System.Drawing.Size(240, 43);
            this.btnCrearInsumos.TabIndex = 4;
            this.btnCrearInsumos.Text = "Crear Insumos";
            this.btnCrearInsumos.UseVisualStyleBackColor = true;
            this.btnCrearInsumos.Click += new System.EventHandler(this.btnCrearInsumos_Click);
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
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 325);
            this.Controls.Add(this.btnCrearNdeIngreso);
            this.Controls.Add(this.btnCrearInsumos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Almacen";
            this.Text = "Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCrearNdeIngreso;
        private System.Windows.Forms.Button btnCrearInsumos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}