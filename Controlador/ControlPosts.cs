using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelos;

namespace Controlador
{
    public class ControlPosts
    {
        public static void CrearPost(string contenido, string idCuenta)
        {
            try
            {
                ModeloPost post = new ModeloPost();
                post.contenido = contenido;
                post.id_cuenta = Int32.Parse(idCuenta);

                post.GuardarPost();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static void ElimiarPost(string id)
        {
            try
            {
                ModeloPost post = new ModeloPost();
                post.id_post = Int32.Parse(id);
                post.EliminarPost();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static void ModificarPost(string id, string contenido)
        {
            try
            {
                ModeloPost post = new ModeloPost();
                post.id_post = Int32.Parse(id);
                post.contenido = contenido;
                post.GuardarPost();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static void ModificarTodoElPost(string id, string contenido, string url)
        {
            try
            {
                ModeloPost post = new ModeloPost();
                post.id_post = Int32.Parse(id);
                post.contenido = contenido;
                post.url_contenido = url;
                post.GuardarPost();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static DataTable ListarPostDeUsuario(string idCuenta)  
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla.Columns.Add("Id_Post", typeof(int));
                tabla.Columns.Add("Contenido", typeof(string));


                ModeloPost post = new ModeloPost();
                foreach (ModeloPost p in post.ObtenerPosts(Int32.Parse(idCuenta)))
                {
                    DataRow fila = tabla.NewRow();
                    fila["Id_post"] = p.id_post;
                    fila["Contenido"] = p.contenido;
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

        public static DataTable ListarTodos()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla.Columns.Add("ID del post", typeof(int));
                tabla.Columns.Add("Contenido", typeof(string));
                tabla.Columns.Add("ID de cuenta", typeof(int));


                ModeloPost post = new ModeloPost();
                foreach (ModeloPost p in post.ObtenerTodosLosPosts())
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID del post"] = p.id_post;
                    fila["Contenido"] = p.contenido;
                    fila["ID de cuenta"] = p.id_cuenta;
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

        public static Dictionary<string,string> ObtenerPost(string idPost)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            try
            {
                ModeloPost p = new ModeloPost();
                if (p.ObtenerPost(Int32.Parse(idPost)))
                {
                    post.Add("resultado", "true");
                    post.Add("id Post", p.id_post.ToString());
                    post.Add("contenido", p.contenido);
                    post.Add("fecha", p.fecha);
                    post.Add("url_contenido", p.url_contenido);
                    post.Add("imagen", p.imagen);
                    post.Add("reports", p.reports.ToString());
                    post.Add("id_cuenta", p.id_cuenta.ToString());
                    return post;
                }
                post.Add("resultado", "false");
                return post;
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return post;
            }
        }

        public static DataTable ListarReportados() //ExBackO
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla.Columns.Add("ID del post", typeof(int));
                tabla.Columns.Add("ID de cuenta", typeof(int));
                tabla.Columns.Add("Contenido", typeof(string));
                tabla.Columns.Add("Reports", typeof(int));


                ModeloPost post = new ModeloPost();
                foreach (ModeloPost p in post.ObtenerPostsReportados())
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID del post"] = p.id_post;
                    fila["ID de cuenta"] = p.id_cuenta;
                    fila["Contenido"] = p.contenido;
                    fila["Reports"] = p.reports;
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

        public static DataTable ListarPostEspecificos(string idPost)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla.Columns.Add("ID del post", typeof(int));
                tabla.Columns.Add("Contenido", typeof(string));
                tabla.Columns.Add("ID de cuenta", typeof(int));


                ModeloPost post = new ModeloPost();
                foreach (ModeloPost p in post.ObtenerPostsEspecificos(Int32.Parse(idPost)))
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID del post"] = p.id_post;
                    fila["Contenido"] = p.contenido;
                    fila["ID de cuenta"] = p.id_cuenta;
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

        public static void ElimiarEvento(string idPost, string idEvento)
        {
            try
            {
                ElimiarPost(idPost);
                ModeloPost evento = new ModeloPost();
                evento.id_evento = Int32.Parse(idEvento);
                evento.EliminarEvento();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static void ModificarEvento(string idPost, string idEvento, string urlContenido, string contenido, string nombreEvento, string imagen, string descripcionEvento, string idCuenta)
        {
            try
            {
                ModeloPost evento = new ModeloPost();
                evento.id_post = Int32.Parse(idPost);
                evento.id_evento = Int32.Parse(idEvento);
                evento.url_contenido = urlContenido;
                //evento.tipo_contenido = tipo_contenido;
                evento.contenido = contenido;
                evento.nombre_evento = nombreEvento;
                evento.imagen = imagen;
                evento.descripcion_evento = descripcionEvento;
                evento.id_cuenta = Int32.Parse(idCuenta);

                evento.GuardarEvento();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static DataTable ListarEventosDeGrupo(string idGrupo)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla.Columns.Add("Id_Post", typeof(int));
                tabla.Columns.Add("Id_Evento", typeof(int));
                tabla.Columns.Add("Url multimedia", typeof(string));
                tabla.Columns.Add("Contenido", typeof(string));
                tabla.Columns.Add("Nombre del evento", typeof(string));
                tabla.Columns.Add("Url de la imagen", typeof(string));
                tabla.Columns.Add("Descripcion del evento", typeof(string));
                tabla.Columns.Add("Fecha evento", typeof(string));
                tabla.Columns.Add("Id_Cuenta", typeof(int));


                ModeloPost evento = new ModeloPost();
                foreach (ModeloPost e in evento.ListarEventosDeGrupo(Int32.Parse(idGrupo)))
                {
                    DataRow fila = tabla.NewRow();
                    fila["Id_post"] = e.id_post;
                    fila["Id_Evento"] = e.id_evento;
                    fila["Url multimedia"] = e.url_contenido;
                    fila["Contenido"] = e.contenido;
                    fila["Nombre del evento"] = e.nombre_evento;
                    fila["Url de la imagen"] = e.imagen;
                    fila["Descripcion del evento"] = e.descripcion_evento;
                    fila["Fecha evento"] = e.fecha_evento;
                    fila["Id_Cuenta"] = e.id_cuenta;
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

        public static void PostResuelto(string idPost)
        {
            try
            {
                ModeloPost post = new ModeloPost();
                post.id_post = Int32.Parse(idPost);

                post.ResetearReports();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

    }
}
