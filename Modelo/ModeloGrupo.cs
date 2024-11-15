using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelos
{
    public class ModeloGrupo : Modelo
    {
        public long id_grupo;
        public string nombre_grupo;
        public string descripcion;
        public string url_imagen;
        public Boolean privacidad;
        public int reports;

        public string rol;
        public int id_cuenta;
        public string nombre_usuario;

        public int id_post;
        public string postContenido;

        public void Guardar()
        {
            if (this.id_grupo == 0) CrearGrupo();
            if (this.id_grupo > 0) ModificarGrupo();
        }
        public void CrearGrupo()
        {
            try
            {
                string sql = $"insert into grupos (nombre_grupo,descripcion,privacidad,url_imagen) values(@nombre_grupo,@descripcion,{this.privacidad},@url_imagen)";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@nombre_grupo", this.nombre_grupo);
                this.Comando.Parameters.AddWithValue("@descripcion", this.descripcion);
                this.Comando.Parameters.AddWithValue("@url_imagen", this.url_imagen);
                this.Comando.Prepare();
                this.Comando.ExecuteNonQuery();
                this.id_grupo = this.Comando.LastInsertedId;
                AsignarGrupoOwner();
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
        private void ModificarGrupo()
        {
            try
            {
                string sql = $"UPDATE grupos set nombre_grupo =@nombre_grupo, descripcion = @descripcion WHERE id_grupo = {this.id_grupo}";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@nombre_grupo", this.nombre_grupo);
                this.Comando.Parameters.AddWithValue("@descripcion", this.descripcion);
                this.Comando.Prepare();
                this.Comando.ExecuteNonQuery();
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
            }
            catch (Exception )
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }
        public void ModificarNombreGrupo()
        {
            try
            {
                string sql = $"update grupos set nombre_grupo = @nombre_grupo where id_grupo ='{this.id_grupo}'";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@nombre_grupo", this.nombre_grupo);
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
        public void ModificarDescripcionGrupo()
        {
            try
            {
                string sql = $"update grupos set descripcion = '{this.descripcion}' where id_grupo = '{this.id_grupo}'";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.AddWithValue("@descripcion", this.descripcion);
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

        public void ModificarPrivacidadGrupo()
        {
            try
            {
                string sql = $"update grupos set privacidad = {this.privacidad} where id_grupo = {this.id_grupo}";
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
        public void EliminarGrupo()
        {
            try
            {
                string sql = $"update grupos set eliminado = true where id_grupo ='{this.id_grupo}'";
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
        public List<ModeloGrupo> ObtenerGrupos()
        {
            try
            {
                List<ModeloGrupo> grupos = new List<ModeloGrupo>();

                string sql = $"select * from grupos where eliminado = false";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloGrupo grupo = new ModeloGrupo();
                    grupo.id_grupo = Int32.Parse(this.Lector["id_grupo"].ToString());
                    grupo.nombre_grupo = this.Lector["nombre_grupo"].ToString();
                    grupo.descripcion = this.Lector["descripcion"].ToString();
                    grupos.Add(grupo);
                }
                this.Lector.Close();

                return grupos;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return null;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public List<ModeloGrupo> ObtenerIntegrantesDeGrupo(int id)
        {
            try
            {
                List<ModeloGrupo> grupos = new List<ModeloGrupo>();

                string sql = $"SELECT cuenta.nombre_usuario, grupos.nombre_grupo AS nombre_grupo, conforma.rol, cuenta.id_cuenta " +
                             $"FROM cuenta JOIN conforma ON cuenta.id_cuenta = conforma.id_cuenta " +
                             $"JOIN grupos ON conforma.id_grupo = grupos.id_grupo " +
                             $"WHERE grupos.id_grupo ='{id}'";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloGrupo grupo = new ModeloGrupo();
                    grupo.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    grupo.nombre_usuario = this.Lector["nombre_usuario"].ToString();
                    grupo.nombre_grupo = this.Lector["nombre_grupo"].ToString();
                    grupo.rol = this.Lector["rol"].ToString();
                    grupos.Add(grupo);
                }
                this.Lector.Close();

                return grupos;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return null;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }


        public List<ModeloGrupo> ObtenerResponsablesDeGrupo(int id)
        {
            try
            {
                List<ModeloGrupo> grupos = new List<ModeloGrupo>();

                string sql = $"SELECT cuenta.id_cuenta,cuenta.nombre_usuario,conforma.rol " +
                    $"FROM cuenta JOIN conforma ON cuenta.id_cuenta = conforma.id_cuenta " +
                    $"JOIN grupos ON conforma.id_grupo = grupos.id_grupo " +
                    $"WHERE grupos.id_grupo = {id}";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloGrupo grupo = new ModeloGrupo();
                    grupo.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                    grupo.nombre_usuario = this.Lector["nombre_usuario"].ToString();
                    grupo.rol = this.Lector["rol"].ToString();
                    grupos.Add(grupo);
                }
                this.Lector.Close();

                return grupos;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return null;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }

        public List<ModeloGrupo> ObtenerPostsDeGrupo(int id_grupo)
        {
            try
            {
                List<ModeloGrupo> posts = new List<ModeloGrupo>();

                string sql = $"select grupos.id_grupo,posts.id_post,posts.contenido,posts.id_cuenta,cuenta.nombre_usuario " +
                    $"from grupos join postea_grupos on grupos.id_grupo = postea_grupos.id_grupo " +
                    $"join posts on postea_grupos.id_post = posts.id_post " +
                    $"join cuenta on posts.id_cuenta = cuenta.id_cuenta " +
                    $"where grupos.id_grupo = {id_grupo} and posts.eliminado = false";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    ModeloGrupo grupo = new ModeloGrupo();
                    grupo.id_post = Int32.Parse(this.Lector["id_post"].ToString());
                    grupo.postContenido = this.Lector["contenido"].ToString();
                    grupo.nombre_usuario = this.Lector["nombre_usuario"].ToString();

                    posts.Add(grupo);
                }
                this.Lector.Close();
                return posts;
            }
            catch (MySqlException sqlx)
            {
                BDErrorsHandle.MySqlErrorCatch(sqlx);
                return null;
            }
            catch (Exception)
            {
                throw new Exception("UNKNOWN_ERROR");
            }
        }


        public bool BuscarGrupo(int id)
        {
            try
            {
                string sql = $"select * from grupos where eliminado = false and id_grupo = {id}";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                if (this.Lector.HasRows)
                {
                    this.Lector.Read();
                    this.id_grupo = Int32.Parse(this.Lector["id_grupo"].ToString());
                    this.nombre_grupo = this.Lector["nombre_grupo"].ToString();
                    this.descripcion = this.Lector["descripcion"].ToString();
                    this.url_imagen = this.Lector["url_imagen"].ToString();
                    this.reports = Int32.Parse(this.Lector["reports"].ToString());
                    this.privacidad = bool.Parse(this.Lector["privacidad"].ToString());
                    this.Lector.Close();
                    return true;

                }
                this.Lector.Close();
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

        public bool FormaParteDelGrupo()
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM conforma WHERE id_grupo = @id_grupo AND id_cuenta = @id_cuenta";
                this.Comando.CommandText = sql;
                this.Comando.Parameters.Clear();
                this.Comando.Parameters.AddWithValue("@id_grupo", this.id_grupo);
                this.Comando.Parameters.AddWithValue("@id_cuenta", this.id_cuenta);

                string count = this.Comando.ExecuteScalar().ToString();

                return count == "1";
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
        public void AsignarGrupoOwner()
        {
            try
            {
                string sql = $"insert into conforma (id_grupo,id_cuenta,rol) values({this.id_grupo},{this.id_cuenta},'owner')";
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
        public void AgregarCuentaEnGrupo()
        {
            try
            {
                string sql = $"insert into conforma (id_cuenta,id_grupo,rol) values('{this.id_cuenta}','{this.id_grupo}','participante')";
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

        public void EliminarCuentaDeGrupo()
        {
            try
            {
                string sql = $"delete from conforma where id_cuenta = {this.id_cuenta} and id_grupo ={this.id_grupo};";
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

        public void CambiarRolDeCuentaEnGrupo()
        {
            try
            {
                string sql = $"update conforma set rol = '{this.rol}' where id_grupo = '{this.id_grupo}' and id_cuenta = '{this.id_cuenta}'";
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

        public void AñadirReporteGrupo()
        {
            try
            {
                string sql = $"update grupos set reports = reports +1 where id_grupo = {this.id_grupo}";
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
