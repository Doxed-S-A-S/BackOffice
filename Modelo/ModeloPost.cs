using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelos
{
    public class ModeloPost : Modelo
    {
        public long id_post;
        public string url_contenido = "url"; 
        public string tipo_contenido = "tag"; 
        public string contenido;
        public string fecha;
        public int reports;
        public int id_cuenta;

        public long id_upvote;
        public int likes;

        public int id_evento;
        public string nombre_evento;
        public string imagen = "image.png";
        public string descripcion_evento;
        public string fecha_evento = "2022-04-22 10:34:53";

        public int id_muro;
        public int id_grupo;


        public void GuardarPost()
        {
            if (this.id_post == 0) InsertarPost();
            if (this.id_post > 0) ActualizarPost();
        }

        public void GuardarEvento()
        {
            if (this.id_evento == 0) InsertarEvento();
            if (this.id_evento > 0) ActualizarEvento();
        }

        private void InsertarPost()
        {
            try
            {
                string sql = $"insert into posts (contenido,url_contenido,url_imagen,tipo_contenido,id_cuenta) " +
    $"values(@contenido,@url_contenido,@url_imagen,@tipo_contenido,{this.id_cuenta})";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@contenido", this.contenido);
                this.Comando.Parameters.AddWithValue("@url_contenido", this.url_contenido);
                this.Comando.Parameters.AddWithValue("@url_imagen", this.imagen);
                this.Comando.Parameters.AddWithValue("@tipo_contenido", this.tipo_contenido);
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

        public void ActualizarPost()
        {
            try
            {
                string sql = $"update posts set contenido = @contenido, url_contenido = @url_contenido,url_imagen = @url_imagen where id_post ='{this.id_post}'";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@contenido", this.contenido);
                this.Comando.Parameters.AddWithValue("@url_contenido", this.url_contenido);
                this.Comando.Parameters.AddWithValue("@url_imagen", this.imagen);
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

        public void EliminarPost()
        {
            try
            {
                string sql = $"update posts set eliminado = true where id_post ='{this.id_post}'";
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

        public bool ObtenerPost(int idPost)
        {
            try
            {
                string sql = $"select * from posts where id_post = {idPost}";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                if (Lector.HasRows)
                {
                    this.Lector.Read();
                    this.id_post = Int32.Parse(this.Lector["id_post"].ToString());
                    this.fecha = this.Lector["fecha_creacion"].ToString();
                    this.url_contenido = this.Lector["url_contenido"].ToString();
                    this.imagen = this.Lector["url_imagen"].ToString();
                    this.tipo_contenido = this.Lector["tipo_contenido"].ToString();
                    this.contenido = this.Lector["contenido"].ToString();
                    this.reports = Int32.Parse(this.Lector["reports"].ToString());
                    this.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    this.Lector.Close();
                    return true;
                }
                return false;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return false;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }
        public List<ModeloPost> ObtenerPosts(int id_cuenta)
        {
            List<ModeloPost> posts = new List<ModeloPost>();
            try
            {
                

                string sql = $"select * from posts where eliminado = false and id_cuenta = {id_cuenta} and reports <= 4";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloPost post = new ModeloPost();
                    post.id_post = Int32.Parse(this.Lector["Id_post"].ToString());
                    post.contenido = this.Lector["Contenido"].ToString();
                    posts.Add(post);
                }
                this.Lector.Close();
                return posts;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return posts;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public List<ModeloPost> ObtenerTodosLosPosts()
        {
            List<ModeloPost> posts = new List<ModeloPost>();
            try
            {
                

                string sql = $"select * from posts where eliminado = false";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloPost post = new ModeloPost();
                    post.id_post = Int32.Parse(this.Lector["Id_post"].ToString());
                    post.contenido = this.Lector["Contenido"].ToString();
                    post.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    posts.Add(post);
                }
                this.Lector.Close();
                return posts;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return posts;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public List<ModeloPost> ObtenerPostsReportados() //ExBack
        {
            List<ModeloPost> posts = new List<ModeloPost>();
            try
            {

                string sql = $"select * from posts where eliminado = false and reports > 4";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloPost post = new ModeloPost();
                    post.id_post = Int32.Parse(this.Lector["Id_post"].ToString());
                    post.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    post.contenido = this.Lector["Contenido"].ToString();
                    post.reports = Int32.Parse(this.Lector["reports"].ToString());
                    posts.Add(post);
                }
                this.Lector.Close();
                return posts;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return posts;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public List<ModeloPost> ObtenerPostsEspecificos(int idPost)
        {
            List<ModeloPost> posts = new List<ModeloPost>();
            try
            {
                

                string sql = $"select * from posts where id_post like '{idPost}%' and eliminado = false and reports <= 4";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloPost post = new ModeloPost();
                    post.id_post = Int32.Parse(this.Lector["Id_post"].ToString());
                    post.contenido = this.Lector["Contenido"].ToString();
                    post.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    posts.Add(post);
                }
                this.Lector.Close();
                return posts;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return posts;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public bool ObtenerEvento()
        {
            try
            {
                string sql = $"select * from evento where id_evento = {this.id_evento}";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                if (Lector.HasRows)
                {
                    this.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    this.id_post = Int32.Parse(this.Lector["Id_post"].ToString());
                    this.contenido = this.Lector["contenido"].ToString();
                    this.url_contenido = this.Lector["url_contenido"].ToString();
                    this.tipo_contenido = this.Lector["tipo_contenido"].ToString();
                    this.id_evento = Int32.Parse(this.Lector["id_evento"].ToString());
                    this.nombre_evento = this.Lector["nombre_evento"].ToString();
                    this.imagen = this.Lector["imagen"].ToString();
                    this.fecha_evento = this.Lector["fecha_evento"].ToString();
                    this.descripcion_evento = this.Lector["descripcion_evento"].ToString();
                    this.Lector.Close();
                    return true;
                }
                return false;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return false;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        private void VerificarEventoEnBD()
        {
            try
            {
                string verificarEventoSql = "SELECT COUNT(*) FROM evento WHERE nombre_evento = @nombre_evento";
                this.Comando.CommandText = verificarEventoSql;
                this.Comando.Parameters.Clear(); // Limpia los parámetros antes de agregar los nuevos
                this.Comando.Parameters.AddWithValue("@nombre_evento", this.nombre_evento);

                long count = (long)this.Comando.ExecuteScalar();

                if (count > 0)
                {
                    throw new Exception("DUPLICATE_ENTRY");
                }
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
        public void InsertarEvento()
        {
            InsertarPost();
            this.id_post = this.Comando.LastInsertedId;
            try
            {
                VerificarEventoEnBD();
                this.Comando.Parameters.Clear();
                string sql = $"INSERT INTO evento (id_post, nombre_evento,imagen,fecha_evento, descripcion_evento) " +
                    $"VALUES('{this.id_post}',@nombre_evento,'{this.imagen}','{this.fecha_evento}',@descripcion_evento)";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@nombre_evento", this.nombre_evento);
                this.Comando.Parameters.AddWithValue("@imagen", this.imagen);
                this.Comando.Parameters.AddWithValue("@descripcion_evento", this.descripcion_evento);
                this.Comando.Prepare();
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
            }
        }

        public List<ModeloPost> ListarEventosDeGrupo(int idGrupo)
        {
            List<ModeloPost> eventos = new List<ModeloPost>();
            try
            {
                

                string sql = $"select evento.id_post,evento.id_evento,posts.url_contenido,posts.contenido,evento.nombre_evento," +
                    $"posts.url_imagen,evento.descripcion_evento,posts.id_cuenta,evento.fecha_evento " +
                    $"from evento join organiza on evento.id_evento = organiza.id_evento " +
                    $"join posts on evento.id_post = posts.id_post " +
                    $"where organiza.id_grupo = {idGrupo} and evento.eliminado = false; ";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloPost ev = new ModeloPost();
                    ev.id_post = Int32.Parse(this.Lector["id_post"].ToString());
                    ev.id_evento = Int32.Parse(this.Lector["id_evento"].ToString());
                    ev.url_contenido = this.Lector["url_contenido"].ToString();
                    ev.contenido = this.Lector["contenido"].ToString();
                    ev.nombre_evento = this.Lector["nombre_evento"].ToString();
                    ev.imagen = this.Lector["url_imagen"].ToString();
                    ev.descripcion_evento = this.Lector["descripcion_evento"].ToString();
                    ev.fecha_evento = this.Lector["fecha_evento"].ToString();
                    ev.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    eventos.Add(ev);
                }
                this.Lector.Close();
                return eventos;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return eventos;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public List<ModeloPost> ListarTodosEventos()
        {
            List<ModeloPost> eventos = new List<ModeloPost>();

            try
            {
                string sql = $"select * from evento where eliminado = false and fecha_evento > sysdate()";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloPost ev = new ModeloPost();
                    ev.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    ev.id_post = Int32.Parse(this.Lector["Id_post"].ToString());
                    ev.contenido = this.Lector["contenido"].ToString();
                    ev.id_evento = Int32.Parse(this.Lector["id_evento"].ToString());
                    ev.nombre_evento = this.Lector["nombre_evento"].ToString();
                    ev.fecha_evento = this.Lector["fecha_evento"].ToString();
                    eventos.Add(ev);
                }
                this.Lector.Close();
                return eventos;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return eventos;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public void EliminarEvento()
        {
            try
            {
                string sql = $"update evento set eliminado = true where id_evento = {this.id_evento}";
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

        public int NumeroDeLikes(long idPost)
        {
            try
            {
                string sql = $"select count(*) from upvote where id_post = {idPost}";
                this.Comando.CommandText = sql;
                string likes = this.Comando.ExecuteScalar().ToString();
                return Int32.Parse(likes);
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return 0;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }
        public void ActualizarEvento()
        {
            ActualizarPost();
            try
            {
                string sql = $"update evento set nombre_evento='{this.nombre_evento}',descripcion_evento='{this.descripcion_evento}' where id_evento ={this.id_evento}";
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

        public void ResetearReports()
        {
            try
            {
                string sql = $"update posts set reports = 0, eliminado = false where id_post = {this.id_post}";
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
    }

}