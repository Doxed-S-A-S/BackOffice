using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;


namespace Controlador
{
    public class ControlGrupo
    {
        public static void CrearGrupo(string idCuenta, string nombreGrupo, string descripcion, string privacidad, string urlImagen)
        {
            try
            {
                ModeloGrupo grupo = new ModeloGrupo();
                grupo.nombre_grupo = nombreGrupo;
                grupo.descripcion = descripcion;
                grupo.privacidad = bool.Parse(privacidad);
                grupo.url_imagen = urlImagen;
                grupo.id_cuenta = Int32.Parse(idCuenta);

                grupo.CrearGrupo();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static bool ModificarGrupo(string id, string nombre, string descripcion)
        {
            try
            {
                ModeloGrupo grupo = new Modelos.ModeloGrupo();
                if (grupo.BuscarGrupo(Int32.Parse(id)))
                {
                    grupo.nombre_grupo = nombre;
                    grupo.descripcion = descripcion;

                    grupo.Guardar();
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


        public static void ModificarPrivacidadGrupo(string idGrupo, string privacidad)
        {
            try
            {
                ModeloGrupo grupo = new Modelos.ModeloGrupo();
                grupo.id_grupo = Int32.Parse(idGrupo);
                grupo.privacidad = bool.Parse(privacidad);

                grupo.ModificarPrivacidadGrupo();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }



        public static bool EliminarGrupo(string idGrupo)
        {
            try
            {
                ModeloGrupo grupo = new Modelos.ModeloGrupo();
                if (grupo.BuscarGrupo(Int32.Parse(idGrupo)))
                {
                    grupo.EliminarGrupo();
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

        public static DataTable ObtenerGrupos()
        {
            DataTable tabla = new DataTable();
            try
            {
                
                tabla.Columns.Add("ID del grupo", typeof(int));
                tabla.Columns.Add("Nombre", typeof(string));
                tabla.Columns.Add("Descripcion", typeof(string));


                ModeloGrupo grupo = new ModeloGrupo();
                foreach (ModeloGrupo p in grupo.ObtenerGrupos())
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID del grupo"] = p.id_grupo;
                    fila["Nombre"] = p.nombre_grupo;
                    fila["Descripcion"] = p.descripcion;
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

        public static DataTable ObtenerIntegrantesDeGrupo(string idGrupo)
        {
            DataTable tabla = new DataTable();
            try
            {
                
                tabla.Columns.Add("ID cuenta", typeof(int));
                tabla.Columns.Add("nombre_grupo", typeof(string));
                tabla.Columns.Add("Username", typeof(string));
                tabla.Columns.Add("Rol", typeof(string));


                ModeloGrupo grupo = new ModeloGrupo();
                foreach (ModeloGrupo p in grupo.ObtenerIntegrantesDeGrupo(Int32.Parse(idGrupo)))
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID cuenta"] = p.id_cuenta;
                    fila["nombre_grupo"] = p.nombre_grupo;
                    fila["Username"] = p.nombre_usuario;
                    fila["Rol"] = p.rol;
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

        public static DataTable ObtenerResponsablesDeGrupo(string idGrupo)
        {
            DataTable tabla = new DataTable();
            try
            {
                
                tabla.Columns.Add("id_cuenta", typeof(int));
                tabla.Columns.Add("Username", typeof(string));
                tabla.Columns.Add("rol", typeof(string));


                ModeloGrupo grupo = new ModeloGrupo();
                foreach (ModeloGrupo g in grupo.ObtenerResponsablesDeGrupo(Int32.Parse(idGrupo)))
                {
                    DataRow fila = tabla.NewRow();
                    fila["id_cuenta"] = g.id_cuenta;
                    fila["Username"] = g.nombre_usuario;
                    fila["rol"] = g.rol;
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

        public static Dictionary<string, string> BuscarGrupo(string idGrupo)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            try
            {
                
                ModeloGrupo grupo = new ModeloGrupo();
                if (grupo.BuscarGrupo(Int32.Parse(idGrupo)))
                {
                    resultado.Add("resultado", "true");
                    resultado.Add("id", grupo.id_grupo.ToString());
                    resultado.Add("nombre_grupo", grupo.nombre_grupo);
                    resultado.Add("descripcion", grupo.descripcion);
                    resultado.Add("reports", grupo.reports.ToString());
                    resultado.Add("privacidad", grupo.privacidad.ToString());
                    resultado.Add("url_imagen", grupo.url_imagen);
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

        public static Dictionary<string, string> AgregarCuentaEnGrupo(string rol, string idGrupo, string idCuenta)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            try
            {
                

                ModeloGrupo grupo = new ModeloGrupo();
                grupo.id_cuenta = Int32.Parse(idCuenta);
                grupo.id_grupo = Int32.Parse(idGrupo);
                grupo.rol = rol;

                if (!grupo.FormaParteDelGrupo())
                {
                    grupo.AgregarCuentaEnGrupo();
                    resultado.Add("resultado", "true");
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
        public static Dictionary<string, string> EliminarCuentaDeGrupo(string idGrupo, string idCuenta)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            try
            {
                

                ModeloGrupo grupo = new ModeloGrupo();
                grupo.id_cuenta = Int32.Parse(idCuenta);
                grupo.id_grupo = Int32.Parse(idGrupo);

                if (!grupo.FormaParteDelGrupo())
                {

                    resultado.Add("resultado", "false");
                    return resultado;
                }
                grupo.EliminarCuentaDeGrupo();
                resultado.Add("resultado", "true");
                return resultado;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                resultado.Add("resultado", "false");
                return resultado;
            }
        }
        public static Dictionary<string, string> CambiarRolDeCuentaEnGrupo(string idCuenta, string idGrupo, string rol)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            try
            {
                

                ModeloGrupo grupo = new ModeloGrupo();
                grupo.id_cuenta = Int32.Parse(idCuenta);
                grupo.id_grupo = Int32.Parse(idGrupo);
                grupo.rol = rol;

                if (!grupo.FormaParteDelGrupo())
                {
                    resultado.Add("resultado", "false");
                    return resultado;
                }
                grupo.CambiarRolDeCuentaEnGrupo();
                resultado.Add("resultado", "true");
                return resultado;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                resultado.Add("resultado", "false");
                return resultado;
            }
        }

        public static void AñadirReportGrupo(string idGrupo)
        {
            try
            {
                ModeloGrupo grupo = new ModeloGrupo();
                grupo.id_grupo = Int32.Parse(idGrupo);

                grupo.AñadirReporteGrupo();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static DataTable PostDeGrupo(string idGrupo)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Username", typeof(string));
            tabla.Columns.Add("ID", typeof(int));
            tabla.Columns.Add("Contenido", typeof(string));


            ModeloGrupo grupo = new ModeloGrupo();
            foreach (ModeloGrupo g in grupo.ObtenerPostsDeGrupo(Int32.Parse(idGrupo)))
            {
                DataRow fila = tabla.NewRow();
                fila["Username"] = g.nombre_usuario;
                fila["ID"] = g.id_post;
                fila["Contenido"] = g.postContenido;
                tabla.Rows.Add(fila);
            }
            return tabla;
        }

    }
}
