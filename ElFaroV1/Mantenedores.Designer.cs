namespace ElFaroV1
{
    partial class Mantenedores
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
            this.btnMantenedorMozo = new System.Windows.Forms.Button();
            this.btnMantenedorProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMantenedorMozo
            // 
            this.btnMantenedorMozo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenedorMozo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedorMozo.Location = new System.Drawing.Point(33, 28);
            this.btnMantenedorMozo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMantenedorMozo.Name = "btnMantenedorMozo";
            this.btnMantenedorMozo.Size = new System.Drawing.Size(144, 27);
            this.btnMantenedorMozo.TabIndex = 0;
            this.btnMantenedorMozo.Text = "Mozo";
            this.btnMantenedorMozo.UseVisualStyleBackColor = true;
            this.btnMantenedorMozo.Click += new System.EventHandler(this.btnMantenedorMozo_Click);
            // 
            // btnMantenedorProveedor
            // 
            this.btnMantenedorProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenedorProveedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedorProveedor.Location = new System.Drawing.Point(33, 85);
            this.btnMantenedorProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMantenedorProveedor.Name = "btnMantenedorProveedor";
            this.btnMantenedorProveedor.Size = new System.Drawing.Size(144, 27);
            this.btnMantenedorProveedor.TabIndex = 1;
            this.btnMantenedorProveedor.Text = " Proveedor";
            this.btnMantenedorProveedor.UseVisualStyleBackColor = true;
            this.btnMantenedorProveedor.Click += new System.EventHandler(this.btnMantenedorProveedor_Click);
            // 
            // Mantenedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(213, 190);
            this.Controls.Add(this.btnMantenedorProveedor);
            this.Controls.Add(this.btnMantenedorMozo);
            this.Font = new System.Drawing.Font("MT Extra", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Mantenedores";
            this.Text = "Mantenedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMantenedorMozo;
        private System.Windows.Forms.Button btnMantenedorProveedor;
    }
}