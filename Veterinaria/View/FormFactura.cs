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
    public partial class FormFactura : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = veterinaria");
        public FormFactura()
        {
            InitializeComponent();
        }
        #region Mostrar
        /*
         * @JuanJo Carga todos los datos de la factura y sus detalles
         */
        private void FormFactura_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToShortDateString();
            tbFecha.Text = fecha;
            mostrarDetalles();
            buscarIdFact();
        }
       
        /*
         * @JuanJo Muestra los detalles haciendo la consulta en la db
         */
        private void mostrarDetalles()
        {
            string query = "SELECT Producto, Unidades, Valor FROM detalles WHERE detalles = '" + lbDetalles.Text + "'";

            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvDetalles.DataSource = data;         //Define de donde sacará la info
                dgvDetalles.DataMember = "productos"; //Define la tabla que aparecerá
                conexion.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }
        
        #endregion

        #region Buscar

        /*
         * @JuanJo Busca el id de la factura que tenga el mismo detalle de compra
         */
        private void buscarIdFact()
        {
            FacturaController fController = new FacturaController();
            string resp = fController.buscarIdFacturaC(lbDetalles.Text);
            lbIdfact.Text = resp;
        }
        #endregion


        



    }
}
