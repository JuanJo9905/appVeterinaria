using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Model;
namespace Veterinaria.Controller
{
    public class HistoriasCliController
    {
        HistoriasCliModel HistoriasCliDb;
        public HistoriasCliController()
        {
            HistoriasCliDb = new HistoriasCliModel();
        }

        #region Guardar
        /*
       *@JuanJo Recibe la informacion de todos los campos de la historia clinica y los manda al modelo para
       * crear una nueva historia clinica 
       */
        public string guardarHistorialCli(int idMasc, string fecha, string motivo, string estado, int idMed, string tratamiento)
        {
            string query = "INSERT INTO `historias_clinicas` (`Id_mascota`, `Fecha`, `Motivo`, `Estado`, `Tratamiento`, `Id_medicinas`) VALUES (" + idMasc + ", '" + fecha + "', '" + motivo + "', '" + estado + "', '" + tratamiento + "', " + idMed + ");";
            string respuesta = HistoriasCliDb.guardarHistoriaClinica(query);
            return respuesta;
        }
        #endregion

        #region Buscar
        /*
         * @JuanJo Manda la instruccion de buscar el id de la ultima historia clinica organizadas por fecha
         */
         public string buscarIdUlt(int idMascota)
        {
            string query = "SELECT Id_historia from historias_clinicas where Id_mascota = " + idMascota + " order by Fecha desc limit 1 ";
            string respuesta = HistoriasCliDb.buscarId(query);
            return respuesta;
        }

        /*
         * @JuanJo Encuentra la informacion de los campos que se le manda 
         */
         public string encontrarInfo(string campo, int idHistoria)
        {
            string query = "select " + campo + " from historias_clinicas where Id_historia = " + idHistoria + "";
            string respuesta = HistoriasCliDb.obtenerInfo(query);
            return respuesta;
        }
        #endregion
    }
}
