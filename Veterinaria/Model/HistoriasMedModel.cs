using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Veterinaria.Model
{
   public class HistoriasMedModel
    {
        string cadenaConexion = "server=127.0.0.1; user=root; password=; database=veterinaria";

        #region Guardar
        /*
         * @JuanJo Recibe la informacion de la historia de medicinas y la crea en la base de datos
         */
         public string agregarHistorial(string query)
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
                    return "Historia creada correctamente";
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

        #region Buscar
        /*
        * @JuanJo Busca un id de historial en el historial de medicinas que coincida con el parametro recibido, 
        * si no existe manda "true" lo que significa que el id está disponible
        */
        public string buscarHistorial(string query)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    return "false";
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "true";
        }
        #endregion
    }
}
