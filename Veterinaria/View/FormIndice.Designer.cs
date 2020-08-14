namespace Veterinaria.View
{
    partial class FormIndice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbNuevoUsuario = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lbNuevoUsuario);
            this.groupBox1.Controls.Add(this.btIngresar);
            this.groupBox1.Controls.Add(this.tbContraseña);
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(260, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btIngresar
            // 
            this.btIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btIngresar.AutoSize = true;
            this.btIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIngresar.BackgroundImage")));
            this.btIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.Location = new System.Drawing.Point(91, 183);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(80, 34);
            this.btIngresar.TabIndex = 1;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbContraseña.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.Location = new System.Drawing.Point(57, 122);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(152, 29);
            this.tbContraseña.TabIndex = 2;
            this.tbContraseña.Enter += new System.EventHandler(this.tbContraseña_Enter);
            this.tbContraseña.Leave += new System.EventHandler(this.tbContraseña_Leave);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUsuario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(57, 41);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(152, 29);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Enter += new System.EventHandler(this.tbUsuario_Enter);
            this.tbUsuario.Leave += new System.EventHandler(this.tbUsuario_Leave);
            // 
            // lbNuevoUsuario
            // 
            this.lbNuevoUsuario.AutoSize = true;
            this.lbNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lbNuevoUsuario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoUsuario.Location = new System.Drawing.Point(73, 231);
            this.lbNuevoUsuario.Name = "lbNuevoUsuario";
            this.lbNuevoUsuario.Size = new System.Drawing.Size(123, 22);
            this.lbNuevoUsuario.TabIndex = 3;
            this.lbNuevoUsuario.TabStop = true;
            this.lbNuevoUsuario.Text = "¿Nuevo usuario?";
            this.lbNuevoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbNuevoUsuario_LinkClicked);
            // 
            // FormIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FormIndice";
            this.Text = "FormIndice";
            this.Load += new System.EventHandler(this.Indice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.LinkLabel lbNuevoUsuario;
    }
}