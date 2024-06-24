﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPost : Modelo
    {
        public int id;
        public string Contenido;
        public int Reacciones;

        public void Guardar()
        {
            string sql = $"insert into Posts (Contenido,Reacciones) values('{this.Contenido}',{this.Reacciones})";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void Eliminar()
        {
            string sql = $"update Posts set Eliminado = true where id ='{this.id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public List<ModeloPost> ObtenerPosts()
        {
            List<ModeloPost> posts = new List<ModeloPost>();

            string sql = $"select * from Posts where Eliminado ) false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                ModeloPost post = new ModeloPost();
                post.id = Int32.Parse(this.Lector["id"].ToString());
                post.Contenido = this.Lector["Contenido"].ToString();
                post.Reacciones = Int32.Parse(this.Lector[Reacciones].ToString());
            }
            return posts;
        }
    }

}