namespace Veterinaria.View
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.tbBuscarProd = new System.Windows.Forms.TextBox();
            this.btBuscarProd = new System.Windows.Forms.Button();
            this.cbSelCategoria = new System.Windows.Forms.ComboBox();
            this.btShowProducts = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btGuardarCambios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBuscarProd
            // 
            this.tbBuscarProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbBuscarProd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarProd.Location = new System.Drawing.Point(302, 41);
            this.tbBuscarProd.Name = "tbBuscarProd";
            this.tbBuscarProd.Size = new System.Drawing.Size(143, 33);
            this.tbBuscarProd.TabIndex = 13;
            this.tbBuscarProd.Text = "Buscar Producto";
            this.tbBuscarProd.Enter += new System.EventHandler(this.tbBuscarProd_Enter);
            this.tbBuscarProd.Leave += new System.EventHandler(this.tbBuscarProd_Leave);
            // 
            // btBuscarProd
            // 
            this.btBuscarProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btBuscarProd.AutoSize = true;
            this.btBuscarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btBuscarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscarProd.BackgroundImage")));
            this.btBuscarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscarProd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarProd.Location = new System.Drawing.Point(451, 38);
            this.btBuscarProd.Name = "btBuscarProd";
            this.btBuscarProd.Size = new System.Drawing.Size(80, 38);
            this.btBuscarProd.TabIndex = 15;
            this.btBuscarProd.Text = "Buscar";
            this.btBuscarProd.UseVisualStyleBackColor = false;
            this.btBuscarProd.Click += new System.EventHandler(this.btBuscarProd_Click);
            // 
            // cbSelCategoria
            // 
            this.cbSelCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbSelCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cbSelCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelCategoria.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelCategoria.FormattingEnabled = true;
            this.cbSelCategoria.Location = new System.Drawing.Point(549, 42);
            this.cbSelCategoria.Name = "cbSelCategoria";
            this.cbSelCategoria.Size = new System.Drawing.Size(114, 34);
            this.cbSelCategoria.TabIndex = 12;
            // 
            // btShowProducts
            // 
            this.btShowProducts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btShowProducts.AutoSize = true;
            this.btShowProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btShowProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btShowProducts.BackgroundImage")));
            this.btShowProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btShowProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btShowProducts.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowProducts.Location = new System.Drawing.Point(669, 40);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(116, 36);
            this.btShowProducts.TabIndex = 14;
            this.btShowProducts.Text = "Mostrar";
            this.btShowProducts.UseVisualStyleBackColor = false;
            this.btShowProducts.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.Color.Salmon;
            this.dgvProductos.Location = new System.Drawing.Point(12, 82);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(773, 268);
            this.dgvProductos.TabIndex = 17;
            // 
            // btGuardarCambios
            // 
            this.btGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardarCambios.AutoSize = true;
            this.btGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btGuardarCambios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGuardarCambios.BackgroundImage")));
            this.btGuardarCambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGuardarCambios.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarCambios.Location = new System.Drawing.Point(657, 363);
            this.btGuardarCambios.Name = "btGuardarCambios";
            this.btGuardarCambios.Size = new System.Drawing.Size(128, 75);
            this.btGuardarCambios.TabIndex = 25;
            this.btGuardarCambios.Text = "Guardar ";
            this.btGuardarCambios.UseVisualStyleBackColor = false;
            this.btGuardarCambios.Click += new System.EventHandler(this.btGuardarCambios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btShowProducts);
            this.Controls.Add(this.cbSelCategoria);
            this.Controls.Add(this.btBuscarProd);
            this.Controls.Add(this.tbBuscarProd);
            this.Controls.Add(this.btGuardarCambios);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBuscarProd;
        private System.Windows.Forms.Button btBuscarProd;
        private System.Windows.Forms.ComboBox cbSelCategoria;
        private System.Windows.Forms.Button btShowProducts;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btGuardarCambios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}