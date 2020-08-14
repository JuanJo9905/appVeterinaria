namespace Veterinaria.View
{
    partial class FormFactura
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
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.lbDetalles = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbIdfact = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(35, 69);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(555, 150);
            this.dgvDetalles.TabIndex = 1;
            // 
            // lbDetalles
            // 
            this.lbDetalles.AutoSize = true;
            this.lbDetalles.Location = new System.Drawing.Point(36, 32);
            this.lbDetalles.Name = "lbDetalles";
            this.lbDetalles.Size = new System.Drawing.Size(45, 13);
            this.lbDetalles.TabIndex = 2;
            this.lbDetalles.Text = "Detalles";
            this.lbDetalles.Visible = false;
            // 
            // tbFecha
            // 
            this.tbFecha.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFecha.Location = new System.Drawing.Point(35, 34);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.ReadOnly = true;
            this.tbFecha.Size = new System.Drawing.Size(100, 29);
            this.tbFecha.TabIndex = 3;
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(490, 225);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 29);
            this.tbTotal.TabIndex = 4;
            // 
            // lbIdfact
            // 
            this.lbIdfact.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbIdfact.AutoSize = true;
            this.lbIdfact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIdfact.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdfact.Location = new System.Drawing.Point(284, 277);
            this.lbIdfact.Name = "lbIdfact";
            this.lbIdfact.Size = new System.Drawing.Size(77, 24);
            this.lbIdfact.TabIndex = 5;
            this.lbIdfact.Text = "ldFactura";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.lbIdfact);
            this.groupBox1.Controls.Add(this.tbFecha);
            this.groupBox1.Controls.Add(this.dgvDetalles);
            this.groupBox1.Location = new System.Drawing.Point(71, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 314);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDetalles);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetalles;
        public System.Windows.Forms.Label lbDetalles;
        private System.Windows.Forms.TextBox tbFecha;
        public System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbIdfact;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}