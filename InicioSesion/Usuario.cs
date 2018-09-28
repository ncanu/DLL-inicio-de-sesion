using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;

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

    }
}
