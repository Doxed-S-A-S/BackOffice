using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloComentario : Modelo
    {
        public int IdPost;
        public int IdComentario;
        public string Comentario;
        public int ReaccionesCom;

        public void GuardarComentario()
        {
            string sql = $"insert into Comentarios (Comentario,C_Reacciones) values('{this.Comentario}',{this.ReaccionesCom})";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void EliminarComentario()
        {
            string sql = $"update Comentarios set Eliminado = true where ID_comentario ='{this.IdComentario}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public List<ModeloComentario> ObtenerComentarios()
        {
            List<ModeloComentario> comentarios = new List<ModeloComentario>();

            string sql = $"select * from Comentarios where ID_post = '{this.IdPost}' and Eliminado = false";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();

            while (this.Lector.Read())
            {
                ModeloComentario coment = new ModeloComentario();
                coment.IdPost = Int32.Parse(this.Lector["IdPost"].ToString());
                coment.IdComentario = Int32.Parse(this.Lector["IdComentario"].ToString());
                coment.Comentario = this.Lector["Comentario"].ToString();
                coment.ReaccionesCom = Int32.Parse(this.Lector["ReaccionesCom"].ToString());
                comentarios.Add(coment);
            }
            return comentarios;
        }
    }
}
