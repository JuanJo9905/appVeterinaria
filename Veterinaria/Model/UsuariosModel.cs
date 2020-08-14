using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinaria.Model
{
    public class UsuariosModel
    {
        string cadenaConexion = "server=127.0.0.1; user=root; password=; database=veterinaria";

    /*
     * @JuanJo Método que envia la informacion a la base de datos para que confirme la existencia del usuario
     */
     public string iniciarSesion(string query)
        {
            string tipo;
            MySqlConnection conector = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conector);
            comando.CommandTimeout = 60;

            try
            {
                // Abre la base de datos
                conector.Open();
                // Ejecuta la consulta
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read() == true)
                {
                    //Se obtiene el contenido de la conexion
                    tipo = leer["Tipo"].ToString();
                }
                else
                {
                    tipo = "Usuario o contraseña incorrectos";
                }

                // Cerrar la conexión
                conector.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
               tipo =ex.Message;
            }
            return tipo;
        }

    /*
     * @JuanJo Método que registra los usuarios en la db
     */
     public string registrarUs(string query)
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
    }
}
