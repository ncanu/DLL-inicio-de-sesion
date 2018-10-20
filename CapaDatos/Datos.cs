using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetornoCadenaDeConexion;
using System.Data.Odbc;
using System.Data;

namespace CapaDatos
{
    public class Datos
    {



        public List<Permiso> obtenerPermisos(int usuarioCodigo)
        {

            CadenaDeConexion cadenaConexion = new CadenaDeConexion();
            List<Permiso> respuesta = new List<Permiso>();

            try
            {

                using (var conn = new OdbcConnection(cadenaConexion.Conexion()))
                {
                    OdbcDataReader reader;
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select d.api_codigo as aplicacion, d.ingresar, d.editar, d.guardar, d.borrar, d.buscar, d.consultar, d.imprimir FROM usuario a, relacion_usuario_perfil b, perfil_encabezado c, perfil_detalle d WHERE a.usu_codigo = " + usuarioCodigo + " AND b.usu_codigo = a.usu_codigo AND c.perf_cod_encabezado = b.perf_codigo AND d.perf_cod_encabezado = c.perf_cod_encabezado; ";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        List<Permiso> listaPermisos = new List<Permiso>();
                        while (reader.Read())
                        {
                        
                            Permiso permiso = new Permiso();
                            permiso.aplicacion = Convert.ToInt32(reader["aplicacion"]);
                            permiso.ingresar = Convert.ToBoolean(reader["ingresar"]);
                            permiso.editar = Convert.ToBoolean(reader["editar"]);
                            permiso.guardar = Convert.ToBoolean(reader["guardar"]);
                            permiso.borrar = Convert.ToBoolean(reader["borrar"]);
                            permiso.buscar = Convert.ToBoolean(reader["buscar"]);
                            permiso.consultar = Convert.ToBoolean(reader["consultar"]);
                            permiso.imprimir = Convert.ToBoolean(reader["imprimir"]);

                            listaPermisos.Add(permiso);
                            //respuesta = new List<Permiso>();
                           


                        }

                        conn.Close();
                        respuesta = listaPermisos;
                    }

                }

            }
            catch (Exception exception)
            {

            }            

            return respuesta;
        }


      



        public Usuario obtenerObjUsuario(string usuario, string contrasena)
        {

            CadenaDeConexion cadenaConexion = new CadenaDeConexion();

            try
            {
                Usuario user = new Usuario();
                using (var conn = new OdbcConnection(cadenaConexion.Conexion()))
                {
                    OdbcDataReader reader;
                    conn.Open();


                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from usuario where usu_nickname='" + usuario + "' and usu_password='" + contrasena + "'";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            return null;
                        }
                        while (reader.Read())
                        {
                            
                            user.nickName = (reader["usu_nickname"].ToString());
                            user.codigoUsuario = Convert.ToInt32(reader["usu_codigo"].ToString());
                        }

                        conn.Close();

                    }

                }

                if (user.nickName == "" && user.codigoUsuario == 0)
                {
                    return null;
                }

                return user;

            }
            catch (Exception exception)
            {
                return null;
            }

            return null;
        }


    }
}
