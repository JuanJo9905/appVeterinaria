using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinaria.Model
{
    public class FacturaModel
    {
        string cadenaConexion = "server=127.0.0.1; user=root; password=; database=veterinaria";

        #region Guardar
        /*
         * @JuanJo Crea la factura o los detalles con la info recibida
         */
         public string crearFactM(string query)
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
                    return "Creada";
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
         * @JuanJo Busca si el id de los detalles ya existe y manda true en caso de que esté disponible
         */
         public string buscarIdDetM(string query)
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

        /*
         * @JuanJo Busca el id de la factura en la db que coincida con el numero de los detalles
         */
         public string buscarIdFactM(string query)
        { 
            int id; 
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                id = (Int32)comando.ExecuteScalar();
                conexion.Close();
            }
            catch(Exception e)
            {
                return e.Message;
            }
            return "" + id;
        }
        #endregion
    }
}
