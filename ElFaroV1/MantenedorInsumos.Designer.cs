namespace ElFaroV1
{
    partial class MantenedorInsumos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreImsumos = new System.Windows.Forms.TextBox();
            this.CBInsumos = new System.Windows.Forms.ComboBox();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFalse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad De Medida";
            // 
            // txtNombreImsumos
            // 
            this.txtNombreImsumos.Location = new System.Drawing.Point(142, 23);
            this.txtNombreImsumos.Name = "txtNombreImsumos";
            this.txtNombreImsumos.Size = new System.Drawing.Size(256, 20);
            this.txtNombreImsumos.TabIndex = 3;
            // 
            // CBInsumos
            // 
            this.CBInsumos.FormattingEnabled = true;
            this.CBInsumos.Location = new System.Drawing.Point(225, 62);
            this.CBInsumos.Name = "CBInsumos";
            this.CBInsumos.Size = new System.Drawing.Size(173, 21);
            this.CBInsumos.TabIndex = 5;
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Location = new System.Drawing.Point(17, 96);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.Size = new System.Drawing.Size(489, 135);
            this.dgvAlmacen.TabIndex = 6;
            this.dgvAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlmacen_CellContentClick);
            this.dgvAlmacen.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlmacen_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(432, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFalse
            // 
            this.txtFalse.Location = new System.Drawing.Point(142, 23);
            this.txtFalse.Name = "txtFalse";
            this.txtFalse.Size = new System.Drawing.Size(100, 20);
            this.txtFalse.TabIndex = 11;
            // 
            // MantenedorInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 243);
            this.Controls.Add(this.txtNombreImsumos);
            this.Controls.Add(this.txtFalse);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAlmacen);
            this.Controls.Add(this.CBInsumos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenedorInsumos";
            this.Text = "MantenedorInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreImsumos;
        private System.Windows.Forms.ComboBox CBInsumos;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFalse;
    }
}