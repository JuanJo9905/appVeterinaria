﻿namespace Veterinaria.View
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBuscarProd = new System.Windows.Forms.TextBox();
            this.btBuscarProd = new System.Windows.Forms.Button();
            this.cbSelCategoria = new System.Windows.Forms.ComboBox();
            this.btShowProducts = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btGuardarCambios = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.tbBuscarProd);
            this.panel3.Controls.Add(this.btBuscarProd);
            this.panel3.Controls.Add(this.cbSelCategoria);
            this.panel3.Controls.Add(this.btShowProducts);
            this.panel3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(297, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 44);
            this.panel3.TabIndex = 24;
            // 
            // tbBuscarProd
            // 
            this.tbBuscarProd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarProd.Location = new System.Drawing.Point(3, 3);
            this.tbBuscarProd.Name = "tbBuscarProd";
            this.tbBuscarProd.Size = new System.Drawing.Size(143, 33);
            this.tbBuscarProd.TabIndex = 13;
            this.tbBuscarProd.Text = "Buscar Producto";
            this.tbBuscarProd.Enter += new System.EventHandler(this.tbBuscarProd_Enter);
            this.tbBuscarProd.Leave += new System.EventHandler(this.tbBuscarProd_Leave);
            // 
            // btBuscarProd
            // 
            this.btBuscarProd.AutoSize = true;
            this.btBuscarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btBuscarProd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarProd.Location = new System.Drawing.Point(152, 3);
            this.btBuscarProd.Name = "btBuscarProd";
            this.btBuscarProd.Size = new System.Drawing.Size(78, 36);
            this.btBuscarProd.TabIndex = 15;
            this.btBuscarProd.Text = "Buscar";
            this.btBuscarProd.UseVisualStyleBackColor = false;
            this.btBuscarProd.Click += new System.EventHandler(this.btBuscarProd_Click);
            // 
            // cbSelCategoria
            // 
            this.cbSelCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelCategoria.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelCategoria.FormattingEnabled = true;
            this.cbSelCategoria.Location = new System.Drawing.Point(252, 5);
            this.cbSelCategoria.Name = "cbSelCategoria";
            this.cbSelCategoria.Size = new System.Drawing.Size(114, 34);
            this.cbSelCategoria.TabIndex = 12;
            // 
            // btShowProducts
            // 
            this.btShowProducts.AutoSize = true;
            this.btShowProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btShowProducts.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowProducts.Location = new System.Drawing.Point(372, 5);
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
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(125)))), ((int)(((byte)(103)))));
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
            this.btGuardarCambios.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarCambios.Location = new System.Drawing.Point(657, 363);
            this.btGuardarCambios.Name = "btGuardarCambios";
            this.btGuardarCambios.Size = new System.Drawing.Size(128, 75);
            this.btGuardarCambios.TabIndex = 25;
            this.btGuardarCambios.Text = "Guardar ";
            this.btGuardarCambios.UseVisualStyleBackColor = false;
            this.btGuardarCambios.Click += new System.EventHandler(this.btGuardarCambios_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGuardarCambios);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panel3);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbBuscarProd;
        private System.Windows.Forms.Button btBuscarProd;
        private System.Windows.Forms.ComboBox cbSelCategoria;
        private System.Windows.Forms.Button btShowProducts;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btGuardarCambios;
    }
}