using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Controller;
using System.Drawing.Printing;


namespace Veterinaria.View
{
    public partial class FormVerMascota : Form
    {
        int idProp, idMed, idUltimaHistoria;
        string nombreMasc;
        public FormVerMascota()
        {
            InitializeComponent();
        }

        #region Contenido de los tb
        /*
         * @JuanJo En los métodos enter y leave se llena o se vacía el contenido del tb para que sea fácil el ingreso
         * de datos
         */
        private void tbDocumentoProp_Enter(object sender, EventArgs e)
        {
            if(tbDocumentoProp.Text =="Documento")
            {
                tbDocumentoProp.Text = "";
            }
        }
        private void tbDocumentoProp_Leave(object sender, EventArgs e)
        {
            if (tbDocumentoProp.Text == "")
            {
                tbDocumentoProp.Text = "Documento";
            }
        }
        private void tbBuscarHistoria_Enter(object sender, EventArgs e)
        {
            if (tbBuscarHistoria.Text == "Buscar Historia")
            {
                tbBuscarHistoria.Text = "";
            }
        }

        private void tbBuscarHistoria_Leave(object sender, EventArgs e)
        {
            if (tbBuscarHistoria.Text == "")
            {
                tbBuscarHistoria.Text = "Buscar Historia";
            }
        }
        private void FormVerMascota_Load(object sender, EventArgs e)
        {
            tbDocumentoProp_Leave(sender, e);
            tbBuscarHistoria_Leave(sender, e);
        }
        #endregion

        #region Busquedas

        /*
         * @JuanJo En los sgtes métodos se hará la busqueda de la mascota de acuerdo al documento del propietario
         * y el nombre de la mascota
         */
        private void btBuscarMascs_Click(object sender, EventArgs e)
        {
            string doc;
            doc = tbDocumentoProp.Text;
            PropietariosController pController = new PropietariosController();
            string respuesta = pController.buscarId(doc);
            if (respuesta != "e")
            {
                idProp = Convert.ToInt32(respuesta);

                try
                {
                    MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database=veterinaria");
                    string query = "select Nombre from mascotas where Id_propietario = " + idProp + "";
                    MySqlCommand command = new MySqlCommand(query, conexion);
                    //Se asegura de que el comboBox no tenga elementos dentro
                    cbNombreMascotas.Items.Clear();
                    command.CommandTimeout = 60;
                    conexion.Open();
                    MySqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        cbNombreMascotas.Refresh();
                        cbNombreMascotas.Items.Add(dr.GetValue(0).ToString());
                    }
                    conexion.Close();
                }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }

            }
            else
            {
                MessageBox.Show("El documento ingresado " +
                    "no se encuentra en la base de datos por favor vuelve a intentarlo","Hay un problema...",MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbDocumentoProp.Text = "";
            }
        }

