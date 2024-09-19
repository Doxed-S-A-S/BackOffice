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

        public static DataTable Listar(string idCuenta)  
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

        public static Dictionary<string,string> ObtenerPost(string idPost)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            ModeloPost p = new ModeloPost();
            if (p.ObtenerPost(Int32.Parse(idPost)))
            {
                post.Add("resultado", "true");
                post.Add("contenido", p.Contenido);
                post.Add("fecha", p.fecha);
                post.Add("url_contenido", p.url_contenido);
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
            tabla.Columns.Add("Id_Post", typeof(int));
            tabla.Columns.Add("Contenido", typeof(string));


            ModeloPost post = new ModeloPost();
            foreach (ModeloPost p in post.ObtenerPostsReportados())
            {
                DataRow fila = tabla.NewRow();
                fila["Id_post"] = p.Id_Post;
                fila["Contenido"] = p.Contenido;
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

    }
}
