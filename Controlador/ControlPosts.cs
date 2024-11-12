﻿using System;
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
            ModeloPost post = new ModeloPost();
            post.Contenido = contenido;
            post.Id_Cuenta = Int32.Parse(idCuenta);

            post.GuardarPost();
        }

        public static void ElimiarPost(string id)
        {
            ModeloPost post = new ModeloPost();
            post.Id_Post = Int32.Parse(id);
            post.EliminarPost();
        }

        public static void ModificarPost(string id, string contenido)
        {
            ModeloPost post = new ModeloPost();
            post.Id_Post = Int32.Parse(id);
            post.Contenido = contenido;
            post.GuardarPost();
        }

        public static void ModificarTodoElPost(string id, string contenido, string url)
        {
            ModeloPost post = new ModeloPost();
            post.Id_Post = Int32.Parse(id);
            post.Contenido = contenido;
            post.url_contenido = url;
            post.GuardarPost();
        }

        public static DataTable ListarPostDeUsuario(string idCuenta)  
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id_Post", typeof(int));
            tabla.Columns.Add("Contenido", typeof(string));


            ModeloPost post = new ModeloPost();
            foreach (ModeloPost p in post.ObtenerPosts(Int32.Parse(idCuenta))) 
            {
                DataRow fila = tabla.NewRow();
                fila["Id_post"] = p.Id_Post;
                fila["Contenido"] = p.Contenido;
                tabla.Rows.Add(fila);
            }

            return tabla;

        }

        public static DataTable ListarTodos()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID del post", typeof(int));
            tabla.Columns.Add("Contenido", typeof(string));
            tabla.Columns.Add("ID de cuenta", typeof(int));


            ModeloPost post = new ModeloPost();
            foreach (ModeloPost p in post.ObtenerTodosLosPosts())
            {
                DataRow fila = tabla.NewRow();
                fila["ID del post"] = p.Id_Post;
                fila["Contenido"] = p.Contenido;
                fila["ID de cuenta"] = p.Id_Cuenta;
                tabla.Rows.Add(fila);
            }
            return tabla;
        }

        public static Dictionary<string,string> ObtenerPost(string idPost)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            ModeloPost p = new ModeloPost();
            if (p.ObtenerPost(Int32.Parse(idPost)))
            {
                post.Add("resultado", "true");
                post.Add("id Post", p.Id_Post.ToString());
                post.Add("contenido", p.Contenido);
                post.Add("fecha", p.fecha);
                post.Add("url_contenido", p.url_contenido);
                post.Add("imagen", p.imagen);
                post.Add("reports", p.reports.ToString());
                post.Add("id_cuenta", p.Id_Cuenta.ToString());
                return post;
            }
            post.Add("resultado", "false");
            return post;
        }

        public static DataTable ListarReportados() //ExBackO
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID del post", typeof(int));
            tabla.Columns.Add("ID de cuenta", typeof(int));
            tabla.Columns.Add("Contenido", typeof(string));
            tabla.Columns.Add("Reports", typeof(int));


            ModeloPost post = new ModeloPost();
            foreach (ModeloPost p in post.ObtenerPostsReportados())
            {
                DataRow fila = tabla.NewRow();
                fila["ID del post"] = p.Id_Post;
                fila["ID de cuenta"] = p.Id_Cuenta;
                fila["Contenido"] = p.Contenido;
                fila["Reports"] = p.reports;
                tabla.Rows.Add(fila);
            }
            return tabla;
        }

        public static DataTable ListarPostEspecificos(string idPost)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID del post", typeof(int));
            tabla.Columns.Add("Contenido", typeof(string));
            tabla.Columns.Add("ID de cuenta", typeof(int));


            ModeloPost post = new ModeloPost();
            foreach (ModeloPost p in post.ObtenerPostsEspecificos(Int32.Parse(idPost)))
            {
                DataRow fila = tabla.NewRow();
                fila["ID del post"] = p.Id_Post;
                fila["Contenido"] = p.Contenido;
                fila["ID de cuenta"] = p.Id_Cuenta;
                tabla.Rows.Add(fila);
            }
            return tabla;
        }

        public static void ElimiarEvento(string id_post, string id_evento)
        {
            try
            {
                ElimiarPost(id_post);
                ModeloPost evento = new ModeloPost();
                evento.id_evento = Int32.Parse(id_evento);
                evento.EliminarEvento();
            }
            catch (Exception sqlx)
            {
                
            }
        }

        public static void ModificarEvento(string Id_Post, string id_evento, string url_contenido, string contenido, string nombre_evento, string imagen, string descripcion_evento, string id_cuenta)
        {
            try
            {
                ModeloPost evento = new ModeloPost();
                evento.Id_Post = Int32.Parse(Id_Post);
                evento.id_evento = Int32.Parse(id_evento);
                evento.url_contenido = url_contenido;
                //evento.tipo_contenido = tipo_contenido;
                evento.Contenido = contenido;
                evento.nombre_evento = nombre_evento;
                evento.imagen = imagen;
                evento.descripcion_evento = descripcion_evento;
                evento.Id_Cuenta = Int32.Parse(id_cuenta);

                evento.GuardarEvento();
            }
            catch (Exception e)
            {

            }
        }

        public static DataTable ListarEventosDeGrupo(string idGrupo)
        {
            DataTable tabla = new DataTable();
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
                fila["Id_post"] = e.Id_Post;
                fila["Id_Evento"] = e.id_evento;
                fila["Url multimedia"] = e.url_contenido;
                fila["Contenido"] = e.Contenido;
                fila["Nombre del evento"] = e.nombre_evento;
                fila["Url de la imagen"] = e.imagen;
                fila["Descripcion del evento"] = e.descripcion_evento;
                fila["Fecha evento"] = e.fecha_evento;
                fila["Id_Cuenta"] = e.Id_Cuenta;
                tabla.Rows.Add(fila);
            }
            return tabla;
        }

    }
}
