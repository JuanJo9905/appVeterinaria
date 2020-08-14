using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinaria.Model
{
    public class MascotasModel
    {
        string cadenaConexion = "server=127.0.0.1; user=root; password=; database=veterinaria";

        #region Guardar 
        /*
        * @JuanJo Método que se conecta finalmente a la base de datos para enviar la informacion con el comando
        * recibido en forma de string del controlador
        */
        public string guardarInfo(string query)
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
                    return "Agregado correctamente";
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

        #region Obtener
        /*
         * @JuanJo Métodos que sirven para obtener la informacion del campo requerida segun su tipo de dato
         */
         public string obtenerInfoCampoStr(string query)
        {
            string info;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout=60;

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

        public string obtenerInfoCampoInt(string query)
        {
            int info;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;

            try
            {
                conexion.Open();
                info = (Int32)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            conexion.Close();
            return ""+info;
        }
        public string obtenerInfoCampoDoub(string query)
        {
            double info;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;

            try
            {
                conexion.Open();
                info = (double)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            conexion.Close();
            return "" + info;
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
                    return "Datos mascota actualizados";
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
