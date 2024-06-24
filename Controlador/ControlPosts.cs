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
        public static void CrearPost(string contenido, string reacciones)
        {
            ModeloPost post = new ModeloPost();
            post.Contenido = contenido;
            post.Reacciones = Int32.Parse(reacciones);

            post.Guardar();
        }

        public static void ElimiarPost(string id)
        {
            ModeloPost post = new ModeloPost();
            post.id = Int32.Parse(id);
            post.Eliminar();
        }

        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Contenido", typeof(string));
            tabla.Columns.Add("Reaccion", typeof(int));


            ModeloPost pizza = new ModeloPost();
            foreach (ModeloPost p in pizza.ObtenerPosts())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = p.id;
                fila["Nombre"] = p.Contenido;
                fila["Precio"] = p.Reacciones;
                tabla.Rows.Add(fila);
            }

            return tabla;

        }
    }
}