        private void btBuscarMascota_Click(object sender, EventArgs e)
        {
            nombreMasc = cbNombreMascotas.Text;

            string especie, raza, nombreProp, apellido, numero, direccion, idMasc, edad, peso, esterilizado;

            if (cbNombreMascotas.Text != "")
            {
                MascotasController mController = new MascotasController();
                idMasc = mController.buscarCampoInt("Id_mascota", nombreMasc, idProp);
                tbIdMasc.Text = idMasc;

                especie = mController.buscarCampoStr("Especie", nombreMasc, idProp);
                tbEspecie.Text = especie;

                raza = mController.buscarCampoStr("Raza", nombreMasc, idProp);
                tbRaza.Text = raza;

                edad = mController.buscarCampoInt("Edad", nombreMasc, idProp);
                tbEdad.Text = edad;

                peso = mController.buscarCampoDoub("Peso", nombreMasc, idProp);
                tbPeso.Text = peso;

                esterilizado = mController.buscarCampoStr("Esterilizado", nombreMasc, idProp);
                tbEsterilizado.Text = "" + esterilizado;

                tbNombreMasc.Text = nombreMasc;

                PropietariosController pController = new PropietariosController();
                nombreProp = pController.buscarCampo("Nombre", idProp);
                tbNombreProp.Text = nombreProp;

                apellido = pController.buscarCampo("Apellido", idProp);
                tbApellidoProp.Text = apellido;

                numero = pController.buscarCampo("Numero", idProp);
                tbNumeroProp.Text = numero;

                direccion = pController.buscarCampo("Direccion", idProp);
                tbDireccionProp.Text = direccion;

                tbIdProp.Text = "" + idProp;

                gbOpcMascota.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor selecciona una mascota", "No tan rápido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Habilitar txtBox
        /*
         * @JuanJo La funcion de ambos métodos es habilitar los campos necesarios para editar la informacion
         */
        private void btEditar_Click(object sender, EventArgs e)
        {
            btEditar.Enabled = false;
            btVista.Enabled = true;
            tbEdad.Enabled = true;
            tbPeso.Enabled = true;
            tbEsterilizado.Enabled = true;
            tbNumeroProp.Enabled = true;
            tbDireccionProp.Enabled = true;
            btGuardarCambios.Visible = true;
        }

        private void btVista_Click(object sender, EventArgs e)
        {
            btVista.Enabled = false;
            btEditar.Enabled = true;
            btVista.Enabled = false;
            tbEdad.Enabled = false;
            tbPeso.Enabled = false;
            tbEsterilizado.Enabled = false;
            tbNumeroProp.Enabled = false;
            tbDireccionProp.Enabled = false;
            btGuardarCambios.Visible = false;
        }
        #endregion

        #region Guardar datos

        private void btGuardarCambios_Click(object sender, EventArgs e)
        {
            string numero, direccion, documento, estadoNum, estadoDoc, estadoEdad, estadoPeso, esterilizado;
            int idProp, idMasc, edad, peso; ;

            numero = tbNumeroProp.Text;
            direccion = tbDireccionProp.Text;
            documento = tbDocumentoProp.Text;
            esterilizado = tbEsterilizado.Text;
            idProp = Convert.ToInt32(tbIdProp.Text);
            idMasc = Convert.ToInt32(tbIdMasc.Text);

            //Usando el método para validar los campos numericos
            estadoNum = validarCampoNumerico(numero, tbNumeroProp);
            estadoDoc = validarCampoNumerico(documento, tbDocumentoProp);
            estadoEdad = validarCampoNumerico(tbEdad.Text, tbEdad);
            estadoPeso = validarCampoNumerico(tbPeso.Text, tbPeso);

            if (estadoNum == "ok" && estadoDoc == "ok")
            {
                if (estadoEdad == "ok" && estadoPeso == "ok")
                {
                    //Se actualizan los datos usando el modelo mvc mandando los datos recolectados en los tb de propietario
                    edad = Convert.ToInt32(tbEdad.Text);
                    peso = Convert.ToInt32(tbPeso.Text);
                    MascotasController mController = new MascotasController();
                    string respuestaM = mController.actualizarCampos(edad, peso, esterilizado, idMasc);

                    PropietariosController pController = new PropietariosController();
                    string respuestaP = pController.actualizarCampos(numero, direccion, documento, idProp);
                    MessageBox.Show(respuestaM + "\n" + respuestaP, "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

        }

        #endregion

        #region Validaciones
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
        #endregion

        #region Historias Clinicas
        /*
         * @JuanJo Método que muestra y habilita los campos para llenar la informacion
         */
        private void btCrearHist_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            gbMotivoConsulta.Visible = true;
            tbMotivoConsulta.Enabled = true;
            gbEstadoMasc.Visible = true;
            tbEstadoActual.Enabled = true;
            gbAgregarMed.Visible = true;
            gbMedicamentos.Visible = false;
            gbTratamiento.Visible = true;
            tbTratamiento.Enabled = true;
            btGuardarHist.Visible = true;
            crearId();
        }

        /*
         * @JuanJo Se guarda la informacion suministrada en todos los txtBox para ser enviada al controlador
         * y finalmente guardada en el modelo, se usa un método especial para obtener la fecha directamente del pc
         */
        private void btGuardarHist_Click(object sender, EventArgs e)
        {
            if(tbIdMasc.Text !="")
            {
            string motivo, estado, tratamiento,fecha, respuesta;
            int idMasc;

            motivo = tbMotivoConsulta.Text;
            estado = tbEstadoActual.Text;
            tratamiento = tbTratamiento.Text;
            fecha= DateTime.Today.ToShortDateString();
            idMasc = Convert.ToInt32(tbIdMasc.Text);
                
            HistoriasCliController hController = new HistoriasCliController();
            respuesta = hController.guardarHistorialCli(idMasc, fecha, motivo, estado, idMed, tratamiento);
            MessageBox.Show(respuesta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor ingresa primero una mascota", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            tbMotivoConsulta.Text = "";
            tbEstadoActual.Text = "";
            tbTratamiento.Text = "";
        }
        /*
         * @JuanJo Metodo que recolecta la info necesaria para guardar una nueva historia de medicinas
         */
        private void btGuardarMed_Click(object sender, EventArgs e)
        {
            string nombreMed, cantidad, respuesta;
            int idMascota, idHistoria;
            nombreMed = tbNombreMed.Text;
            cantidad = tbCantidadMed.Text;
            idMascota = Convert.ToInt32(tbIdMasc.Text);
            idHistoria = idMed;
            if(rbNoMedicina.Checked == true)
            {
                nombreMed = "No tiene";
                cantidad = "No tiene";
                HistoriasMedController hController = new HistoriasMedController();
                respuesta = hController.guardarHistoriaMed(idMascota, nombreMed, cantidad, idHistoria);
                MessageBox.Show(respuesta, "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                HistoriasMedController hController = new HistoriasMedController();
                respuesta = hController.guardarHistoriaMed(idMascota, nombreMed, cantidad, idHistoria);
                MessageBox.Show(respuesta, "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tbNombreMed.Text = "";
            tbCantidadMed.Text = "";

        }

        /*
         * @JuanJo Genera un id aleatorio entre 1 y 10000 para asignarselo al historial de medicinas 
         */
        private void crearId()
        {
            string disponible = "false";
            Random rand = new Random();
            //Ciclo que hace la magia de generar ids aleatorios hasta que el espacio esté disponible (true)
            do
            {
                idMed = rand.Next(1, 10000);
                disponible = buscarId(idMed);
            } while (disponible == "false");

        }

        /*
        * @JuanJo Busca que el id generado aleatoriamente no exista previamente
        */
        private string buscarId(int idMed)
        {
            string disponible;
            HistoriasMedController hController = new HistoriasMedController();
            disponible = hController.buscarIdHistorial(idMed);
            return disponible;
        }
        /*
         * Muestra los campos necesarios pero sin habilitarlos con la informacion obtenida de la base de datos,
         * ademas encuentra el id de la última historia registrada para la busqueda
         */
        private void btVerUltHistoria_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            gbMotivoConsulta.Visible = true;
            tbMotivoConsulta.Enabled = false;
            gbEstadoMasc.Visible = true;
            tbEstadoActual.Enabled = false;
            gbMedicamentos.Visible = true;
            gbAgregarMed.Visible = false;
            gbTratamiento.Visible = true;
            tbTratamiento.Enabled = false;
            buscarUltimaHist();
            llenarInfo(idUltimaHistoria);
            mostrarMed(idUltimaHistoria);
            btGuardarHist.Visible = false;
            
        }
        /*
         * @JuanJo Muestra la informacion con el id de la historia ingresado
         */
        private void btBuscarHistoria_Click(object sender, EventArgs e)
        {
            int idHistoria = Convert.ToInt32(tbBuscarHistoria.Text);
            limpiarCampos();
            gbMotivoConsulta.Visible = true;
            tbMotivoConsulta.Enabled = false;
            gbEstadoMasc.Visible = true;
            tbEstadoActual.Enabled = false;
            gbMedicamentos.Visible = true;
            gbAgregarMed.Visible = false;
            gbTratamiento.Visible = true;
            tbTratamiento.Enabled = false;
            llenarInfo(idHistoria);
            mostrarMed(idHistoria);
            btGuardarHist.Visible = false;
        }
        /*
         * @JuanJo Usa el id de la mascota para buscar en su historia clinica la última fecha registrada y obtiene 
         * el id de la historia en dicha fecha
         */
        private void buscarUltimaHist()
        {
            string respuesta;
            int idMascota = Convert.ToInt32(tbIdMasc.Text);
            HistoriasCliController hController = new HistoriasCliController();
            respuesta= hController.buscarIdUlt(idMascota);
            idUltimaHistoria = Convert.ToInt32(respuesta);
        }
        /*
         * @JuanJo Obtiene y llena todos los campos con la informacion de la db
         */
         private void llenarInfo(int idHistoria)
        {
            string motivo, estado, tratamiento;
            HistoriasCliController hController = new HistoriasCliController();

            motivo = hController.encontrarInfo("Motivo", idHistoria);
            tbMotivoConsulta.Text = motivo;

            estado = hController.encontrarInfo("Estado", idHistoria);
            tbEstadoActual.Text = estado;

            tratamiento = hController.encontrarInfo("Tratamiento", idHistoria);
            tbTratamiento.Text = tratamiento;
        }

        /*
         * @JuanJo Habilitan o deshabilitan los campos para ingresar los medicamentos 
         */
        private void rbNoMedicina_CheckedChanged(object sender, EventArgs e)
        {
            tbNombreMed.Enabled = false;
            tbCantidadMed.Enabled = false;
        }
        private void rbNecesita_CheckedChanged(object sender, EventArgs e)
        {
            tbNombreMed.Enabled = true;
            tbCantidadMed.Enabled = true;
        }

        /*
        * @JuanJo Metodo que limpia todos los campos del historial médico
        */
        private void limpiarCampos()
        {
            tbMotivoConsulta.Text = "";
            tbEstadoActual.Text = "";
            tbTratamiento.Text = "";
        }

        /*
         * @JuanJo Muestra las medicinas de la historia con el id correspondiente
         */
        private void mostrarMed(int idHistoria)
        {

            string query = "select hm.Nombre, hm.Cantidad from historial_medicinas as hm inner join historias_clinicas as hc on hm.Id_historia = hc.Id_medicinas where hc.Id_historia = "+idHistoria+"";

            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = veterinaria");
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvMedicamentos.DataSource = data;         //Define de donde sacará la info
                dgvMedicamentos.DataMember = "productos"; //Define la tabla que aparecerá

            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }
        #endregion
    }
}
