using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Model;

namespace Veterinaria.Controller
{
    public class UsuariosController
    {
        UsuariosModel usuariosDb;
        public UsuariosController()
        {
            usuariosDb = new UsuariosModel();
        }

        /*
         * @JuanJo Método que envia la info de usuario y contraseña
         */
         public string infoInicio(string usuario,string contraseña)
        {
            string query = "Select * from usuarios where Nombre ='" + usuario + "'and Contraseña = '" + contraseña +"'";
            string respuesta = usuariosDb.iniciarSesion(query);
            return respuesta;
        }

        /*
         * @JuanJo Método que manda usuario, contraseña y tipo para registrar al usuario
         */
        public string registrarUsuario(string nombre, string contraseña, int tipo)
        {
            string query = "INSERT INTO `usuarios` (`Nombre`, `Tipo`, `Contraseña`) VALUES ('" + nombre + "', " + tipo + ", '" + contraseña + "')";
            string respuesta = usuariosDb.registrarUs(query);
            return respuesta;
        }
    }
}
