using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelos;

namespace Controlador

{
    public class ControlCuenta
    {
        public static void CrearCuenta(string nombreUsuario, string email , string contraseña)
        {
            ModeloCuenta cuenta = new ModeloCuenta();
            cuenta.nombre_usuario = nombreUsuario;
            cuenta.email = email;
            cuenta.contraseña = contraseña;

            cuenta.Registro();
        }


        public static void EliminarCuenta(string id,string username)
        {
            ModeloCuenta cuenta = new ModeloCuenta();
            cuenta.id_cuenta = Int32.Parse(id);
            cuenta.nombre_usuario = username;

            cuenta.EliminarCuenta();
        }

        public static void ModificarContraseña(string id, string contraseña)
        {
            ModeloCuenta cuenta = new ModeloCuenta();
            cuenta.id_cuenta = Int32.Parse(id);
            cuenta.contraseña = contraseña;

            cuenta.ModificarContraseña();
        }

        public static void ModificarCorreo(string id, string email)
        {
            ModeloCuenta cuenta = new ModeloCuenta();
            cuenta.id_cuenta = Int32.Parse(id);
            cuenta.email = email;

            cuenta.ModificarCorreo();
        }

        public static string ObtenerCorreo(string idCuenta)
        {
            ModeloCuenta cuenta = new ModeloCuenta();
            cuenta.id_cuenta = Int32.Parse(idCuenta);
            cuenta.ObtenerCorreo();
            return cuenta.email;
        }

        public static Dictionary<string, string> BuscarUsuario(string id)
        {

            Dictionary<string, string> usuario = new Dictionary<string, string>();
            ModeloCuenta cuenta = new ModeloCuenta();
            
            if (cuenta.ObtenerDatosDeCuenta(Int32.Parse(id)))
            {
                usuario.Add("resultado", "true");
                usuario.Add("id_usuario", cuenta.id_cuenta.ToString());
                usuario.Add("nombre_usuario", cuenta.nombre_usuario);
                usuario.Add("nombre", cuenta.nombre);
                usuario.Add("apellido1", cuenta.apellido1);
                usuario.Add("apellido2", cuenta.apellido2);
                usuario.Add("email", ObtenerCorreo(id));
                usuario.Add("biografia", cuenta.biografia);
                usuario.Add("reports", cuenta.reports.ToString());
                return usuario;
            }
            usuario.Add("resultado", "false");
            return usuario;
        }

            public static DataTable ListarCuentas()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("id_cuenta", typeof(int));
            tabla.Columns.Add("Usuario", typeof(string));
            //tabla.Columns.Add("Correo", typeof(string));

            ModeloCuenta cuenta = new ModeloCuenta();
            foreach (ModeloCuenta c in cuenta.ObtenerCuentas())
            {
                DataRow fila = tabla.NewRow();
                fila["id_cuenta"] = c.id_cuenta;
                fila["Usuario"] = c.nombre_usuario;
                //fila["Correo"] = c.email;
                tabla.Rows.Add(fila);
            }
            return tabla;
        }

        public static bool ModificarPreferencias(string idCuenta,string idioma, Boolean recordarContraseña, string preferenciaContenido,
            Boolean notificacionPush, Boolean privacidad, string apariencia)
        {
            ModeloCuenta cuenta = new ModeloCuenta();
            if (cuenta.ObtenerDatosDeCuenta(Int32.Parse(idCuenta)))
            {
                cuenta.idioma_app = idioma;
                cuenta.recordar_contraseña = recordarContraseña;
                cuenta.preferencias_contenido = preferenciaContenido;
                cuenta.notificaciones_push = notificacionPush;
                cuenta.muro_privado = privacidad;
                cuenta.tema_de_apariencia = apariencia;
                cuenta.ModificarPreferencias();
            }
            return false;
        }

    }
}


