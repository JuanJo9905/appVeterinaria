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
    public partial class FormCarrito : Form
    {
        int chk, cant, prc, nomb, cantProd = 0; string idDetalles; double total = 0;
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = veterinaria");
        public FormCarrito()
        {
            InitializeComponent();
        }
        #region Crear
        /*
         * @JuanJo Crea la factura con la fecha del pc, el total de toda la compra y el id del detalle de compra
         */
        private void btFact_Click(object sender, EventArgs e)
        {
            
            string fecha = DateTime.Today.ToShortDateString();
            crearFactura(fecha, total, idDetalles);
            FormFactura fFactura = new FormFactura();
            fFactura.lbDetalles.Text = idDetalles;
            fFactura.tbTotal.Text = "" + total;
            fFactura.Show();
        }

        /*
        * @JuanJo Método que creara la factura
        */
        private void crearFactura(string fecha, double total, string idDet)
        {
            FacturaController fController = new FacturaController();
            fController.crearFactC(fecha, total, idDet);
        }

        /*
        * @JuanJo Éste método crea un id para el detalle de factura aleatoriamente asegurandose de que no
        * exista uno igual en la base de datos
        */
        private void crearIdDetalles()
        {
            string available = "false";
            Random rand = new Random();
            //Ciclo que hace la magia de generar ids aleatorios hasta que el espacio esté disponible (true)
            do
            {
                idDetalles = Convert.ToString(rand.Next(1, 1000));
                available = buscarIdDet(idDetalles);
            } while (available == "false");

        }

        /*
         * @JuanJo Éste método enviará todos los datos necesarios para la creacion del detalle de factura
         */
        private void crearDetalles(string nombProd, int cant, double tot)
        {
            FacturaController fController = new FacturaController();
            fController.crearDetallesC(nombProd, cant, tot, idDetalles);

        }
        #endregion

        #region Comprar
        /*
         * @JuanJo Arega un producto al carrito de compra creando el detalle de dicha compra
         */
        private void btAddToCar_Click(object sender, EventArgs e)
        {
            bool check;
            double precio, tot = 0, totFila;
            string nombProd;
            int i, cantidad, actualStock, nuevoStock, idProduct;

            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                if (column.HeaderText.Equals("Comprar"))
                {
                    chk = column.Index;
                }
                if (column.HeaderText.Equals("Cantidad"))
                {
                    cant = column.Index;
                }
                if (column.HeaderText.Equals("Precio"))
                {
                    prc = column.Index;
                }
                if (column.HeaderText.Equals("Nombre"))
                {
                    nomb = column.Index;
                }
            }

            for (i = 0; i < dgvProductos.Rows.Count; i++)
            {
                check = Convert.ToBoolean(dgvProductos.Rows[i].Cells[chk].Value);
                if (check == true)
                {
                    totFila = 0;
                    cantidad = Convert.ToInt32(dgvProductos.Rows[i].Cells[cant].Value);
                    nombProd = Convert.ToString(dgvProductos.Rows[i].Cells[nomb].Value);
                    actualStock = confirmarStock(nombProd);
                    nuevoStock = actualStock - cantidad;
                    //La decision confirma que hayan suficientes unidades a la venta disponibles
                    if (nuevoStock >= 0)
                    {
                        actualizarStock(nombProd, nuevoStock);
                        precio = Convert.ToDouble(dgvProductos.Rows[i].Cells[prc].Value);
                        cantProd += cantidad;
                        totFila = cantidad * precio;
                        tot += totFila;
                        idProduct = buscarIdProd(nombProd);
                        crearDetalles(nombProd, cantidad, totFila);

                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos la cantidad de " + nombProd + " requerida es superior" +
                            " a nuestras existencias, por favor escoja una cantidad inferior o igual a " + actualStock + " unidades");
                    }

                }
            }
            total += tot;
            lbTotal.Text = "" + tot;
            lbTotFact.Text = "" + total;
        }
        #endregion

        #region Buscar
        /*
        * @JuanJo Carga las subcategorias en el comboBox y genera un id aleatorio para el detalle de la compra
        */
        private void FormCarrito_Load(object sender, EventArgs e)
        {
            tbBuscarProducto_Leave(sender, e);
            crearIdDetalles();
            try
            {
                string consulta = "SELECT distinct Sub_categoria FROM productos where Categoria = '"+lbCategoria.Text+"'";
                cbSubcategorias.Items.Clear();
                conexion.Open();
                MySqlCommand command = new MySqlCommand(consulta, conexion);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cbSubcategorias.Refresh();
                    cbSubcategorias.Items.Add(dr.GetValue(0).ToString());
                }
                conexion.Close();

            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        /*
         * @JuanJo Muestro el producto por su nombre
         */
        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            string categoria = lbCategoria.Text;
            string nombre = tbBuscarProducto.Text;
            string query = "SELECT Nombre, Precio, Especie FROM productos WHERE Categoria = '" + categoria + "' and Nombre = '" + nombre + "'";

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

                //Agrega 2 nuevas columnas a la tabla pero no permite que se sigan agregando mediante la decision
                if (dgvProductos.Columns.Count < 5)
                {
                    DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                    dgvProductos.Columns.Add(tbc);
                    tbc.HeaderText = "Cantidad";

                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    dgvProductos.Columns.Add(chk);
                    chk.HeaderText = "Comprar";
                    dgvProductos.AllowUserToAddRows = false;
                }
                conexion.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        /*
         * @JuanJo Muestra los productos de la subcategoria seleccionada
         */
        private void btShowProducts_Click(object sender, EventArgs e)
        {
            string categoria = lbCategoria.Text;
            string subCat = cbSubcategorias.Text;
            string query = "SELECT Nombre, Precio, Especie FROM productos WHERE Categoria = '" + categoria + "' and Sub_categoria = '" + subCat + "'";

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

                //Agrega 2 nuevas columnas a la tabla pero no permite que se sigan agregando mediante la decision
                if (dgvProductos.Columns.Count < 5)
                {
                    DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                    dgvProductos.Columns.Add(tbc);
                    tbc.HeaderText = "Cantidad";

                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    dgvProductos.Columns.Add(chk);
                    chk.HeaderText = "Comprar";
                    dgvProductos.AllowUserToAddRows = false;
                }
                conexion.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        /*
        * @JuanJo Método que busca si el id generado aleatoriamente ya existe
        */
        private string buscarIdDet(string idDet)
        {
            FacturaController fController = new FacturaController();
            string respuesta = fController.buscarIdDetC(idDet);
            return respuesta;
        }

        /*
        * @JuanJo Busca la cantidad de existencias en stock que tiene un producto
        */
        private int confirmarStock(string nameProd)
        {
            TiendaController tController = new TiendaController();
            int cantidad = tController.confirmarStockCont(nameProd);
            return cantidad;
        }

        /*
         * @JuanJo Actualiza la nueva cantidad de productos en stock
         */
        private void actualizarStock(string nombProd, int nuevoStock)
        {
            TiendaController tController = new TiendaController();
            tController.actualizarStockNombre(nombProd, nuevoStock);
        }

        /*
        * @JuanJo En éste método se obtendrá el id del producto buscandolo por su nombre
        */
        private int buscarIdProd(string name)
        {

            string query = "select Id_productos from productos where Nombre = '" + name + "'";
            int id;
            MySqlCommand comand = new MySqlCommand(query, conexion);
            comand.CommandTimeout = 60;
            try
            {
                conexion.Open();
                id = (Int32)comand.ExecuteScalar();
                conexion.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
                id = 0;
            }
            return (Int32)id;
        }
        #endregion

        #region TexBox
        /*
         * @JuanJo Ambos métodos controlan el contenido del texbox para que sea más rápido escribir en él
         */
        private void tbBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (tbBuscarProducto.Text != "")
            {
                tbBuscarProducto.Text = "";
            }
        }

        private void tbBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (tbBuscarProducto.Text == "")
            {
                tbBuscarProducto.Text = "Buscar Producto";
            }
        }
        #endregion














    }
}
