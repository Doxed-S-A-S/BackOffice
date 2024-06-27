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
        public static void CrearComentario(int idPost,string comentario,string reacciones)
        {
            ModeloComentario coment = new ModeloComentario();
            coment.IdPost = idPost;
            coment.Comentario = comentario;
            coment.ReaccionesCom = Int32.Parse(reacciones);

            coment.GuardarComentario();
        }

        public static void EliminarComentario(string idcoment)
        {
            ModeloComentario coment = new ModeloComentario();
            coment.IdComentario = Int32.Parse(idcoment);
            coment.GuardarComentario();
        }


    }
}
