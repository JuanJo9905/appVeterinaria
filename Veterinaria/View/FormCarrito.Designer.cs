﻿namespace Veterinaria.View
{
    partial class FormCarrito
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
            this.lbTotFact = new System.Windows.Forms.Label();
            this.btFact = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btMostrarProductos = new System.Windows.Forms.Button();
            this.cbSubcategorias = new System.Windows.Forms.ComboBox();
            this.btBuscarProducto = new System.Windows.Forms.Button();
            this.tbBuscarProducto = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbCarrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTotFact
            // 
            this.lbTotFact.AutoSize = true;
            this.lbTotFact.Location = new System.Drawing.Point(18, 396);
            this.lbTotFact.Name = "lbTotFact";
            this.lbTotFact.Size = new System.Drawing.Size(70, 13);
            this.lbTotFact.TabIndex = 34;
            this.lbTotFact.Text = "Total Factura";
            // 
            // btFact
            // 
            this.btFact.AutoSize = true;
            this.btFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.btFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFact.Location = new System.Drawing.Point(9, 327);
            this.btFact.Name = "btFact";
            this.btFact.Size = new System.Drawing.Size(117, 50);
            this.btFact.TabIndex = 33;
            this.btFact.Text = "Facturar";
            this.btFact.UseVisualStyleBackColor = false;
            this.btFact.Click += new System.EventHandler(this.btFact_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(476, 327);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(129, 45);
            this.btAgregar.TabIndex = 32;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAddToCar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(482, 385);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(65, 28);
            this.lbTotal.TabIndex = 31;
            this.lbTotal.Text = "Total:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(147)))), ((int)(((byte)(129)))));
            this.dgvProductos.Location = new System.Drawing.Point(6, 17);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(601, 304);
            this.dgvProductos.TabIndex = 30;
            // 
            // btMostrarProductos
            // 
            this.btMostrarProductos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btMostrarProductos.BackColor = System.Drawing.Color.Transparent;
            this.btMostrarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMostrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrarProductos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrarProductos.Location = new System.Drawing.Point(44, 247);
            this.btMostrarProductos.Name = "btMostrarProductos";
            this.btMostrarProductos.Size = new System.Drawing.Size(75, 36);
            this.btMostrarProductos.TabIndex = 38;
            this.btMostrarProductos.Text = "Mostrar";
            this.btMostrarProductos.UseVisualStyleBackColor = false;
            this.btMostrarProductos.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // cbSubcategorias
            // 
            this.cbSubcategorias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSubcategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubcategorias.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubcategorias.FormattingEnabled = true;
            this.cbSubcategorias.Location = new System.Drawing.Point(16, 211);
            this.cbSubcategorias.Name = "cbSubcategorias";
            this.cbSubcategorias.Size = new System.Drawing.Size(130, 30);
            this.cbSubcategorias.TabIndex = 36;
            // 
            // btBuscarProducto
            // 
            this.btBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarProducto.Location = new System.Drawing.Point(44, 134);
            this.btBuscarProducto.Name = "btBuscarProducto";
            this.btBuscarProducto.Size = new System.Drawing.Size(75, 33);
            this.btBuscarProducto.TabIndex = 39;
            this.btBuscarProducto.Text = "Buscar";
            this.btBuscarProducto.UseVisualStyleBackColor = true;
            this.btBuscarProducto.Click += new System.EventHandler(this.btSearchProduct_Click);
            // 
            // tbBuscarProducto
            // 
            this.tbBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbBuscarProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarProducto.Location = new System.Drawing.Point(16, 103);
            this.tbBuscarProducto.Name = "tbBuscarProducto";
            this.tbBuscarProducto.Size = new System.Drawing.Size(130, 29);
            this.tbBuscarProducto.TabIndex = 37;
            this.tbBuscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBuscarProducto.Enter += new System.EventHandler(this.tbBuscarProducto_Enter);
            this.tbBuscarProducto.Leave += new System.EventHandler(this.tbBuscarProducto_Leave);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbCategoria.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(8, 29);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(0, 44);
            this.lbCategoria.TabIndex = 40;
            // 
            // gbCarrito
            // 
            this.gbCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCarrito.Controls.Add(this.dgvProductos);
            this.gbCarrito.Controls.Add(this.btFact);
            this.gbCarrito.Controls.Add(this.lbTotFact);
            this.gbCarrito.Controls.Add(this.btAgregar);
            this.gbCarrito.Controls.Add(this.lbTotal);
            this.gbCarrito.Location = new System.Drawing.Point(168, 12);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(620, 426);
            this.gbCarrito.TabIndex = 41;
            this.gbCarrito.TabStop = false;
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.btMostrarProductos);
            this.Controls.Add(this.cbSubcategorias);
            this.Controls.Add(this.btBuscarProducto);
            this.Controls.Add(this.tbBuscarProducto);
            this.Controls.Add(this.gbCarrito);
            this.Name = "FormCarrito";
            this.Text = "FormCarrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbCarrito.ResumeLayout(false);
            this.gbCarrito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbTotFact;
        private System.Windows.Forms.Button btFact;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btMostrarProductos;
        private System.Windows.Forms.ComboBox cbSubcategorias;
        private System.Windows.Forms.Button btBuscarProducto;
        private System.Windows.Forms.TextBox tbBuscarProducto;
        private System.Windows.Forms.GroupBox gbCarrito;
        public System.Windows.Forms.Label lbCategoria;
    }
}