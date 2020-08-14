using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.View
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        //Metodo para abrir los formularios dentro del panel de formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        { 
            Form formulario;
            formulario = pnlForms.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la coleccion el formulario
                                                                             //si el formulario/instancia no existe

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlForms.Controls.Add(formulario);
                pnlForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void btIngresarMascota_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormIngresarMascotas>();
        }

        private void btVerMascota_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVerMascota>();
        }
        private void btVerMascAdmin(object sender, EventArgs e)
        {
            AbrirFormulario<FormVerMascotaAdmin>();
        }
        private void btVerHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVerHistorias>();
        }

        private void btTienda_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTienda>();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            string tipo = lbTipo.Text;

            if(tipo == "0")
            {
                btTipo.Text = "Veterinario";
                btSoloVer.Enabled = false;
                btVerMascota.BringToFront();
            }
            else
            {
                btTipo.Text = "Administrador";
                btVerMascota.Enabled = false;
            }
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            FormIndice fIndice = new FormIndice();
            fIndice.Show();
            this.Close();
        }
    }
}
