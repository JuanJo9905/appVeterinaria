namespace Veterinaria.View
{
    partial class FormTienda
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
            this.btJuguetes = new System.Windows.Forms.Button();
            this.btAlimento = new System.Windows.Forms.Button();
            this.btCuidado = new System.Windows.Forms.Button();
            this.btMedicina = new System.Windows.Forms.Button();
            this.btAgregarProducto = new System.Windows.Forms.Button();
            this.btAbrirInv = new System.Windows.Forms.Button();
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // btJuguetes
            // 
            this.btJuguetes.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJuguetes.Location = new System.Drawing.Point(33, 41);
            this.btJuguetes.Name = "btJuguetes";
            this.btJuguetes.Size = new System.Drawing.Size(189, 103);
            this.btJuguetes.TabIndex = 0;
            this.btJuguetes.Text = "Juguetes";
            this.btJuguetes.UseVisualStyleBackColor = true;
            this.btJuguetes.Click += new System.EventHandler(this.btJuguetes_Click);
            // 
            // btAlimento
            // 
            this.btAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlimento.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlimento.Location = new System.Drawing.Point(367, 42);
            this.btAlimento.Name = "btAlimento";
            this.btAlimento.Size = new System.Drawing.Size(189, 103);
            this.btAlimento.TabIndex = 1;
            this.btAlimento.Text = "Alimento";
            this.btAlimento.UseVisualStyleBackColor = true;
            this.btAlimento.Click += new System.EventHandler(this.btAlimento_Click);
            // 
            // btCuidado
            // 
            this.btCuidado.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCuidado.Location = new System.Drawing.Point(33, 198);
            this.btCuidado.Name = "btCuidado";
            this.btCuidado.Size = new System.Drawing.Size(189, 103);
            this.btCuidado.TabIndex = 2;
            this.btCuidado.Text = "Cuidados";
            this.btCuidado.UseVisualStyleBackColor = true;
            this.btCuidado.Click += new System.EventHandler(this.btCuidado_Click);
            // 
            // btMedicina
            // 
            this.btMedicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btMedicina.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMedicina.Location = new System.Drawing.Point(367, 198);
            this.btMedicina.Name = "btMedicina";
            this.btMedicina.Size = new System.Drawing.Size(189, 103);
            this.btMedicina.TabIndex = 3;
            this.btMedicina.Text = "Medicinas";
            this.btMedicina.UseVisualStyleBackColor = true;
            this.btMedicina.Click += new System.EventHandler(this.btMedicina_Click);
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgregarProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarProducto.Location = new System.Drawing.Point(644, 398);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(144, 40);
            this.btAgregarProducto.TabIndex = 4;
            this.btAgregarProducto.Text = "Agregar Producto";
            this.btAgregarProducto.UseVisualStyleBackColor = true;
            this.btAgregarProducto.Click += new System.EventHandler(this.btAgregarProducto_Click);
            // 
            // btAbrirInv
            // 
            this.btAbrirInv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbrirInv.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirInv.Location = new System.Drawing.Point(537, 398);
            this.btAbrirInv.Name = "btAbrirInv";
            this.btAbrirInv.Size = new System.Drawing.Size(95, 40);
            this.btAbrirInv.TabIndex = 5;
            this.btAbrirInv.Text = "Inventario";
            this.btAbrirInv.UseVisualStyleBackColor = true;
            this.btAbrirInv.Click += new System.EventHandler(this.btAbrirInv_Click);
            // 
            // gbCategorias
            // 
            this.gbCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategorias.Controls.Add(this.btMedicina);
            this.gbCategorias.Controls.Add(this.btCuidado);
            this.gbCategorias.Controls.Add(this.btAlimento);
            this.gbCategorias.Controls.Add(this.btJuguetes);
            this.gbCategorias.Location = new System.Drawing.Point(114, 41);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(585, 327);
            this.gbCategorias.TabIndex = 6;
            this.gbCategorias.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(716, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "PetShop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbCategorias);
            this.Controls.Add(this.btAbrirInv);
            this.Controls.Add(this.btAgregarProducto);
            this.Name = "FormTienda";
            this.Text = "FormTienda";
            this.gbCategorias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btJuguetes;
        private System.Windows.Forms.Button btAlimento;
        private System.Windows.Forms.Button btCuidado;
        private System.Windows.Forms.Button btMedicina;
        private System.Windows.Forms.Button btAgregarProducto;
        private System.Windows.Forms.Button btAbrirInv;
        private System.Windows.Forms.GroupBox gbCategorias;
        private System.Windows.Forms.Button button2;
    }
}