using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Controller;

namespace Veterinaria.View
{
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        /*
         * @JuanJo Lée La informacion de los campos y lo manda al controlador para que el usuario quede registrado
         */
        private void btGuardar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña, respuesta;
            int tipo;

            UsuariosController uController = new UsuariosController();
            nombre = tbNombre.Text;
            if (tbContra.Text == tbRepContra.Text)
            {
                contraseña = tbContra.Text;
                if(rbVet.Checked == true)
                {
                    tipo = 0;
                }
                else
                {
                    tipo = 1;
                }
                respuesta = uController.registrarUsuario(nombre, contraseña, tipo);
                MessageBox.Show(nombre +" "+ respuesta + " correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRepContra.Text = "";
            }
        }
    }
}
