namespace Veterinaria.View
{
    partial class FormVerMascotaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerMascotaAdmin));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.gbMedicamentos = new System.Windows.Forms.GroupBox();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.gbEstadoMasc = new System.Windows.Forms.GroupBox();
            this.tbEstadoActual = new System.Windows.Forms.RichTextBox();
            this.gbMotivoConsulta = new System.Windows.Forms.GroupBox();
            this.tbMotivoConsulta = new System.Windows.Forms.RichTextBox();
            this.gbTratamiento = new System.Windows.Forms.GroupBox();
            this.tbTratamiento = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreProp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbApellidoProp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreMasc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEsterilizado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDireccionProp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdMasc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNumeroProp = new System.Windows.Forms.TextBox();
            this.tbIdProp = new System.Windows.Forms.TextBox();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbOpcMascota = new System.Windows.Forms.GroupBox();
            this.btVista = new System.Windows.Forms.Button();
            this.btBuscarHistoria = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.tbBuscarHistoria = new System.Windows.Forms.TextBox();
            this.btGuardarCambios = new System.Windows.Forms.Button();
            this.btVerUltHistoria = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.btBuscarMascs = new System.Windows.Forms.Button();
            this.btBuscarMascota = new System.Windows.Forms.Button();
            this.cbNombreMascotas = new System.Windows.Forms.ComboBox();
            this.tbDocumentoProp = new System.Windows.Forms.TextBox();
            this.eProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBack.SuspendLayout();
            this.gbMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.gbEstadoMasc.SuspendLayout();
            this.gbMotivoConsulta.SuspendLayout();
            this.gbTratamiento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOpcMascota.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.AutoScroll = true;
            this.pnlBack.Controls.Add(this.button2);
            this.pnlBack.Controls.Add(this.gbMedicamentos);
            this.pnlBack.Controls.Add(this.gbEstadoMasc);
            this.pnlBack.Controls.Add(this.gbMotivoConsulta);
            this.pnlBack.Controls.Add(this.gbTratamiento);
            this.pnlBack.Controls.Add(this.groupBox1);
            this.pnlBack.Controls.Add(this.gbOpcMascota);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 56);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(800, 394);
            this.pnlBack.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(708, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "PetShop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbMedicamentos
            // 
            this.gbMedicamentos.Controls.Add(this.dgvMedicamentos);
            this.gbMedicamentos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedicamentos.Location = new System.Drawing.Point(12, 607);
            this.gbMedicamentos.Name = "gbMedicamentos";
            this.gbMedicamentos.Size = new System.Drawing.Size(421, 167);
            this.gbMedicamentos.TabIndex = 35;
            this.gbMedicamentos.TabStop = false;
            this.gbMedicamentos.Text = "Medicamentos";
            this.gbMedicamentos.Visible = false;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(13, 36);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(402, 110);
            this.dgvMedicamentos.TabIndex = 0;
            // 
            // gbEstadoMasc
            // 
            this.gbEstadoMasc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstadoMasc.Controls.Add(this.tbEstadoActual);
            this.gbEstadoMasc.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstadoMasc.Location = new System.Drawing.Point(12, 491);
            this.gbEstadoMasc.Name = "gbEstadoMasc";
            this.gbEstadoMasc.Size = new System.Drawing.Size(715, 110);
            this.gbEstadoMasc.TabIndex = 34;
            this.gbEstadoMasc.TabStop = false;
            this.gbEstadoMasc.Text = "Estado actual";
            this.gbEstadoMasc.Visible = false;
            // 
            // tbEstadoActual
            // 
            this.tbEstadoActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEstadoActual.Enabled = false;
            this.tbEstadoActual.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstadoActual.Location = new System.Drawing.Point(12, 35);
            this.tbEstadoActual.Name = "tbEstadoActual";
            this.tbEstadoActual.Size = new System.Drawing.Size(688, 60);
            this.tbEstadoActual.TabIndex = 0;
            this.tbEstadoActual.Text = "";
            // 
            // gbMotivoConsulta
            // 
            this.gbMotivoConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMotivoConsulta.Controls.Add(this.tbMotivoConsulta);
            this.gbMotivoConsulta.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMotivoConsulta.Location = new System.Drawing.Point(12, 338);
            this.gbMotivoConsulta.Name = "gbMotivoConsulta";
            this.gbMotivoConsulta.Size = new System.Drawing.Size(715, 147);
            this.gbMotivoConsulta.TabIndex = 33;
            this.gbMotivoConsulta.TabStop = false;
            this.gbMotivoConsulta.Text = "Motivo de consulta";
            this.gbMotivoConsulta.Visible = false;
            // 
            // tbMotivoConsulta
            // 
            this.tbMotivoConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMotivoConsulta.Enabled = false;
            this.tbMotivoConsulta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotivoConsulta.Location = new System.Drawing.Point(11, 36);
            this.tbMotivoConsulta.Name = "tbMotivoConsulta";
            this.tbMotivoConsulta.Size = new System.Drawing.Size(688, 96);
            this.tbMotivoConsulta.TabIndex = 0;
            this.tbMotivoConsulta.Text = "";
            // 
            // gbTratamiento
            // 
            this.gbTratamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTratamiento.Controls.Add(this.tbTratamiento);
            this.gbTratamiento.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTratamiento.Location = new System.Drawing.Point(12, 780);
            this.gbTratamiento.Name = "gbTratamiento";
            this.gbTratamiento.Size = new System.Drawing.Size(700, 146);
            this.gbTratamiento.TabIndex = 32;
            this.gbTratamiento.TabStop = false;
            this.gbTratamiento.Text = "Tratamiento";
            this.gbTratamiento.Visible = false;
            // 
            // tbTratamiento
            // 
            this.tbTratamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTratamiento.Enabled = false;
            this.tbTratamiento.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTratamiento.Location = new System.Drawing.Point(11, 30);
            this.tbTratamiento.Name = "tbTratamiento";
            this.tbTratamiento.Size = new System.Drawing.Size(683, 96);
            this.tbTratamiento.TabIndex = 0;
            this.tbTratamiento.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbEdad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNombreProp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPeso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbApellidoProp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNombreMasc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbEsterilizado);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbRaza);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDireccionProp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbIdMasc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbNumeroProp);
            this.groupBox1.Controls.Add(this.tbIdProp);
            this.groupBox1.Controls.Add(this.tbEspecie);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 262);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "Raza:";
            // 
            // tbEdad
            // 
            this.tbEdad.Enabled = false;
            this.tbEdad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(107, 152);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(108, 29);
            this.tbEdad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Edad:";
            // 
            // tbNombreProp
            // 
            this.tbNombreProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreProp.Enabled = false;
            this.tbNombreProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreProp.Location = new System.Drawing.Point(421, 47);
            this.tbNombreProp.Name = "tbNombreProp";
            this.tbNombreProp.Size = new System.Drawing.Size(97, 29);
            this.tbNombreProp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre:";
            // 
            // tbPeso
            // 
            this.tbPeso.Enabled = false;
            this.tbPeso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPeso.Location = new System.Drawing.Point(107, 188);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(108, 29);
            this.tbPeso.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nombre:";
            // 
            // tbApellidoProp
            // 
            this.tbApellidoProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidoProp.Enabled = false;
            this.tbApellidoProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoProp.Location = new System.Drawing.Point(421, 82);
            this.tbApellidoProp.Name = "tbApellidoProp";
            this.tbApellidoProp.Size = new System.Drawing.Size(97, 29);
            this.tbApellidoProp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Esterilizado:";
            // 
            // tbNombreMasc
            // 
            this.tbNombreMasc.Enabled = false;
            this.tbNombreMasc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreMasc.Location = new System.Drawing.Point(107, 48);
            this.tbNombreMasc.Name = "tbNombreMasc";
            this.tbNombreMasc.ReadOnly = true;
            this.tbNombreMasc.Size = new System.Drawing.Size(108, 29);
            this.tbNombreMasc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Peso:";
            // 
            // tbEsterilizado
            // 
            this.tbEsterilizado.Enabled = false;
            this.tbEsterilizado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEsterilizado.Location = new System.Drawing.Point(107, 222);
            this.tbEsterilizado.Name = "tbEsterilizado";
            this.tbEsterilizado.Size = new System.Drawing.Size(108, 29);
            this.tbEsterilizado.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Especie:";
            // 
            // tbRaza
            // 
            this.tbRaza.Enabled = false;
            this.tbRaza.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaza.Location = new System.Drawing.Point(107, 117);
            this.tbRaza.Name = "tbRaza";
            this.tbRaza.ReadOnly = true;
            this.tbRaza.Size = new System.Drawing.Size(108, 29);
            this.tbRaza.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id:";
            // 
            // tbDireccionProp
            // 
            this.tbDireccionProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccionProp.Enabled = false;
            this.tbDireccionProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccionProp.Location = new System.Drawing.Point(421, 152);
            this.tbDireccionProp.Name = "tbDireccionProp";
            this.tbDireccionProp.Size = new System.Drawing.Size(180, 29);
            this.tbDireccionProp.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dirección:";
            // 
            // tbIdMasc
            // 
            this.tbIdMasc.Enabled = false;
            this.tbIdMasc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdMasc.Location = new System.Drawing.Point(107, 12);
            this.tbIdMasc.Name = "tbIdMasc";
            this.tbIdMasc.ReadOnly = true;
            this.tbIdMasc.Size = new System.Drawing.Size(108, 29);
            this.tbIdMasc.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Apellido:";
            // 
            // tbNumeroProp
            // 
            this.tbNumeroProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumeroProp.Enabled = false;
            this.tbNumeroProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroProp.Location = new System.Drawing.Point(421, 117);
            this.tbNumeroProp.Name = "tbNumeroProp";
            this.tbNumeroProp.Size = new System.Drawing.Size(97, 29);
            this.tbNumeroProp.TabIndex = 9;
            // 
            // tbIdProp
            // 
            this.tbIdProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdProp.Enabled = false;
            this.tbIdProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdProp.Location = new System.Drawing.Point(421, 12);
            this.tbIdProp.Name = "tbIdProp";
            this.tbIdProp.Size = new System.Drawing.Size(97, 29);
            this.tbIdProp.TabIndex = 12;
            // 
            // tbEspecie
            // 
            this.tbEspecie.Enabled = false;
            this.tbEspecie.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEspecie.Location = new System.Drawing.Point(107, 82);
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.ReadOnly = true;
            this.tbEspecie.Size = new System.Drawing.Size(108, 29);
            this.tbEspecie.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Número:";
            // 
            // gbOpcMascota
            // 
            this.gbOpcMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOpcMascota.Controls.Add(this.btVista);
            this.gbOpcMascota.Controls.Add(this.btBuscarHistoria);
            this.gbOpcMascota.Controls.Add(this.btEditar);
            this.gbOpcMascota.Controls.Add(this.tbBuscarHistoria);
            this.gbOpcMascota.Controls.Add(this.btGuardarCambios);
            this.gbOpcMascota.Controls.Add(this.btVerUltHistoria);
            this.gbOpcMascota.Location = new System.Drawing.Point(625, 62);
            this.gbOpcMascota.Name = "gbOpcMascota";
            this.gbOpcMascota.Size = new System.Drawing.Size(142, 262);
            this.gbOpcMascota.TabIndex = 39;
            this.gbOpcMascota.TabStop = false;
            this.gbOpcMascota.Visible = false;
            // 
            // btVista
            // 
            this.btVista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVista.AutoSize = true;
            this.btVista.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVista.Location = new System.Drawing.Point(14, 13);
            this.btVista.Name = "btVista";
            this.btVista.Size = new System.Drawing.Size(98, 28);
            this.btVista.TabIndex = 28;
            this.btVista.Text = "Vista";
            this.btVista.UseVisualStyleBackColor = true;
            this.btVista.Click += new System.EventHandler(this.btVista_Click);
            // 
            // btBuscarHistoria
            // 
            this.btBuscarHistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarHistoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscarHistoria.BackgroundImage")));
            this.btBuscarHistoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarHistoria.Location = new System.Drawing.Point(117, 230);
            this.btBuscarHistoria.Name = "btBuscarHistoria";
            this.btBuscarHistoria.Size = new System.Drawing.Size(21, 22);
            this.btBuscarHistoria.TabIndex = 16;
            this.btBuscarHistoria.UseVisualStyleBackColor = true;
            this.btBuscarHistoria.Click += new System.EventHandler(this.btBuscarHistoria_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditar.AutoSize = true;
            this.btEditar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(14, 50);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(98, 28);
            this.btEditar.TabIndex = 27;
            this.btEditar.Text = "Edicion";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tbBuscarHistoria
            // 
            this.tbBuscarHistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarHistoria.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarHistoria.Location = new System.Drawing.Point(14, 230);
            this.tbBuscarHistoria.Name = "tbBuscarHistoria";
            this.tbBuscarHistoria.Size = new System.Drawing.Size(111, 22);
            this.tbBuscarHistoria.TabIndex = 38;
            this.tbBuscarHistoria.Enter += new System.EventHandler(this.tbBuscarHistoria_Enter);
            this.tbBuscarHistoria.Leave += new System.EventHandler(this.tbBuscarHistoria_Leave);
            // 
            // btGuardarCambios
            // 
            this.btGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardarCambios.AutoSize = true;
            this.btGuardarCambios.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarCambios.Location = new System.Drawing.Point(14, 83);
            this.btGuardarCambios.Name = "btGuardarCambios";
            this.btGuardarCambios.Size = new System.Drawing.Size(98, 28);
            this.btGuardarCambios.TabIndex = 29;
            this.btGuardarCambios.Text = "Guardar";
            this.btGuardarCambios.UseVisualStyleBackColor = true;
            this.btGuardarCambios.Click += new System.EventHandler(this.btGuardarCambios_Click);
            // 
            // btVerUltHistoria
            // 
            this.btVerUltHistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVerUltHistoria.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerUltHistoria.Location = new System.Drawing.Point(12, 191);
            this.btVerUltHistoria.Name = "btVerUltHistoria";
            this.btVerUltHistoria.Size = new System.Drawing.Size(111, 31);
            this.btVerUltHistoria.TabIndex = 31;
            this.btVerUltHistoria.Text = "Ver Ultima Historia";
            this.btVerUltHistoria.UseVisualStyleBackColor = true;
            this.btVerUltHistoria.Click += new System.EventHandler(this.btVerUltHistoria_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlEncabezado.Controls.Add(this.btBuscarMascs);
            this.pnlEncabezado.Controls.Add(this.btBuscarMascota);
            this.pnlEncabezado.Controls.Add(this.cbNombreMascotas);
            this.pnlEncabezado.Controls.Add(this.tbDocumentoProp);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(800, 56);
            this.pnlEncabezado.TabIndex = 33;
            // 
            // btBuscarMascs
            // 
            this.btBuscarMascs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscarMascs.BackgroundImage")));
            this.btBuscarMascs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarMascs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarMascs.Location = new System.Drawing.Point(171, 12);
            this.btBuscarMascs.Name = "btBuscarMascs";
            this.btBuscarMascs.Size = new System.Drawing.Size(28, 29);
            this.btBuscarMascs.TabIndex = 15;
            this.btBuscarMascs.UseVisualStyleBackColor = true;
            this.btBuscarMascs.Click += new System.EventHandler(this.btBuscarMascs_Click);
            // 
            // btBuscarMascota
            // 
            this.btBuscarMascota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscarMascota.BackgroundImage")));
            this.btBuscarMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarMascota.Location = new System.Drawing.Point(338, 12);
            this.btBuscarMascota.Name = "btBuscarMascota";
            this.btBuscarMascota.Size = new System.Drawing.Size(28, 30);
            this.btBuscarMascota.TabIndex = 14;
            this.btBuscarMascota.UseVisualStyleBackColor = true;
            this.btBuscarMascota.Click += new System.EventHandler(this.btBuscarMascota_Click);
            // 
            // cbNombreMascotas
            // 
            this.cbNombreMascotas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombreMascotas.FormattingEnabled = true;
            this.cbNombreMascotas.Location = new System.Drawing.Point(220, 12);
            this.cbNombreMascotas.Name = "cbNombreMascotas";
            this.cbNombreMascotas.Size = new System.Drawing.Size(121, 30);
            this.cbNombreMascotas.TabIndex = 13;
            // 
            // tbDocumentoProp
            // 
            this.tbDocumentoProp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocumentoProp.Location = new System.Drawing.Point(76, 12);
            this.tbDocumentoProp.Name = "tbDocumentoProp";
            this.tbDocumentoProp.Size = new System.Drawing.Size(100, 29);
            this.tbDocumentoProp.TabIndex = 12;
            this.tbDocumentoProp.Enter += new System.EventHandler(this.tbDocumentoProp_Enter);
            this.tbDocumentoProp.Leave += new System.EventHandler(this.tbDocumentoProp_Leave);
            // 
            // eProvider
            // 
            this.eProvider.ContainerControl = this;
            // 
            // FormVerMascotaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "FormVerMascotaAdmin";
            this.Text = "FormVerMascotaAdmin";
            this.Load += new System.EventHandler(this.FormVerMascota_Load);
            this.pnlBack.ResumeLayout(false);
            this.gbMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.gbEstadoMasc.ResumeLayout(false);
            this.gbMotivoConsulta.ResumeLayout(false);
            this.gbTratamiento.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOpcMascota.ResumeLayout(false);
            this.gbOpcMascota.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbMedicamentos;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.GroupBox gbEstadoMasc;
        private System.Windows.Forms.RichTextBox tbEstadoActual;
        private System.Windows.Forms.GroupBox gbMotivoConsulta;
        private System.Windows.Forms.RichTextBox tbMotivoConsulta;
        private System.Windows.Forms.GroupBox gbTratamiento;
        private System.Windows.Forms.RichTextBox tbTratamiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreProp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbApellidoProp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreMasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEsterilizado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDireccionProp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdMasc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNumeroProp;
        private System.Windows.Forms.TextBox tbIdProp;
        private System.Windows.Forms.TextBox tbEspecie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbOpcMascota;
        private System.Windows.Forms.Button btVista;
        private System.Windows.Forms.Button btBuscarHistoria;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox tbBuscarHistoria;
        private System.Windows.Forms.Button btGuardarCambios;
        private System.Windows.Forms.Button btVerUltHistoria;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Button btBuscarMascs;
        private System.Windows.Forms.Button btBuscarMascota;
        public System.Windows.Forms.ComboBox cbNombreMascotas;
        private System.Windows.Forms.TextBox tbDocumentoProp;
        private System.Windows.Forms.ErrorProvider eProvider;
    }
}