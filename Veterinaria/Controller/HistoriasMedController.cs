using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Model;

namespace Veterinaria.Controller
{
   public class HistoriasMedController
    {
        HistoriasMedModel HistoriasMedDb;
        public HistoriasMedController()
        {
            HistoriasMedDb = new HistoriasMedModel();
        }

        #region Guardar
        /*
         * @JuanJo Recibe la informacion de la medicina y la manda al modelo para crear la historia
         */
        public string guardarHistoriaMed(int idMascota, string nombreMed, string cantidad, int idHistoria)
        {
            string query = "INSERT INTO `historial_medicinas` (`Id_mascota`, `Nombre`, `Cantidad`, `Id_historia`) VALUES ("+idMascota+", '"+nombreMed+"', '"+cantidad+"', '"+idHistoria+"')";
            string respuesta = HistoriasMedDb.agregarHistorial(query);
            return respuesta;
        }
    #endregion

    #region Buscar
    /*
     * @JuanJo Recibe el id del historial de medicinas generado aleatoriamente para posteriormente buscarlo en
     * el modelo y verificar que no exista
     */
    public string buscarIdHistorial(int idMed)
        {
            string query = "select Id_historia from historial_medicinas where Id_historia = " + idMed + "";
            string respuesta = HistoriasMedDb.buscarHistorial(query);
            return respuesta;
        }
        #endregion
    }
}
