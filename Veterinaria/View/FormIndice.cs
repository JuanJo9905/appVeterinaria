using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Veterinaria.Controller;

namespace Veterinaria.View
{
    public partial class FormIndice : Form
    {
        string tipo;
        public FormIndice()
        {
            InitializeComponent();
        }
        /*
         * @JuanJo Metodo encargado de el inicio de sesion buscando si la info suministrada se encuentra en la base de datos
         */
        #region Conexion para iniciar sesion
        private void btIngresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, resp;
            usuario = tbUsuario.Text;
            contraseña = tbContraseña.Text;

            UsuariosController uController = new UsuariosController();
            resp = uController.infoInicio(usuario, contraseña);
            tipo = resp;
            if (tipo == "0" || tipo == "1")
            {
                FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
                formMenuPrincipal.lbTipo.Text = tipo;
                formMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos","Algo salió mal",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
                
        #endregion

        /*
         * @JuanJo Los siguientes métodos se encargaran de llenar los textBox y desaparecer el texto cuando el usuario
         * entre en ellos, así como de activar el modo contraseña.
         */
        #region Caja de inicio de sesion (Estetico)
        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                tbUsuario.Text = "Usuario";
            }
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario")
            {
                tbUsuario.Text = "";
            }
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "Contraseña")
            {
                tbContraseña.Text = "";
                tbContraseña.UseSystemPasswordChar = true;
            }
        }

        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "")
            {
                tbContraseña.Text = "Contraseña";
                tbContraseña.UseSystemPasswordChar = false;
            }
        }
        #endregion

        private void Indice_Load(object sender, EventArgs e)
        {
            tbUsuario_Leave(sender, e);
            tbContraseña_Leave(sender, e);
        }

        /*
         * @JuanJo Método que muestra la pestaña para la creacion de un nuevo usuario
         */
        private void lbNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCrearUsuario fUsuario = new FormCrearUsuario();
            fUsuario.Show();
        }
    }
}
