namespace ElFaroV1
{
    partial class ISMozo
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
            this.btnIS = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIS
            // 
            this.btnIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIS.Location = new System.Drawing.Point(60, 192);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(172, 41);
            this.btnIS.TabIndex = 9;
            this.btnIS.Text = "Iniciar Sesion";
            this.btnIS.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(12, 146);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(263, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(263, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "CODIGO";
            // 
            // ISMozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(287, 253);
            this.Controls.Add(this.btnIS);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ISMozo";
            this.Text = "ISMozo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIS;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}