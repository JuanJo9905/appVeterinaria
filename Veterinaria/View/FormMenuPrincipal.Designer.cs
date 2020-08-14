namespace Veterinaria.View
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.lbTipo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btSalir = new System.Windows.Forms.Button();
            this.btSoloVer = new System.Windows.Forms.Button();
            this.btTipo = new System.Windows.Forms.Button();
            this.btTienda = new System.Windows.Forms.Button();
            this.btVerHistorial = new System.Windows.Forms.Button();
            this.btVerMascota = new System.Windows.Forms.Button();
            this.btIngresarMascota = new System.Windows.Forms.Button();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(12, 9);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(0, 13);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.btSalir);
            this.pnlMenu.Controls.Add(this.btSoloVer);
            this.pnlMenu.Controls.Add(this.btTipo);
            this.pnlMenu.Controls.Add(this.btTienda);
            this.pnlMenu.Controls.Add(this.lbTipo);
            this.pnlMenu.Controls.Add(this.btVerHistorial);
            this.pnlMenu.Controls.Add(this.btVerMascota);
            this.pnlMenu.Controls.Add(this.btIngresarMascota);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 450);
            this.pnlMenu.TabIndex = 1;
            // 
            // btSalir
            // 
            this.btSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalir.BackgroundImage")));
            this.btSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(25, 391);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(152, 47);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btSoloVer
            // 
            this.btSoloVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSoloVer.BackgroundImage")));
            this.btSoloVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSoloVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSoloVer.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoloVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSoloVer.ImageKey = "(ninguno)";
            this.btSoloVer.Location = new System.Drawing.Point(25, 171);
            this.btSoloVer.Name = "btSoloVer";
            this.btSoloVer.Size = new System.Drawing.Size(152, 47);
            this.btSoloVer.TabIndex = 5;
            this.btSoloVer.Text = "Ver mascota";
            this.btSoloVer.UseVisualStyleBackColor = true;
            this.btSoloVer.Click += new System.EventHandler(this.btVerMascAdmin);
            // 
            // btTipo
            // 
            this.btTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTipo.BackgroundImage")));
            this.btTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTipo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTipo.Location = new System.Drawing.Point(25, 26);
            this.btTipo.Name = "btTipo";
            this.btTipo.Size = new System.Drawing.Size(152, 60);
            this.btTipo.TabIndex = 4;
            this.btTipo.UseVisualStyleBackColor = false;
            // 
            // btTienda
            // 
            this.btTienda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTienda.BackgroundImage")));
            this.btTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTienda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTienda.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTienda.Location = new System.Drawing.Point(25, 277);
            this.btTienda.Name = "btTienda";
            this.btTienda.Size = new System.Drawing.Size(152, 47);
            this.btTienda.TabIndex = 3;
            this.btTienda.Text = "Tienda";
            this.btTienda.UseVisualStyleBackColor = true;
            this.btTienda.Click += new System.EventHandler(this.btTienda_Click);
            // 
            // btVerHistorial
            // 
            this.btVerHistorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVerHistorial.BackgroundImage")));
            this.btVerHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVerHistorial.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerHistorial.Location = new System.Drawing.Point(25, 224);
            this.btVerHistorial.Name = "btVerHistorial";
            this.btVerHistorial.Size = new System.Drawing.Size(152, 47);
            this.btVerHistorial.TabIndex = 2;
            this.btVerHistorial.Text = "Historias C.";
            this.btVerHistorial.UseVisualStyleBackColor = true;
            this.btVerHistorial.Click += new System.EventHandler(this.btVerHistorial_Click);
            // 
            // btVerMascota
            // 
            this.btVerMascota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVerMascota.BackgroundImage")));
            this.btVerMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVerMascota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVerMascota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerMascota.Location = new System.Drawing.Point(25, 171);
            this.btVerMascota.Name = "btVerMascota";
            this.btVerMascota.Size = new System.Drawing.Size(152, 47);
            this.btVerMascota.TabIndex = 1;
            this.btVerMascota.Text = "Ver mascota";
            this.btVerMascota.UseVisualStyleBackColor = true;
            this.btVerMascota.Click += new System.EventHandler(this.btVerMascota_Click);
            // 
            // btIngresarMascota
            // 
            this.btIngresarMascota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIngresarMascota.BackgroundImage")));
            this.btIngresarMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btIngresarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIngresarMascota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresarMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIngresarMascota.Location = new System.Drawing.Point(25, 118);
            this.btIngresarMascota.Name = "btIngresarMascota";
            this.btIngresarMascota.Size = new System.Drawing.Size(152, 47);
            this.btIngresarMascota.TabIndex = 0;
            this.btIngresarMascota.Text = "Ingresar mascota";
            this.btIngresarMascota.UseVisualStyleBackColor = true;
            this.btIngresarMascota.Click += new System.EventHandler(this.btIngresarMascota_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlForms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlForms.BackgroundImage")));
            this.pnlForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(200, 0);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(600, 450);
            this.pnlForms.TabIndex = 2;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormMenuPrincipal";
            this.Text = "Historiales";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btTienda;
        private System.Windows.Forms.Button btVerHistorial;
        private System.Windows.Forms.Button btIngresarMascota;
        private System.Windows.Forms.Panel pnlForms;
        public System.Windows.Forms.Button btTipo;
        private System.Windows.Forms.Button btVerMascota;
        private System.Windows.Forms.Button btSoloVer;
        private System.Windows.Forms.Button btSalir;
    }
}