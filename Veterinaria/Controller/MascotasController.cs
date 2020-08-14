using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Model;

namespace Veterinaria.Controller
{
    public class MascotasController
    {
        MascotasModel mascotasDb;
        public MascotasController()
        {
            mascotasDb = new MascotasModel();
        }

        #region Guardar
        /*
         * @JuanJo Método que manda la informacion al modelo de mascotas
         */
        public string guardarMascota(string nombre, string especie,string raza, int edad, int peso, int idProp, string esterilizado)
        {
            string query = "INSERT INTO `mascotas`(`Nombre`, `Especie`, `Raza`, `Edad`, `Peso`, `Id_propietario`, `Esterilizado`) VALUES ('"+nombre+ "','"+especie+ "','"+raza+ "', "+edad+ ", "+peso+ ","+idProp+ ",'"+esterilizado+"')";
            string respuesta = mascotasDb.guardarInfo(query);
            return respuesta;
        }
      
        #endregion

        #region Buscar

        /*
         * @JuanJo Los métodos de busqueda usan el nombre de la mascota y el id del propietario asi como el 
         * campo correspondiente para obtener toda la informacion requerida
         */
         public string buscarCampoStr(string campo, string nombre, int id)
        {
            string query = "select "+campo+" from mascotas where Nombre = '" + nombre + "' and Id_Propietario = " + id + "";
            string respuesta = mascotasDb.obtenerInfoCampoStr(query);
            return respuesta;
        }

        public string buscarCampoInt(string campo, string nombre, int id)
        {
            string query = "select " + campo + " from mascotas where Nombre = '" + nombre + "' and Id_Propietario = " + id + "";
            string respuesta = mascotasDb.obtenerInfoCampoInt(query);
            return respuesta;
        }

        public string buscarCampoDoub(string campo, string nombre, int id)
        {
            string query = "select " + campo + " from mascotas where Nombre = '" + nombre + "' and Id_Propietario = " + id + "";
            string respuesta = mascotasDb.obtenerInfoCampoDoub(query);
            return respuesta;
        }


        #endregion

        #region Actualizar
        /*
         * @JuanJo Se manda la informacion al modelo con los datos que fueron modificado en la vista de mascotas
         */
        public string actualizarCampos(int edad, double peso, string esterilizado, int id)
        {
            string query = "update mascotas set Edad = '" + edad + "', Peso = '" + peso + "', Esterilizado ='" + esterilizado + "' where Id_mascota = " + id + "";
            string respuesta = mascotasDb.actualizarInfo(query);
            return respuesta;
        }
        #endregion
    }
}
