using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;


namespace Veterinaria.View
{
    public partial class FormVerHistorias : Form
    {
        public FormVerHistorias()
        {
            InitializeComponent();
        }

        #region llenar informacion
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
        #endregion

        #region generar PDF
        private void btGenerarPdfHis_Click(object sender, EventArgs e)
        {
            crearPdfHist();
        }
        private void btGenerar_Click(object sender, EventArgs e)
        {
            crearPdf();
        }
        /*
         * @JuanJo Método que genera el pdf con sus respectivas margenes y tamaño
         */
        private void crearPdfHist()
        {
            //Nombre del archivo
            PdfWriter pdfwriter = new PdfWriter("Reporte_historias.pdf");
            //Nuevo pdf
            PdfDocument pdf = new PdfDocument(pdfwriter);
            //Se crea el documento como pdf y se le asigna el tamaño (Carta en éste caso)
            Document documento = new Document(pdf, PageSize.LETTER);
            //Se le asignan las margenes
            documento.SetMargins(60, 20, 55, 22);

            //En ésta parte va el contenido del pdf//

            //Éstilo Fuente
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            //Tabla
            string[] columnas = { "Id_historia", "Fecha", "Motivo", "Estado","Tratamiento"};
            float[] tamanios = { 2, 3, 3, 3, 4 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));
            //Recorre cada espacio del arreglo columnas para agregarlo a la tabla 
            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            int idMascota = Convert.ToInt32(tbIdMasota.Text);
            string sql = "select Id_historia, Fecha, Motivo, Estado, Tratamiento from historias_clinicas where Id_mascota = " + idMascota + "";
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = veterinaria");
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Id_historia"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Fecha"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Motivo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Estado"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Tratamiento"].ToString()).SetFont(fontContenido)));
            }
            conexion.Close();

            documento.Add(tabla);
            //Fin contenido del pdf//
            documento.Close();
        }
        private void crearPdf()
        {
            
            PdfWriter pdfwriter = new PdfWriter("Reporte_medicinas.pdf");
            PdfDocument pdf = new PdfDocument(pdfwriter);
            Document documento = new Document(pdf, PageSize.LETTER);
            documento.SetMargins(60, 20, 55, 22);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Id", "Nombre", "Cantidad", "Id_historia" };
            float[] tamanios = {2, 4, 4, 4};
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach(string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            int idMascota = Convert.ToInt32(tbIdMasota.Text);
            string sql = "select Id_medicinas, Nombre, Cantidad, Id_historia from historial_medicinas where Id_mascota = "+idMascota+"";
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = veterinaria");
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while(reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Id_medicinas"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Nombre"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Cantidad"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Id_historia"].ToString()).SetFont(fontContenido)));
            }
            conexion.Close();

            documento.Add(tabla);
            documento.Close();
        }
        #endregion


    }
}
