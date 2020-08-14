using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Veterinaria.Controller;
using Veterinaria.View;

namespace Veterinaria.Model
{
    public class PropietariosModel
    {
        string cadenaConexion = "server=127.0.0.1; user=root; password=; database=veterinaria";

        #region Guardar datos
        /*
         * @JuanJo Método que se conecta finalmente a la base de datos para enviar la informacion con el comando
         * recibido en forma de string del controlador
         */
        public string guardarInformacion(string query)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;

            try
            {
                conexion.Open();

                int numResp = comando.ExecuteNonQuery();

                if (numResp > -1)
                {
                    return "Agregado";
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "false";
        }
        #endregion

        #region Busquedas
        /*
         * @JuanJo El sgte método se encarga de buscar el id del usuario que coincida con la información de
         * nombre y numero de telefono enviados desde el controlador y finalmente devolver el id como respuesta
         */
        public string encontrarId(string query)
        {
            string resp, mensaje;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;

            try
            {
                conexion.Open();
                mensaje =Convert.ToString(comando.ExecuteScalar());
                if(mensaje != "")
                {
                    return mensaje;
                }
                else
                {
                    mensaje = "e";
                }
            }
            catch (Exception e)
            {
                mensaje= e.Message;
            }
           
            conexion.Close();  
            return mensaje;
           
        }
        /*
         * @JuanJo Éste método es el encargado de obtener la informacion de los campos mediante la info de la query 
         */
        public string obtenerInfoCampo(string query)
        {
            string info;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                info = (string)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                info = e.Message;
            }
            conexion.Close();
            return info;
        }

        #endregion

        #region Actualizar
        /*
         * @JuanJo El método recibe la informacion de los campos modificables y los actualiza
         */
        public string actualizarInfo(string query)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;

            try
            {
                conexion.Open();

                int numResp = comando.ExecuteNonQuery();

                if (numResp > -1)
                {
                    return "Datos propietario actualizados";
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "false";
        }
        #endregion
    }
}
