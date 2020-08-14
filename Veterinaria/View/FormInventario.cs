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
    public partial class FormInventario : Form
    {
        string cadena = "server=127.0.0.1; user=root; password=; database = veterinaria";
        int col, id, antStk;
        public FormInventario()
        {
            InitializeComponent();
        }

        #region Buscar
        /*
         * @JuanJo Busca en la base de datos el primer producto que coincida con el nombre ingresado
         * en el tb
         */
        private void btBuscarProd_Click(object sender, EventArgs e)
        {
            string nombre = tbBuscarProd.Text;
            string query = "SELECT * FROM productos WHERE Nombre = '" + nombre + "'";

            MySqlConnection conexion = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvProductos.DataSource = data;         //Define de donde sacará la info
                dgvProductos.DataMember = "productos"; //Define la tabla que aparecerá
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        #endregion

        #region Actualizar

        
        /*
         * @JuanJo Muestra el producto que tenga el nombre que coincida con el del tb 
         */
        private void btShowProducts_Click(object sender, EventArgs e)
        {
            string category = cbSelCategoria.Text;
            string query = "SELECT * FROM productos WHERE Sub_categoria = '" + category + "'";

            MySqlConnection conexion = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand(query, conexion);

            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvProductos.DataSource = data;         //Define de donde sacará la info
                dgvProductos.DataMember = "productos"; //Define la tabla que aparecerá

                //Se asegura de que la columna agregar no se repita al exeder el limite de columnas
                if (dgvProductos.Columns.Count <= 8)
                {
                    DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                    dgvProductos.Columns.Add(tbc);
                    tbc.HeaderText = "Agregar";
                    tbc.Name = "tbc";
                    dgvProductos.AllowUserToAddRows = false;
                }
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }
        /*
         * @JuanJo Muestra todas las subcategorias 
         */
        private void FormInventario_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT distinct Sub_categoria FROM productos";

                MySqlConnection conection = new MySqlConnection(cadena);

                //Se asegura de que el comboBox no tenga elementos dentro
                cbSelCategoria.Items.Clear();

                conection.Open();
                MySqlCommand command = new MySqlCommand(consulta, conection);
                command.CommandTimeout = 60;
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cbSelCategoria.Refresh();
                    cbSelCategoria.Items.Add(dr.GetValue(0).ToString());
                }
                conection.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
            tbBuscarProd_Leave(sender, e);
        }

        #region Contenido de tb
        /*
         * @JuanJo Ambos metodos sirven para controlar el contenido del tb donde se le indica al usuario que debe ir el
         * nombre del producto a buscar
         */
        private void tbBuscarProd_Enter(object sender, EventArgs e)
        {
            if(tbBuscarProd.Text == "Buscar Producto")
            {
                tbBuscarProd.Text = "";
            }
        }

        private void tbBuscarProd_Leave(object sender, EventArgs e)
        {
            if (tbBuscarProd.Text == "")
            {
                tbBuscarProd.Text = "Buscar Producto";
            }
        }
        #endregion
        /*
         * @JuanJo Actualiza el inventario recorriendo las celdas del dgv y identificandolas por su valor de cabecera
         * y leyendo su contenido para hacer la modificacion
         */
        private void btGuardarCambios_Click(object sender, EventArgs e)
        {
            int i, nStock, aStock, idProd;
            //Accedo al indice en el que se encuentra cada columna recorriendolas y comparando cadenas 
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                if (column.HeaderText.Equals("Agregar"))
                {
                    col = column.Index;
                }
                if (column.HeaderText.Equals("Id_productos"))
                {
                    id = column.Index;
                }
                if (column.HeaderText.Equals("Stock"))
                {
                    antStk = column.Index;
                }
            }
            //Recorro las filas y leo el valor de inventario antigüo, el nuevo y el id del producto correspondiente 
            for (i = 0; i < dgvProductos.Rows.Count; i++)
            {
                aStock = Convert.ToInt32(dgvProductos.Rows[i].Cells[antStk].Value);
                nStock = Convert.ToInt32(dgvProductos.Rows[i].Cells[col].Value) + aStock;
                idProd = Convert.ToInt32(dgvProductos.Rows[i].Cells[id].Value);
                nuevoStock(nStock, idProd);
            }
        }
        /*
        * @JuanJo Metodo que recibe el id que corresponde al producto junto con la nueva cantidad en 
        * inventario para mandarle los parámetros al metodo en el controlador que se encarga de hacer 
        * la peticion
        */
        private void nuevoStock(int nStock, int idProd)
        {
            string respuesta;
            TiendaController tController = new TiendaController();
            respuesta = tController.actualizarStock(nStock, idProd);
            MessageBox.Show(respuesta, "¡Éxito!", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
    #endregion
}
