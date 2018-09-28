
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Logica
    {

        public Usuario login(string usuario, string contrasena)
        {
            Datos capaDatos = new Datos();
            Usuario usuarioObt = capaDatos.obtenerObjUsuario(usuario, contrasena);

            if (usuarioObt != null)
            {
                string startupPath = Environment.CurrentDirectory;

                string[] lines = { usuarioObt.nickName, usuarioObt.codigoUsuario.ToString()};

                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.  You do NOT need to call Flush() or Close().
                System.IO.File.WriteAllLines(startupPath + "/user.dll", lines);
                return usuarioObt;
            }

            //if (inicioSesion)
            //{
            //    List<Permiso>  lista = capaDatos.obtenerPermisos(1);
            //    Usuario.permisosUsuario = lista;              
            //}

            return null;

        }

        public string obtenerUsuario()
        {
            string startupPath = Environment.CurrentDirectory;
            string[] lines = System.IO.File.ReadAllLines(startupPath + "/user.dll");
            return lines[0];
        }

        public string obtenerCodigoUsuario()
        {
            string startupPath = Environment.CurrentDirectory;
            string[] lines = System.IO.File.ReadAllLines(startupPath + "/user.dll");

            return lines[1];
        }

    }
}
