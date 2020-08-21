namespace Veterinaria.View
{
    partial class FormIngresarMascotas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresarMascotas));
            this.tbNombreMascota = new System.Windows.Forms.TextBox();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            this.tbRaza = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.btRegistrarMascota = new System.Windows.Forms.Button();
            this.btEditId = new System.Windows.Forms.Button();
            this.tbIdprop = new System.Windows.Forms.TextBox();
            this.cbEsterilizado = new System.Windows.Forms.CheckBox();
            this.tbDocumentoProp = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.btRegistrarProp = new System.Windows.Forms.Button();
            this.tbNombreProp = new System.Windows.Forms.TextBox();
            this.tbApellidoProp = new System.Windows.Forms.TextBox();
            this.tbNumeroProp = new System.Windows.Forms.TextBox();
            this.eProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpBuscarId = new System.Windows.Forms.GroupBox();
            this.tbMostrarId = new System.Windows.Forms.TextBox();
            this.btBuscarId = new System.Windows.Forms.Button();
            this.tbIngresarDoc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).BeginInit();
            this.gpBuscarId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombreMascota
            // 
            this.tbNombreMascota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreMascota.Location = new System.Drawing.Point(140, 273);
            this.tbNombreMascota.Name = "tbNombreMascota";
            this.tbNombreMascota.Size = new System.Drawing.Size(135, 29);
            this.tbNombreMascota.TabIndex = 0;
            this.tbNombreMascota.Enter += new System.EventHandler(this.tbNombreMascota_Enter);
            this.tbNombreMascota.Leave += new System.EventHandler(this.tbNombreMascota_Leave);
            // 
            // tbEspecie
            // 
            this.tbEspecie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEspecie.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEspecie.Location = new System.Drawing.Point(311, 273);
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.Size = new System.Drawing.Size(133, 29);
            this.tbEspecie.TabIndex = 1;
            this.tbEspecie.Enter += new System.EventHandler(this.tbEspecie_Enter);
            this.tbEspecie.Leave += new System.EventHandler(this.tbEspecie_Leave);
            // 
            // tbRaza
            // 
            this.tbRaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRaza.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaza.Location = new System.Drawing.Point(471, 273);
            this.tbRaza.Name = "tbRaza";
            this.tbRaza.Size = new System.Drawing.Size(130, 29);
            this.tbRaza.TabIndex = 2;
            this.tbRaza.Enter += new System.EventHandler(this.tbRaza_Enter);
            this.tbRaza.Leave += new System.EventHandler(this.tbRaza_Leave);
            // 
            // tbEdad
            // 
            this.tbEdad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(140, 319);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(135, 29);
            this.tbEdad.TabIndex = 3;
            this.tbEdad.Enter += new System.EventHandler(this.tbEdad_Enter);
            this.tbEdad.Leave += new System.EventHandler(this.tbEdad_Leave);
            // 
            // tbPeso
            // 
            this.tbPeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPeso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPeso.Location = new System.Drawing.Point(311, 319);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(133, 29);
            this.tbPeso.TabIndex = 4;
            this.tbPeso.Enter += new System.EventHandler(this.tbPeso_Enter);
            this.tbPeso.Leave += new System.EventHandler(this.tbPeso_Leave);
            // 
            // btRegistrarMascota
            // 
            this.btRegistrarMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarMascota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRegistrarMascota.BackgroundImage")));
            this.btRegistrarMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegistrarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegistrarMascota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarMascota.Location = new System.Drawing.Point(471, 367);
            this.btRegistrarMascota.Name = "btRegistrarMascota";
            this.btRegistrarMascota.Size = new System.Drawing.Size(130, 29);
            this.btRegistrarMascota.TabIndex = 5;
            this.btRegistrarMascota.Text = "Registrar";
            this.btRegistrarMascota.UseVisualStyleBackColor = true;
            this.btRegistrarMascota.Click += new System.EventHandler(this.btRegistrarMascota_Click);
            // 
            // btEditId
            // 
            this.btEditId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditId.BackgroundImage")));
            this.btEditId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditId.Location = new System.Drawing.Point(570, 319);
            this.btEditId.Name = "btEditId";
            this.btEditId.Size = new System.Drawing.Size(31, 29);
            this.btEditId.TabIndex = 8;
            this.btEditId.UseVisualStyleBackColor = true;
            this.btEditId.Click += new System.EventHandler(this.btEditId_Click);
            // 
            // tbIdprop
            // 
            this.tbIdprop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdprop.Enabled = false;
            this.tbIdprop.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdprop.Location = new System.Drawing.Point(471, 319);
            this.tbIdprop.Name = "tbIdprop";
            this.tbIdprop.ReadOnly = true;
            this.tbIdprop.Size = new System.Drawing.Size(114, 29);
            this.tbIdprop.TabIndex = 9;
            this.tbIdprop.Enter += new System.EventHandler(this.tbIdprop_Enter);
            this.tbIdprop.Leave += new System.EventHandler(this.tbIdprop_Leave);
            // 
            // cbEsterilizado
            // 
            this.cbEsterilizado.AutoSize = true;
            this.cbEsterilizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.cbEsterilizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbEsterilizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEsterilizado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEsterilizado.Location = new System.Drawing.Point(140, 370);
            this.cbEsterilizado.Name = "cbEsterilizado";
            this.cbEsterilizado.Size = new System.Drawing.Size(105, 26);
            this.cbEsterilizado.TabIndex = 7;
            this.cbEsterilizado.Text = "Esterilizado";
            this.cbEsterilizado.UseVisualStyleBackColor = false;
            // 
            // tbDocumentoProp
            // 
            this.tbDocumentoProp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDocumentoProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocumentoProp.Location = new System.Drawing.Point(311, 145);
            this.tbDocumentoProp.Name = "tbDocumentoProp";
            this.tbDocumentoProp.Size = new System.Drawing.Size(133, 29);
            this.tbDocumentoProp.TabIndex = 8;
            this.tbDocumentoProp.Enter += new System.EventHandler(this.tbDocumentoProp_Enter);
            this.tbDocumentoProp.Leave += new System.EventHandler(this.tbDocumentoProp_Leave);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(140, 148);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(135, 29);
            this.tbDireccion.TabIndex = 7;
            this.tbDireccion.Enter += new System.EventHandler(this.tbDireccion_Enter);
            this.tbDireccion.Leave += new System.EventHandler(this.tbDireccion_Leave);
            // 
            // btRegistrarProp
            // 
            this.btRegistrarProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.btRegistrarProp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRegistrarProp.BackgroundImage")));
            this.btRegistrarProp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegistrarProp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegistrarProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarProp.Location = new System.Drawing.Point(471, 142);
            this.btRegistrarProp.Name = "btRegistrarProp";
            this.btRegistrarProp.Size = new System.Drawing.Size(133, 29);
            this.btRegistrarProp.TabIndex = 5;
            this.btRegistrarProp.Text = "Registrar";
            this.btRegistrarProp.UseVisualStyleBackColor = false;
            this.btRegistrarProp.Click += new System.EventHandler(this.btRegistrarProp_Click);
            // 
            // tbNombreProp
            // 
            this.tbNombreProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreProp.Location = new System.Drawing.Point(140, 104);
            this.tbNombreProp.Name = "tbNombreProp";
            this.tbNombreProp.Size = new System.Drawing.Size(135, 29);
            this.tbNombreProp.TabIndex = 0;
            this.tbNombreProp.Enter += new System.EventHandler(this.tbNombreProp_Enter);
            this.tbNombreProp.Leave += new System.EventHandler(this.tbNombreProp_Leave);
            // 
            // tbApellidoProp
            // 
            this.tbApellidoProp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbApellidoProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoProp.Location = new System.Drawing.Point(311, 104);
            this.tbApellidoProp.Name = "tbApellidoProp";
            this.tbApellidoProp.Size = new System.Drawing.Size(133, 29);
            this.tbApellidoProp.TabIndex = 1;
            this.tbApellidoProp.Enter += new System.EventHandler(this.tbApellidoProp_Enter);
            this.tbApellidoProp.Leave += new System.EventHandler(this.tbApellidoProp_Leave);
            // 
            // tbNumeroProp
            // 
            this.tbNumeroProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumeroProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroProp.Location = new System.Drawing.Point(471, 104);
            this.tbNumeroProp.Name = "tbNumeroProp";
            this.tbNumeroProp.Size = new System.Drawing.Size(133, 29);
            this.tbNumeroProp.TabIndex = 2;
            this.tbNumeroProp.Enter += new System.EventHandler(this.tbNumeroProp_Enter);
            this.tbNumeroProp.Leave += new System.EventHandler(this.tbNumeroProp_Leave);
            // 
            // eProvider
            // 
            this.eProvider.ContainerControl = this;
            // 
            // gpBuscarId
            // 
            this.gpBuscarId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBuscarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(149)))), ((int)(((byte)(186)))));
            this.gpBuscarId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpBuscarId.BackgroundImage")));
            this.gpBuscarId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpBuscarId.Controls.Add(this.tbMostrarId);
            this.gpBuscarId.Controls.Add(this.btBuscarId);
            this.gpBuscarId.Controls.Add(this.tbIngresarDoc);
            this.gpBuscarId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBuscarId.Location = new System.Drawing.Point(651, 142);
            this.gpBuscarId.Name = "gpBuscarId";
            this.gpBuscarId.Size = new System.Drawing.Size(145, 182);
            this.gpBuscarId.TabIndex = 8;
            this.gpBuscarId.TabStop = false;
            this.gpBuscarId.Text = "Buscar Id";
            // 
            // tbMostrarId
            // 
            this.tbMostrarId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMostrarId.Enabled = false;
            this.tbMostrarId.Location = new System.Drawing.Point(6, 147);
            this.tbMostrarId.Name = "tbMostrarId";
            this.tbMostrarId.ReadOnly = true;
            this.tbMostrarId.Size = new System.Drawing.Size(133, 29);
            this.tbMostrarId.TabIndex = 2;
            // 
            // btBuscarId
            // 
            this.btBuscarId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscarId.BackgroundImage")));
            this.btBuscarId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscarId.Location = new System.Drawing.Point(6, 97);
            this.btBuscarId.Name = "btBuscarId";
            this.btBuscarId.Size = new System.Drawing.Size(133, 29);
            this.btBuscarId.TabIndex = 1;
            this.btBuscarId.Text = "Buscar";
            this.btBuscarId.UseVisualStyleBackColor = true;
            this.btBuscarId.Click += new System.EventHandler(this.btBuscarId_Click);
            // 
            // tbIngresarDoc
            // 
            this.tbIngresarDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIngresarDoc.Location = new System.Drawing.Point(6, 48);
            this.tbIngresarDoc.Name = "tbIngresarDoc";
            this.tbIngresarDoc.Size = new System.Drawing.Size(133, 29);
            this.tbIngresarDoc.TabIndex = 0;
            this.tbIngresarDoc.Enter += new System.EventHandler(this.tbIngresarDoc_Enter);
            this.tbIngresarDoc.Leave += new System.EventHandler(this.tbIngresarDoc_Leave);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(794, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Datos propietario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Datos mascota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 433);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormIngresarMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditId);
            this.Controls.Add(this.tbDocumentoProp);
            this.Controls.Add(this.tbIdprop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbEsterilizado);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.btRegistrarMascota);
            this.Controls.Add(this.gpBuscarId);
            this.Controls.Add(this.tbNombreMascota);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.btRegistrarProp);
            this.Controls.Add(this.tbEspecie);
            this.Controls.Add(this.tbNombreProp);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbApellidoProp);
            this.Controls.Add(this.tbRaza);
            this.Controls.Add(this.tbNumeroProp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormIngresarMascotas";
            this.Text = "FormIngresarMascotas";
            this.Load += new System.EventHandler(this.FormIngresarMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).EndInit();
            this.gpBuscarId.ResumeLayout(false);
            this.gpBuscarId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombreMascota;
        private System.Windows.Forms.TextBox tbEspecie;
        private System.Windows.Forms.TextBox tbRaza;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Button btRegistrarMascota;
        private System.Windows.Forms.Button btRegistrarProp;
        private System.Windows.Forms.TextBox tbNombreProp;
        private System.Windows.Forms.TextBox tbApellidoProp;
        private System.Windows.Forms.TextBox tbNumeroProp;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbDocumentoProp;
        private System.Windows.Forms.CheckBox cbEsterilizado;
        private System.Windows.Forms.ErrorProvider eProvider;
        private System.Windows.Forms.Button btEditId;
        private System.Windows.Forms.TextBox tbIdprop;
        private System.Windows.Forms.GroupBox gpBuscarId;
        private System.Windows.Forms.TextBox tbMostrarId;
        private System.Windows.Forms.Button btBuscarId;
        private System.Windows.Forms.TextBox tbIngresarDoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}