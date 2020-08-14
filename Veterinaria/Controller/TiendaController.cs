using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Model;

namespace Veterinaria.Controller
{
    public class TiendaController
    {
        TiendaModel tiendaDb;

        public TiendaController()
        {
            tiendaDb = new TiendaModel();
        }
            #region Guardar
            /*
             * @JuanJo Método manda la informacion de los productos para guardarlos en el modelo
             */
            public string agregarProducto(string nombre, double precio, string especie, string proveedor, string categoria, string subcategoria)
            {
            int stock = 0;
            string query = "INSERT INTO `productos`(`Nombre`, `Precio`, `Especie`, `Proveedor`, `Categoria`, `Sub_categoria`, `Stock`) VALUES('"+nombre+ "',"+precio+ ",'"+especie+ "','"+proveedor+ "','"+categoria+ "','"+subcategoria+ "',"+stock+")";
            string respuesta = tiendaDb.guardarProd(query);
            return respuesta;
            }


        #endregion

        #region Buscar
        /*
         * @JuanJo Manda la informacion para buscar la cantidad en stock de algun producto
         */
         public int confirmarStockCont(string nombProd)
        {
            string query = "select Stock from productos where Nombre = '" + nombProd + "'";
            int cant = tiendaDb.cantidadStock(query);
            return cant;

        }
        #endregion

        #region Actualizar

        /*
         * @JuanJo Recibe la nueva cantidad así como el id del producto y los manda al modelo para que realice las 
         * modificaciones
         */
        public string actualizarStock(int stock, int id)
        {
            string query = "update productos set Stock= " + stock + " where Id_productos= '" + id + "' ";
            string respuesta = tiendaDb.actualizar(query);
            return respuesta;

        }
        /*
         * @JuanJo Éste método se encarga de buscar el producto por su nombre y modificar su cantidad de unidades
         * en existencia y se usa en el boton de compra, se reutiliza el metodo de guardar cambios del controlador
         */
        public string actualizarStockNombre(string nombProd, int stock)
        {
            string query = "update productos set Stock= '" + stock + "' where Nombre= '" + nombProd + "' ";
            string respuesta = tiendaDb.actualizar(query);
            return respuesta;
        }



        #endregion
    }


}
