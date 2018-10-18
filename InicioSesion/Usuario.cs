using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;
using CapaDatos;

namespace InicioSesion
{
    public class Usuario
    {

        public string obtenerUsuario()
        {
            Logica capaLogica = new Logica();
            return capaLogica.obtenerUsuario();
        }

        public int obtenerCodigoUsuario()
        {
            Logica capaLogica = new Logica();
            return Convert.ToInt32(capaLogica.obtenerCodigoUsuario());
        }

        public Permiso obtenerPermisos(int usuarioCodigo, int codigo_aplicacion)
        {
            Logica capaLogica = new Logica();
            return capaLogica.obtenerPermisos(usuarioCodigo, codigo_aplicacion);
        }

        public List<Permiso> obtenerPermisosList(int usuarioCodigo, int codigo_aplicacion)
        {
            Logica capaLogica = new Logica();
            return capaLogica.obtenerPermisosList(usuarioCodigo, codigo_aplicacion);
        }

    }
}
