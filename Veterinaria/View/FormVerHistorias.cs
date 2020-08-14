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
namespace Veterinaria.View
{
    public partial class FormVerHistorias : Form
    {
        public FormVerHistorias()
        {
            InitializeComponent();
        }

        /*
         * @JuanJo Busca la informacion de las tablas correspondientes y llena los dgvs con dicha informacion 
         */
        private void btBuscarHistorias_Click(object sender, EventArgs e)
        {
            int idMascota = Convert.ToInt32(tbIdMasota.Text);

            string queryCl = "select Id_historia, Fecha, Motivo from historias_clinicas where Id_mascota =" + idMascota + "";
            MySqlConnection conexion1 = new MySqlConnection("server=127.0.0.1; user=root; password=; database = veterinaria");
            MySqlCommand comando = new MySqlCommand(queryCl, conexion1);
            comando.CommandTimeout = 60;
            try
            {
                conexion1.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(queryCl, conexion1);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvHistoriaClinica.DataSource = data;         //Define de donde sacará la info
                dgvHistoriaClinica.DataMember = "productos"; //Define la tabla que aparecerá
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }

            string queryMed = "select Nombre, Cantidad from historial_medicinas where Id_mascota =" + idMascota + "";
            MySqlConnection conexion2 = new MySqlConnection("server=127.0.0.1; user=root; password=; database = veterinaria");
            MySqlCommand comandoMed = new MySqlCommand(queryMed, conexion2);
            comando.CommandTimeout = 60;
            try
            {
                conexion2.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(queryMed, conexion2);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvHistoriaMedicinas.DataSource = data;         //Define de donde sacará la info
                dgvHistoriaMedicinas.DataMember = "productos"; //Define la tabla que aparecerá
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }
    }
}
