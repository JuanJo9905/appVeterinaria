using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Veterinaria.View;

namespace Veterinaria.Model
{
    public class TiendaModel
    {
        string cadenaConexion = "server=127.0.0.1; user=root; password=; database=veterinaria";

        #region Guardar
        /*
         * @JuanJo Guarda la informacion del producto creado
         */
         public string guardarProd(string query)
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
                    return "Producto agregado correctamente";
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
         * @JuanJo Busca la cantidad en stock de un producto por su nombre
         */
         public int cantidadStock(string query)
        {
            int resp;
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                resp = (Int32)comando.ExecuteScalar();

            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
                resp = 0;
            }
            return (Int32)resp;
        }
        #endregion

        #region Actualizar
        /*
         * @JuanJo Recibe el query con el nuevo stock y el id para realizar la modificacion en la base de datos
         */
        public string actualizar(string query)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comand = new MySqlCommand(query, conexion);
            comand.CommandTimeout = 60;

            try
            {
                //Abro la conexion para comenzar a ejecutar lo que necesito en la base de datos
                conexion.Open();

                int numbResp = comand.ExecuteNonQuery();

                if (numbResp > -1)
                {
                    return "El producto ha sido actualizado";
                }

                //Cierro la conexion con la base de datos
                conexion.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "El producto no ha sido actualizado";
        }
        #endregion
    }
}
