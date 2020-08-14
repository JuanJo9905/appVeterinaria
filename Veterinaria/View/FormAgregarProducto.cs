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
using MySql.Data.MySqlClient;

namespace Veterinaria.View
{
    public partial class FormAgregarProducto : Form
    {
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void btGuardarPod_Click(object sender, EventArgs e)
        {
            string nombre, especie, proveedor, categoria, subCategoria, respuesta, estado;
            double precio;

            nombre = tbNombreProd.Text;
            especie = cbEspecieProd.Text;
            proveedor = cbProveedor.Text;
            categoria = cbCategoriaProd.Text;
            subCategoria = cbSubCategoria.Text;
            estado = validarCampoNumerico(tbPrecioProd.Text, tbPrecioProd);
            if (estado == "ok")
            {
                precio = Convert.ToDouble(tbPrecioProd.Text);

                TiendaController tController = new TiendaController();
                respuesta = tController.agregarProducto(nombre, precio, especie, proveedor, categoria, subCategoria);
                MessageBox.Show(respuesta, "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbNombreProd.Text = "";
                tbPrecioProd.Text = "";
                cbEspecieProd.Text = "";
                cbProveedor.Text = "";
                cbCategoriaProd.Text = "";
                cbSubCategoria.Text = "";
            }
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            llenarCb("Especie", cbEspecieProd);
            llenarCb("Proveedor", cbProveedor);
            llenarCb("Sub_categoria", cbSubCategoria);
        }
        /*
         * @JuanJo llena los comboBox con los datos sin repetir del campo correspondiente 
         */
         private void llenarCb(string campo, System.Windows.Forms.ComboBox combo)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database=veterinaria");
                string query = "select distinct " + campo + " from productos";
                MySqlCommand command = new MySqlCommand(query, conexion);
                //Se asegura de que el comboBox no tenga elementos dentro
                combo.Items.Clear();
                command.CommandTimeout = 60;
                conexion.Open();
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    combo.Refresh();
                    combo.Items.Add(dr.GetValue(0).ToString());
                }
                conexion.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        /*
         * @JuanJo Método que recorre el contenido de los txtbox para verificar que todos los caracteres sean del 
         * mismo tipo
         */
        private string validarCampoNumerico(string contenido, System.Windows.Forms.Control campo)
        {
            string estado = "";

            foreach (char character in contenido)
            {
                if (char.IsDigit(character) && contenido != "")
                {
                    estado = "ok";
                }
                else
                {
                    eProvider.SetError(campo, "El campo solo debe contener numeros");
                    estado = "error";
                    break;
                }
            }

            return estado;
        }
    }
}
