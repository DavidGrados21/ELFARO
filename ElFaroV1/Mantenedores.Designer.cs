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
            this.btnMantenedorProveedor = new System.Windows.Forms.Button();
            this.btnMantenedorMozo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMantenedorProveedor
            // 
            this.btnMantenedorProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMantenedorProveedor.FlatAppearance.BorderSize = 2;
            this.btnMantenedorProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMantenedorProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMantenedorProveedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedorProveedor.Location = new System.Drawing.Point(48, 93);
            this.btnMantenedorProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMantenedorProveedor.Name = "btnMantenedorProveedor";
            this.btnMantenedorProveedor.Size = new System.Drawing.Size(144, 27);
            this.btnMantenedorProveedor.TabIndex = 3;
            this.btnMantenedorProveedor.Text = " Proveedor";
            this.btnMantenedorProveedor.UseVisualStyleBackColor = true;
            this.btnMantenedorProveedor.Click += new System.EventHandler(this.btnMantenedorProveedor_Click);
            // 
            // btnMantenedorMozo
            // 
            this.btnMantenedorMozo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMantenedorMozo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMantenedorMozo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMantenedorMozo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedorMozo.Location = new System.Drawing.Point(48, 26);
            this.btnMantenedorMozo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMantenedorMozo.Name = "btnMantenedorMozo";
            this.btnMantenedorMozo.Size = new System.Drawing.Size(144, 27);
            this.btnMantenedorMozo.TabIndex = 2;
            this.btnMantenedorMozo.Text = "Mozo";
            this.btnMantenedorMozo.UseVisualStyleBackColor = true;
            this.btnMantenedorMozo.Click += new System.EventHandler(this.btnMantenedorMozo_Click);
            // 
            // Mantenedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(241, 170);
            this.Controls.Add(this.btnMantenedorProveedor);
            this.Controls.Add(this.btnMantenedorMozo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Mantenedores";
            this.Text = "Mantenedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMantenedorProveedor;
        private System.Windows.Forms.Button btnMantenedorMozo;
    }
}