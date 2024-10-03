using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPost : Modelo
    {
        public long Id_Post;
        public string url_contenido = "url"; //placeholder
        public string tipo_contenido = "tag"; //placeholder
        public string Contenido;
        public string fecha;
        public int reports;
        public int Id_Cuenta;

        public long id_upvote;
        public int likes;

        public int id_evento;
        public string nombre_evento;
        public string imagen = "url imagen";
        public string descripcion_evento;
        public string fecha_evento = "2022-04-22 10:34:53";

        public int id_muro;
        public int id_grupo;

        const int MYSQL_DUPLICATE_ENTRY = 1062;
        const int MYSQL_ACCESS_DENIED = 1045;
        const int MYSQL_UNKNOWN_COLUMN = 1054;
        const int MYSQL_ERROR_CHILD_ROW = 1452;


        public void GuardarPost()
        {
            if (this.Id_Post == 0) InsertarPost();
            if (this.Id_Post > 0) AcutalizarPost();
        }

        public void GuardarEvento()
        {
            if (this.id_evento == 0) InsertarEvento();
            if (this.id_evento > 0) ActualizarEvento();
        }

        private void InsertarPost()
        {
            string sql = $"insert into posts (contenido,url_contenido,tipo_contenido,id_cuenta) " +
                $"values('{this.Contenido}','{this.url_contenido}','{this.tipo_contenido}',{this.Id_Cuenta})";
            PrintDesktop(sql);
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
            
        }

        public void AcutalizarPost()
        {
            string sql = $"update posts set contenido ='{this.Contenido}'where id_post ='{this.Id_Post}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void EliminarPost()
        {
            string sql = $"update posts set eliminado = true where id_post ='{this.Id_Post}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public bool ObtenerPost(int idPost)
        {
            string sql = $"select * from posts where id_post = {idPost}";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            if (Lector.HasRows)
            {
                this.Lector.Read();
                this.Id_Post = Int32.Parse(this.Lector["id_post"].ToString());
                this.fecha = this.Lector["fecha_creacion"].ToString();
                this.url_contenido = this.Lector["url_contenido"].ToString();
                this.tipo_contenido = this.Lector["tipo_contenido"].ToString();
                this.Contenido = this.Lector["contenido"].ToString();
                this.reports = Int32.Parse(this.Lector["reports"].ToString());
                this.Id_Cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                this.Lector.Close();
                return true;
            }
            return false;
        }
        public List<ModeloPost> ObtenerPosts(int id_cuenta)
        {
            List<ModeloPost> posts = new List<ModeloPost>();

            string sql = $"select * from posts where eliminado = false and id_cuenta = {id_cuenta} and reports <= 4";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                ModeloPost post = new ModeloPost();
                post.Id_Post = Int32.Parse(this.Lector["Id_post"].ToString());
                post.Contenido = this.Lector["Contenido"].ToString();
                posts.Add(post);
            }
            this.Lector.Close();
            return posts;
        }

        public List<ModeloPost> ObtenerPostsReportados() //ExBack
        {
            List<ModeloPost> posts = new List<ModeloPost>();

            string sql = $"select * from posts where eliminado = false and reports > 4";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                ModeloPost post = new ModeloPost();
                post.Id_Post = Int32.Parse(this.Lector["Id_post"].ToString());
                post.Contenido = this.Lector["Contenido"].ToString();
                posts.Add(post);
            }
            this.Lector.Close();
            return posts;
        }

        public List<ModeloPost> ObtenerPostsEspecificos(int idPost)
        {
            List<ModeloPost> posts = new List<ModeloPost>();

            string sql = $"select * from posts where id_post like '{idPost}%' and eliminado = false and reports <= 4";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                ModeloPost post = new ModeloPost();
                post.Id_Post = Int32.Parse(this.Lector["Id_post"].ToString());
                post.Contenido = this.Lector["Contenido"].ToString();
                post.Id_Cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                posts.Add(post);
            }
            this.Lector.Close();
            return posts;
        }

        private void VerificarEventoEnBD()
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
        public void InsertarEvento()
        {
            InsertarPost();
            this.Id_Post = this.Comando.LastInsertedId;
            try
            {
                VerificarEventoEnBD();
                this.Comando.Parameters.Clear();
                string sql = $"INSERT INTO evento (id_post, nombre_evento,imagen,fecha_evento, descripcion_evento) " +
                    $"VALUES('{this.Id_Post}',@nombre_evento,'{this.imagen}','{this.fecha_evento}',@descripcion_evento)";
                this.Comando.CommandText = sql;
                PrintDesktop(sql);
                this.Comando.Parameters.AddWithValue("@nombre_evento", this.nombre_evento);
                //this.Comando.Parameters.AddWithValue("@imagen", this.imagen);
                this.Comando.Parameters.AddWithValue("@descripcion_evento", this.descripcion_evento);
                this.Comando.Prepare();
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                if (e.Number == MYSQL_DUPLICATE_ENTRY)
                    throw new Exception("DUPLICATE_ENTRY");
            }
        }

        public void EliminarEvento()
        {
            try
            {
                string sql = $"update evento set eliminado = true where id_evento ='{this.id_evento}'";
                this.Comando.CommandText = sql;
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException sqlx)
            {
                MySqlErrorCatch(sqlx);
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
                MySqlErrorCatch(sqlx);
                return 0;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }
    }

}