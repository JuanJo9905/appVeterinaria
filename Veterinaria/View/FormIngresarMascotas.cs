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
    public partial class FormIngresarMascotas : Form
    {
        public FormIngresarMascotas()
        {
            InitializeComponent();  
        }


        #region contenido de los txtbox
        /*
         * @JuanJo En los sgtes metodos se manipulara la propiedad de contenido de los txtBox para que el ingreso de 
         * datos sea fácil e intuitivo.
         */

        private void tbNombreMascota_Enter(object sender, EventArgs e)
        {
            if(tbNombreMascota.Text == "Nombre")
            {
                tbNombreMascota.Text = "";
            }
        }

        private void tbNombreMascota_Leave(object sender, EventArgs e)
        {
            if (tbNombreMascota.Text == "")
            {
                tbNombreMascota.Text = "Nombre";
            }
        }

        private void tbEspecie_Enter(object sender, EventArgs e)
        {
            if (tbEspecie.Text == "Especie")
            {
                tbEspecie.Text = "";
            }
        }

        private void tbEspecie_Leave(object sender, EventArgs e)
        {
            if (tbEspecie.Text == "")
            {
                tbEspecie.Text = "Especie";
            }
        }

        private void tbRaza_Enter(object sender, EventArgs e)
        {
            if (tbRaza.Text == "Raza")
            {
                tbRaza.Text = "";
            }
        }

        private void tbRaza_Leave(object sender, EventArgs e)
        {
            if (tbRaza.Text == "")
            {
                tbRaza.Text = "Raza";
            }
        }

        private void tbEdad_Enter(object sender, EventArgs e)
        {
            if (tbEdad.Text == "Edad")
            {
                tbEdad.Text = "";
            }
        }

        private void tbEdad_Leave(object sender, EventArgs e)
        {
            if (tbEdad.Text == "")
            {
                tbEdad.Text = "Edad";
            }
        }

        private void tbPeso_Enter(object sender, EventArgs e)
        {
            if (tbPeso.Text == "Peso")
            {
                tbPeso.Text = "";
            }
        }

        private void tbPeso_Leave(object sender, EventArgs e)
        {
            if (tbPeso.Text == "")
            {
                tbPeso.Text = "Peso";
            }
        }

        private void tbNombreProp_Enter(object sender, EventArgs e)
        {
            if(tbNombreProp.Text == "Nombre")
            {
                tbNombreProp.Text = "";
            }
        }

        private void tbNombreProp_Leave(object sender, EventArgs e)
        {
            if (tbNombreProp.Text == "")
            {
                tbNombreProp.Text = "Nombre";
            }
        }

        private void tbApellidoProp_Enter(object sender, EventArgs e)
        {
            if (tbApellidoProp.Text == "Apellido")
            {
                tbApellidoProp.Text = "";
            }
        }

        private void tbApellidoProp_Leave(object sender, EventArgs e)
        {
            if (tbApellidoProp.Text == "")
            {
                tbApellidoProp.Text = "Apellido";
            }
        }

        private void tbNumeroProp_Enter(object sender, EventArgs e)
        {
            if (tbNumeroProp.Text == "Número")
            {
                tbNumeroProp.Text = "";
            }
        }

        private void tbNumeroProp_Leave(object sender, EventArgs e)
        {
            if (tbNumeroProp.Text == "")
            {
                tbNumeroProp.Text = "Número";
            }
        }
        private void tbDireccion_Enter(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "Direccion")
            {
                tbDireccion.Text = "";
            }
        }

        private void tbDireccion_Leave(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "")
            {
                tbDireccion.Text = "Direccion";
            }
        }
        private void tbDocumentoProp_Enter(object sender, EventArgs e)
        {
            if (tbDocumentoProp.Text == "Documento")
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

        private void tbIdprop_Enter(object sender, EventArgs e)
        {
            if (tbIdprop.Text == "ID Propietario")
            {
                tbIdprop.Text = "";
            }
        }

        private void tbIdprop_Leave(object sender, EventArgs e)
        {
            if (tbIdprop.Text == "")
            {
                tbIdprop.Text = "ID Propietario";
            }
        }
        private void tbIngresarDoc_Enter(object sender, EventArgs e)
        {
            if (tbIngresarDoc.Text == "Documento")
            {
                tbIngresarDoc.Text = "";
            }
        }
        private void tbIngresarDoc_Leave(object sender, EventArgs e)
        {
            if (tbIngresarDoc.Text == "")
            {
                tbIngresarDoc.Text = "Documento";
            }
        }
        //Pequeño método que habilita la edicion del id del propietario en el grupo de mascota
        private void btEditId_Click(object sender, EventArgs e)
        {
            tbIdprop.ReadOnly = false;
            tbIdprop.Enabled = true;

        }
        private void FormIngresarMascotas_Load(object sender, EventArgs e)
        {
            tbNombreMascota_Leave(sender, e);
            tbEspecie_Leave(sender, e);
            tbRaza_Leave(sender, e);
            tbEdad_Leave(sender, e);
            tbPeso_Leave(sender, e);
            tbNombreProp_Leave(sender, e);
            tbApellidoProp_Leave(sender, e);
            tbNumeroProp_Leave(sender, e);
            tbDireccion_Leave(sender, e);
            tbDocumentoProp_Leave(sender, e);
            tbIdprop_Leave(sender, e);
            tbIngresarDoc_Leave(sender, e);
        }

        #endregion

        #region Registros a la db
        /*
         * @JuanJo Conexion con la base de datos para guardar la informacion del cliente y la mascota 
         */
        private void btRegistrarProp_Click(object sender, EventArgs e)
        {
            string nombre, apellido, numero, direccion, documento, estadoNum, estadoDoc;

            nombre = tbNombreProp.Text;
            apellido = tbApellidoProp.Text;
            numero = tbNumeroProp.Text;
            direccion = tbDireccion.Text;
            documento = tbDocumentoProp.Text;

            //Usando el método para validar los campos numericos
            estadoNum = validarCampoNumerico(numero, tbNumeroProp);
            estadoDoc = validarCampoNumerico(documento, tbDocumentoProp);

            if (estadoNum == "ok" && estadoDoc == "ok")
            {
                //Se guardan los datos usando el modelo mvc mandando los datos recolectados en los tb de propietario
                PropietariosController pController = new PropietariosController();
                string respuesta = pController.guardarPropietario(nombre, apellido, numero, direccion, documento);

                //Se busca el id del propietario ingresado para mostrarlo en pantalla
                string id = pController.buscarId(documento);
                tbIdprop.Text = id;
            }
        }
        private void btRegistrarMascota_Click(object sender, EventArgs e)
        {
            string nombre, especie, raza, estadoEsp, estadoRaz, estadoEdad, estadoPeso, estadoId, esterilizado;
            int edad, peso, idProp;
            

            nombre = tbNombreMascota.Text;
            especie = tbEspecie.Text;
            raza = tbRaza.Text;

            if(cbEsterilizado.Checked == true)
            {
                esterilizado = "Si";
            }
            else
            {
                esterilizado = "No";
            }

            //Validar campos
            estadoEsp = validarCampoLetras(especie, tbEspecie);
            estadoRaz = validarCampoLetras(raza, tbRaza);
            estadoEdad = validarCampoNumerico(tbEdad.Text, tbEdad);
            estadoPeso = validarCampoNumerico(tbPeso.Text, tbPeso);
            estadoId = validarCampoNumerico(tbIdprop.Text, tbIdprop);
            ///////////
            if(estadoEsp == "ok" && estadoRaz == "ok")
            {
                if(estadoEdad == "ok" && estadoPeso == "ok" && estadoId == "ok")
                {
                   
                    edad = Convert.ToInt32(tbEdad.Text);
                    peso = Convert.ToInt32(tbPeso.Text);
                    idProp = Convert.ToInt32(tbIdprop.Text);
                    MascotasController mController = new MascotasController();
                    string respuesta = mController.guardarMascota(nombre, especie, raza, edad, peso, idProp, esterilizado);
                    MessageBox.Show(nombre +" "+ respuesta);
                }
            }
        }
        /*
         * @JuanJo Lee el documento ingresado y lo manda al controlador para buscar a un usuario con dicho documento 
         * y devolver su id
         */
        private void btBuscarId_Click(object sender, EventArgs e)
        {
            string doc;
            doc = tbIngresarDoc.Text;
            PropietariosController pController = new PropietariosController();
            string respuesta = pController.buscarId(doc);
            if (respuesta == "e")
            {
                MessageBox.Show("El usuario no se encuentra registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIngresarDoc.Text = "";
            }
            else
            {
                tbMostrarId.Text = respuesta;
            }
        }
        
        #endregion

        #region validaciones
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
        private string validarCampoLetras(string contenido, System.Windows.Forms.Control campo)
        {
            string estado = "";

            foreach (char character in contenido )
            {
                if (char.IsLetter(character) && contenido != "")
                {
                    estado = "ok";
                }
                else
                {
                    eProvider.SetError(campo, "El campo solo debe contener letras");
                    estado = "error";
                    break;
                }
            }

            return estado;
        }


        #endregion

    }
}
