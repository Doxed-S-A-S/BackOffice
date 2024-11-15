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
        public static void CrearCuenta(string nombreUsuario, string email, string contraseña)
        {
            try
            {
                ModeloCuenta cuenta = new ModeloCuenta();
                cuenta.nombre_usuario = nombreUsuario;
                cuenta.email = email;
                cuenta.contraseña = contraseña;

                cuenta.Registro();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static void EliminarCuenta(string idCuenta, string username)
        {
            try
            {
                ModeloCuenta cuenta = new ModeloCuenta();
                cuenta.id_cuenta = Int32.Parse(idCuenta);
                cuenta.nombre_usuario = username;

                cuenta.EliminarCuenta();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static bool Login(string username, string contraseña)
        {
            try
            {
                ModeloCuenta c = new ModeloCuenta();
                c.nombre_usuario = username;
                c.contraseña = contraseña;

                return c.Autenticar();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return false;
            }
        }

        public static bool ModificarContraseña(string idCuenta, string contraseña, string contraseñaAntigua)
        {
            try
            {
                ModeloCuenta c = new ModeloCuenta();
                if (c.ModificarContraseña(Int32.Parse(idCuenta)) && (c.ContraseñaExiste(Int32.Parse(idCuenta), contraseñaAntigua)))
                {
                    c.id_cuenta = Int32.Parse(idCuenta);
                    c.contraseña = contraseña;

                    c.ModificarContraseña(Int32.Parse(idCuenta));
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return false;
            }

        }

        public static string ObtenerCorreo(string idCuenta)
        {
            try
            {
                ModeloCuenta cuenta = new ModeloCuenta();
                cuenta.id_cuenta = Int32.Parse(idCuenta);
                cuenta.ObtenerCorreo();
                return cuenta.email;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return "Error";
            }

        }

        public static bool ModificarCorreo(string idCuenta, string email)
        {
            try
            {
                ModeloCuenta cuenta = new ModeloCuenta();
                if (cuenta.ModificarCorreo(Int32.Parse(idCuenta)))
                {
                    cuenta.id_cuenta = Int32.Parse(idCuenta);
                    cuenta.email = email;

                    cuenta.ModificarCorreo(Int32.Parse(idCuenta));
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return false;
            }
        }

        public static void ModificarBio(string idCuenta, string bio)
        {
            ModeloCuenta cuenta = new ModeloCuenta();
            cuenta.biografia = bio;
            cuenta.id_cuenta = Int32.Parse(idCuenta);

            cuenta.ModificarBio();
        }

        public static bool ModificarPreferencias(string idCuenta, string idioma, Boolean recordarContraseña, string preferenciaContenido,
    Boolean notificacionPush, Boolean privacidad, string apariencia)
        {
            try
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
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return false;
            }
        }


        public static Dictionary<string, string> BuscarUsuario(string idCuenta)
        {
            Dictionary<string, string> usuario = new Dictionary<string, string>();
            try
            {
                
                ModeloCuenta u = new ModeloCuenta();
                if (u.ObtenerDatosDeCuenta(Int32.Parse(idCuenta)))
                {
                    usuario.Add("resultado", "true");
                    usuario.Add("id_usuario", u.id_cuenta.ToString());
                    usuario.Add("nombre_usuario", u.nombre_usuario);
                    usuario.Add("nombre", u.nombre);
                    usuario.Add("apellido1", u.apellido1);
                    usuario.Add("apellido2", u.apellido2);
                    usuario.Add("email", ObtenerCorreo(idCuenta));
                    usuario.Add("biografia", u.biografia);
                    usuario.Add("reports", u.reports.ToString());
                    usuario.Add("rol", u.rol_cuenta);
                    return usuario;
                }
                usuario.Add("resultado", "false");
                return usuario;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                usuario.Add("resultado", "false");
                return usuario;
            }
        }

        public static DataTable ListarCuentas()
        {
            DataTable tabla = new DataTable();
            try
            {
                
                tabla.Columns.Add("ID", typeof(int));
                tabla.Columns.Add("Usuario", typeof(string));
                tabla.Columns.Add("Rol", typeof(string));
                tabla.Columns.Add("Miembro desde", typeof(DateTime));
                tabla.Columns.Add("Reports", typeof(int));
                tabla.Columns.Add("Blocked", typeof(string));

                ModeloCuenta cuenta = new ModeloCuenta();
                foreach (ModeloCuenta c in cuenta.ObtenerCuentas())
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID"] = c.id_cuenta;
                    fila["Usuario"] = c.nombre_usuario;
                    fila["Rol"] = c.rol_cuenta;
                    fila["Miembro desde"] = c.miembro_desde;
                    fila["Reports"] = c.reports;
                    fila["Blocked"] = c.eliminado.ToString();
                    tabla.Rows.Add(fila);
                }
                return tabla;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return tabla;
            }
        }

        public static Dictionary<string, string> BuscarPreferencia(string idCuenta)
        {
            Dictionary<string, string> preferencia = new Dictionary<string, string>();
            try
            {
                
                ModeloCuenta cuenta = new ModeloCuenta();
                if (cuenta.BuscarPreferencias(Int32.Parse(idCuenta)))
                {
                    preferencia.Add("resultado", "true");
                    preferencia.Add("tema de apariencia", cuenta.tema_de_apariencia);
                    preferencia.Add("idioma", cuenta.idioma_app);
                    preferencia.Add("preferencias", cuenta.preferencias_contenido);
                    preferencia.Add("recordar contraseña", cuenta.recordar_contraseña.ToString());
                    preferencia.Add("notificaciones push", cuenta.notificaciones_push.ToString());
                    preferencia.Add("muro privado", cuenta.muro_privado.ToString());
                    return preferencia;
                }
                preferencia.Add("resultado", "true");
                return preferencia;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                preferencia.Add("resultado", "false");
                return preferencia;
            }
        }

        public static Boolean CrearModerador(string nombre,string pass, string super)
        {
            try
            {
                ModeloCuenta mod = new ModeloCuenta();

                mod.mod_nombre = nombre;
                mod.mod_contraseña = pass;
                mod.mod_super = super;

                mod.CrearModerador();
                return true;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return false;
            }

        }

        public static void EliminarMod(string nombre)
        {
            ModeloCuenta mod = new ModeloCuenta();

            mod.mod_nombre = nombre;

            mod.EliminarModerador();
        }

        public static DataTable ListarMods()
        {
            DataTable tabla = new DataTable();
            try
            {
                
                tabla.Columns.Add("Nombre", typeof(string));
                

                ModeloCuenta cuenta = new ModeloCuenta();
                foreach (ModeloCuenta m in cuenta.ObtenerMods())
                {
                    DataRow fila = tabla.NewRow();
                    fila["Nombre"] = m.mod_nombre.ToString();
                    tabla.Rows.Add(fila);
                }
                return tabla;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return tabla;
            }
        }

        public static Dictionary<string, string> AutenticarMod(string nombre, string pass)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            try
            {
                
                ModeloCuenta cuenta = new ModeloCuenta();

                cuenta.mod_nombre = nombre;
                cuenta.mod_contraseña = pass;

                if (cuenta.VerificarRegistroMod())
                {
                    resultado.Add("resultado", "true");
                    resultado.Add("super", cuenta.mod_super);
                    return resultado;
                }
                resultado.Add("resultado", "false");
                return resultado;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                resultado.Add("resultado", "false");
                return resultado;
            }
        }
    }
}


