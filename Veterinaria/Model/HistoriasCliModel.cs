using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinaria.Model
{
   public  class HistoriasCliModel
    {
        string cadenaConexion = "server=127.0.0.1; user=root; password=; database=veterinaria";

        #region Guardar
        /*
        * @JuanJo Recibe la informacion recogida de los campos para crear una nueva historia clinica
        */
        public string guardarHistoriaClinica(string query)
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

            return "La historia no se ha podido crear";
        }


        #endregion

        #region Buscar
        /*
         * @JuanJo Busca el id de la ultima historia organizadas por fecha
         */
         public string buscarId(string query)
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
            return "" + info;
        }

        /*
         * @JuanJo Trae la informacion del campo que se le pide de la historia clinica que coincide con el id
         * que se le pasa en el controlador
         */
        public string obtenerInfo(string query)
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
    }
}
