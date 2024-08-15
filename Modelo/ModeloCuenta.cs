using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloCuenta : Modelo
    {
        public int id_cuenta;
        public string nombre_usuario;
        public string email;
        public string contraseña = "123"; //placeholder
        public string imagen_perfil = "pic"; //placeholder
        public int id_muro = 1; //placeholder
        public int id_preferencia = 1; //placeholder


        public void CrearCuenta()
        {
            CrearMuro();
            string sql = $"insert into cuenta (nombre_usuario,email,contrasena,imagen_perfil)" +
                $" values('{this.nombre_usuario}','{this.email}','{this.contraseña}','{this.imagen_perfil}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
            PrintDesktop(sql);
            
        }

        public void ModificarContraseña()
        {
            string sql = $"update cuenta set contrasena ='{this.contraseña}'where id_cuenta ='{this.id_cuenta}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void ModificarCorreo()
        {
            string sql = $"update cuetna set email ='{this.email}'where id_cuenta ='{this.id_cuenta}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void EliminarCuenta()
        {
            string sql = $"update cuenta set eliminado = true where id_cuenta ='{this.id_cuenta}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void ObtenerIdUsuario(string NombreUsuario)
        {
            string sql = $"select id_cuenta from cuenta where nombre_usuario = '{NombreUsuario}' and eliminado = false";
            this.Comando.CommandText = sql;
            string userId = this.Comando.ExecuteReader().ToString();
            id_muro = Int32.Parse(userId);
        }

        public List<ModeloCuenta> ObtenerCuentas()
        {
            List<ModeloCuenta> cuentas = new List<ModeloCuenta>();

            string sql = $"select * from cuenta where eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                ModeloCuenta cuenta = new ModeloCuenta();
                cuenta.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                cuenta.nombre_usuario = this.Lector["nombre_usuario"].ToString();
                cuenta.email = this.Lector["email"].ToString();
                cuentas.Add(cuenta);
            }
            this.Lector.Close();
            return cuentas;
        }

        /************************************* Muro ********************************/

        public string detalles = "";
        public int pub_destacada = 0;
        public string biografia = "";

        public void CrearMuro()
        {
            string sql = $"insert into muro (detalles,pub_destacada,biografia) values ('{this.detalles}',{this.pub_destacada},'{this.biografia}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
            PrintDesktop(sql);
        }

        public int SetMuroId(string username)
        {
            string sql = $"update cuenta set id_muro = last_insert_id() where nombre_usuario = '{username}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
            return 1;
        }
        UPDATE sequence SET id = LAST_INSERT_ID

        public void ModificarMuro()
        {
            ModificarDetalles();
            ModificarBiografia();
        }
        public void ModificarDetalles()
        {
            string sql = $"update muro set detalles ='{this.detalles}' where id_muro ='{this.id_muro}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void ModificarBiografia()
        {
            string sql = $"update muro set biografia ='{this.biografia}' where id_muro ='{this.id_muro}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void ModificarPublicacionDestacada()
        {
            string sql = $"update muro set pub_destacada ='{this.pub_destacada}' where id_muro ='{this.id_muro}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

    }
}
