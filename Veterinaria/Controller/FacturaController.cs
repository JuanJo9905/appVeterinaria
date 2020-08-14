using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Model;

namespace Veterinaria.Controller
{
    public class FacturaController
    {
        FacturaModel facturaDb;

        public FacturaController()
        {
            facturaDb = new FacturaModel();
        }
        #region Guardar
        /*
         * @JuanJo Recibe los datos para mandar la info y crear la factura
         */
         public void crearFactC(string fecha, double total, string idDet)
        {
            string query = "INSERT INTO `factura`(`Fecha`, `Total`, `detalles`) VALUES ('" + fecha + "'," + total + ",'" + idDet + "')";
            string respuesta = facturaDb.crearFactM(query);
        }
        /*
         * @JuanJo Crea los detalles de la factura aprovechando el metodo ya existente para crear la factura ya 
         * que solo necesita abrir la conexion.
         */
         public void crearDetallesC(string nombProd, int cant,double tot, string idDet)
        {
            string query = "INSERT INTO `detalles`(`Producto`, `Unidades`, `Valor`, `detalles`) VALUES ('" + nombProd + "'," + cant + "," + tot + ",'" + idDet + "')";
            string respuesta = facturaDb.crearFactM(query);
        }
        #endregion

        #region Buscar
        /*
         * @JuanJo Manda el id de los detalles para verificar que no exista
         */
        public string buscarIdDetC(string idDet)
        {
            string query = "select detalles from detalles where detalles = '" + idDet + "'";
            string respuesta = facturaDb.buscarIdDetM(query);
            return respuesta;
        }
        /*
         * @JuanJo Manda id de los detalles para que el modelo busque el id de factura que coincida
         */
         public string buscarIdFacturaC(string idDet)
        {
            string query = "select Id_factura from factura where detalles ='" + idDet + "'";
            string respuesta = facturaDb.buscarIdFactM(query);
            return respuesta;
        }
        #endregion
    }
}

