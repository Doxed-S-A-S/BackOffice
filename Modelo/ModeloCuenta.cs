﻿using System;
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
        public int reports;
        public long id_usuario;
        public long id_muro;
        public long id_preferencia;


        public void CrearCuenta()
        {
            CrearUsuario();
            CrearMuro();
            CrearPreferencias();
            string sql = $"insert into cuenta (nombre_usuario,email,contrasena,imagen_perfil,id_usuario,id_muro,id_preferencia)" +
                $" values('{this.nombre_usuario}','{this.email}','{this.contraseña}','{this.imagen_perfil}',{this.id_usuario},{this.id_muro},{this.id_preferencia})";
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

        public bool ObtenerDatosUsuario(int id)
        {
            string sql = $"select * from cuenta where id_cuenta = {id} and eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            if (this.Lector.HasRows)
            {
                this.Lector.Read();
                this.id_cuenta = Int32.Parse(this.Lector["id_cuenta"].ToString());
                this.nombre_usuario = this.Lector["nombre_usuario"].ToString();
                //this.imagen_perfil = this.Lector["imagen_perfil"].ToString();
                this.reports = Int32.Parse(this.Lector["reports"].ToString());
                //this.id_usuario = Int32.Parse(this.Lector["id_usuario"].ToString());
                this.Lector.Close();

                /*sql = $"select * from usuario where nombre_usuario = '{this.id_usuario}'";
                this.Comando.CommandText = sql;
                this.Lector = this.Comando.ExecuteReader();

                this.Lector.Read();
                this.nombre = this.Lector["nombre"].ToString();
                this.apellido1 = this.Lector["apellido1"].ToString();
                this.apellido2 = this.Lector["apellido2"].ToString();
                this.Lector.Close();*/

                return true;

            }
            this.Lector.Close();
            return false;

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

        /************************************* Usuario ********************************/

        public string nombre;
        public string apellido1;
        public string apellido2;
        public string pais = "SU";
        public string idiomas_hablados = "spa";

        public void CrearUsuario()
        {
            string sql = $"insert into usuario (nombre,apellido1,apellido2,pais,idiomas_hablados) " +
                $"values ('{this.nombre}','{this.apellido1}','{this.apellido2}','{this.pais}','{this.idiomas_hablados}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
            PrintDesktop(sql);
            id_usuario = this.Comando.LastInsertedId;
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
            id_muro = this.Comando.LastInsertedId;
        }

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


        /************************************* Preferencias ********************************/

        string tema_de_apariencia = "claro"; // dejar elejir en el futuro

        public void CrearPreferencias()
        {
            string sql = $"insert into set_preferencias (tema_de_apariencia) value('{this.tema_de_apariencia}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
            PrintDesktop(sql);
            id_preferencia = this.Comando.LastInsertedId;
        }
        
    }
}
