using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelos;

namespace Controlador
{
    public class ControlComentarios
    {
        public static void CrearComentario(string idCuenta, string idPost,string comentario)
        {
            try
            {
                ModeloComentario coment = new ModeloComentario();
                coment.id_cuenta = Int32.Parse(idCuenta);
                coment.id_post = Int32.Parse(idPost);
                coment.Contenido = comentario;

                coment.GuardarComentario();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static void EliminarComentario(string idcoment)
        {
            try
            {
                ModeloComentario coment = new ModeloComentario();
                coment.id_comentario = Int32.Parse(idcoment);
                coment.EliminarComentario();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }

        public static void ModificarComentario(string idcoment,string comentario)
        {
            try
            {
                ModeloComentario coment = new ModeloComentario();
                coment.id_comentario = Int32.Parse(idcoment);
                coment.Contenido = comentario;
                coment.GuardarComentario();
            }
            catch (Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
            }
        }


        public static DataTable ListarComentarios(string idPost)
        {
            DataTable tabla = new DataTable();
            try
            {
                
                tabla.Columns.Add("IdComentario", typeof(int));
                tabla.Columns.Add("IdPost", typeof(int));
                tabla.Columns.Add("Comentario", typeof(string));


                ModeloComentario coment = new ModeloComentario();
                foreach (ModeloComentario p in coment.ObtenerComentarios(idPost))
                {
                    DataRow fila = tabla.NewRow();
                    fila["IdComentario"] = p.id_comentario;
                    fila["IdPost"] = p.id_post;
                    fila["Comentario"] = p.Contenido;
                    tabla.Rows.Add(fila);
                }

                return tabla;
            }
            catch(Exception e)
            {
                ErrorsHandle.ErrorHandle(e);
                return tabla;
            }

        }
    }
}