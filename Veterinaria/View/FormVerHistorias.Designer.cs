namespace Veterinaria.View
{
    partial class FormVerHistorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerHistorias));
            this.tbIdMasota = new System.Windows.Forms.TextBox();
            this.btBuscarHistorias = new System.Windows.Forms.Button();
            this.dgvHistoriaClinica = new System.Windows.Forms.DataGridView();
            this.dgvHistoriaMedicinas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.btGenerarPdfHis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaMedicinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdMasota
            // 
            this.tbIdMasota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdMasota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdMasota.Location = new System.Drawing.Point(515, 51);
            this.tbIdMasota.Name = "tbIdMasota";
            this.tbIdMasota.Size = new System.Drawing.Size(140, 29);
            this.tbIdMasota.TabIndex = 0;
            // 
            // btBuscarHistorias
            // 
            this.btBuscarHistorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarHistorias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscarHistorias.BackgroundImage")));
            this.btBuscarHistorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarHistorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarHistorias.Location = new System.Drawing.Point(650, 51);
            this.btBuscarHistorias.Name = "btBuscarHistorias";
            this.btBuscarHistorias.Size = new System.Drawing.Size(28, 29);
            this.btBuscarHistorias.TabIndex = 16;
            this.btBuscarHistorias.UseVisualStyleBackColor = true;
            this.btBuscarHistorias.Click += new System.EventHandler(this.btBuscarHistorias_Click);
            // 
            // dgvHistoriaClinica
            // 
            this.dgvHistoriaClinica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoriaClinica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoriaClinica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.dgvHistoriaClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriaClinica.Location = new System.Drawing.Point(49, 86);
            this.dgvHistoriaClinica.Name = "dgvHistoriaClinica";
            this.dgvHistoriaClinica.Size = new System.Drawing.Size(629, 150);
            this.dgvHistoriaClinica.TabIndex = 1;
            // 
            // dgvHistoriaMedicinas
            // 
            this.dgvHistoriaMedicinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoriaMedicinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoriaMedicinas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.dgvHistoriaMedicinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriaMedicinas.Location = new System.Drawing.Point(49, 310);
            this.dgvHistoriaMedicinas.Name = "dgvHistoriaMedicinas";
            this.dgvHistoriaMedicinas.Size = new System.Drawing.Size(629, 150);
            this.dgvHistoriaMedicinas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID Mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 49);
            this.label2.TabIndex = 18;
            this.label2.Text = "Historias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 49);
            this.label3.TabIndex = 19;
            this.label3.Text = "Medicamentos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 460);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btGenerar
            // 
            this.btGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGenerar.BackgroundImage")));
            this.btGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGenerar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerar.Location = new System.Drawing.Point(696, 383);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(75, 37);
            this.btGenerar.TabIndex = 21;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // btGenerarPdfHis
            // 
            this.btGenerarPdfHis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGenerarPdfHis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGenerarPdfHis.BackgroundImage")));
            this.btGenerarPdfHis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGenerarPdfHis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGenerarPdfHis.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerarPdfHis.Location = new System.Drawing.Point(696, 162);
            this.btGenerarPdfHis.Name = "btGenerarPdfHis";
            this.btGenerarPdfHis.Size = new System.Drawing.Size(75, 37);
            this.btGenerarPdfHis.TabIndex = 22;
            this.btGenerarPdfHis.Text = "Generar";
            this.btGenerarPdfHis.UseVisualStyleBackColor = true;
            this.btGenerarPdfHis.Click += new System.EventHandler(this.btGenerarPdfHis_Click);
            // 
            // FormVerHistorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGenerarPdfHis);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBuscarHistorias);
            this.Controls.Add(this.tbIdMasota);
            this.Controls.Add(this.dgvHistoriaMedicinas);
            this.Controls.Add(this.dgvHistoriaClinica);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormVerHistorias";
            this.Text = "Generar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaMedicinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbIdMasota;
        private System.Windows.Forms.Button btBuscarHistorias;
        private System.Windows.Forms.DataGridView dgvHistoriaClinica;
        private System.Windows.Forms.DataGridView dgvHistoriaMedicinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Button btGenerarPdfHis;
    }
}