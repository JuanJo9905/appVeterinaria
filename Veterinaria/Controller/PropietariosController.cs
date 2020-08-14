using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Model;
using Veterinaria.View;

namespace Veterinaria.Controller
{
    public class PropietariosController
    {
        PropietariosModel propietariosDb;


        public PropietariosController()
        {
            propietariosDb = new PropietariosModel();
          //  FormVerMascota fvMascota = new FormVerMascota();
        }
        #region Ingresar propietario
        /*
         * @JuanJo Método que manda la informacion al modelo para que la almacene en la base de datos
         */
        public string guardarPropietario(string nombre, string apellido, string numero, string direccion, string documento)
        {
            string query = "INSERT INTO `propietarios`(`Nombre`, `Apellido`, `Numero`, `Direccion`, `Documento` ) VALUES ('" + nombre+"','"+apellido+"','"+numero+"','"+direccion+ "', '"+documento+"')";
            string respuesta = propietariosDb.guardarInformacion(query);
            return respuesta;
        }
        #endregion

        #region Busquedas
        /*
         * @JuanJo Método que busca el id del propietario que coincida con el nombre y el numero de teléfono
         */
        public string buscarId(string documento)
        {
            string query = "SELECT Id_propietario from propietarios where Documento='" + documento + "'";
            string id = propietariosDb.encontrarId(query);
            return id;
        }
        public string buscarCampo(string campo, int id)
        {
            string query = "select " + campo + " from propietarios where Id_Propietario = " + id + "";
            string respuesta = propietariosDb.obtenerInfoCampo(query);
            return respuesta;
        }

        #endregion

        #region Actualizar
         /*
         * @JuanJo Se manda la informacion al modelo con los datos que fueron modificado en la vista de mascotas
         */
        public string actualizarCampos(string numero, string direccion, string documento, int id)
        {
            string query = "update propietarios set Numero = '" + numero + "', Direccion = '" + direccion + "', Documento ='" + documento + "' where Id_propietario = "+id+"";
            string respuesta = propietariosDb.actualizarInfo(query);
            return respuesta;
        }
        #endregion
    }
}
