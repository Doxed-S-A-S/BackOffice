using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelos
{
    public class ModeloComentario : Modelo
    {
        public int id_post;
        public int id_cuenta;
        public long id_comentario;
        public string Contenido;

        public void GuardarComentario()
        {
            if (this.id_comentario == 0) InsertarComentario();
            if (this.id_comentario > 0) AcualizarComentario();
        }

        private void InsertarComentario()
        {
            try
            {
                string sql = $"insert into comentarios (id_post,contenido) values({this.id_post},@contenido)";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@contenido", this.Contenido);
                this.Comando.Prepare();
                this.Comando.ExecuteNonQuery();
                id_comentario = this.Comando.LastInsertedId;

                sql = $"insert into hace (id_comentario,id_cuenta) values('{this.id_comentario}','{this.id_cuenta}')";
                this.Comando.CommandText = sql;
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }


        public void EliminarComentario()
        {
            try
            {
                string sql = $"update comentarios set eliminado = true where id_comentario ='{this.id_comentario}'";
                this.Comando.CommandText = sql;
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public void AcualizarComentario()
        {
            try
            {
                string sql = $"update comentarios set contenido = @contenido where id_comentario ='{this.id_comentario}'";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@contenido", this.Contenido);
                this.Comando.Prepare();
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public List<ModeloComentario> ObtenerComentarios(string idPost)
        {
            List<ModeloComentario> comentarios = new List<ModeloComentario>();
            try
            {
                

                string sql = $"select * from comentarios where id_post = '{Int32.Parse(idPost)}' and eliminado = false";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloComentario coment = new ModeloComentario();
                    coment.id_comentario = Int32.Parse(this.Lector["id_comentario"].ToString());
                    coment.id_post = Int32.Parse(this.Lector["id_post"].ToString());
                    coment.Contenido = this.Lector["contenido"].ToString();
                    comentarios.Add(coment);
                }
                this.Lector.Close();
                return comentarios;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return comentarios;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }
    }
}
