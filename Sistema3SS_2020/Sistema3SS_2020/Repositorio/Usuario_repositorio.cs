using Sistema3SS_2020.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Repositorio
{
    public class Usuario_repositorio
    {
        Coneccion con = new Coneccion();
        public Usuario ConsultarPorId(int id) 
        {
            try
            {
                con.abrirConeccion();
                SqlDataReader myReader = null;
                var state = con.conexion.State;
                string cadena = "select * from USUARIOS where nombre ="+id;
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                myReader = comando.ExecuteReader();
                Usuario usu = new Usuario();
                myReader.Read();
                usu.nombre = myReader["nombre"].ToString();
                usu.contrasena = myReader["contrasena"].ToString();
                usu.id_tipo = Convert.ToInt32(myReader["id"]);
                con.CerrarConeccion();
                return usu;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Usuario ConsultarPorNombre(string nombre)
        {
            try
            {
                con.abrirConeccion();
                SqlDataReader myReader = null;
                var state = con.conexion.State;
                string cadena = "select * from USUARIOS where nombre ='"+nombre+"'";
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                myReader = comando.ExecuteReader();
                Usuario usu = new Usuario();
                myReader.Read();
                usu.nombre = myReader["nombre"].ToString();
                usu.contrasena = myReader["contrasena"].ToString();
                usu.id_tipo = Convert.ToInt32(myReader["id"]);
                con.CerrarConeccion();
                return usu;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool Insertar(Usuario usu) 
        {
            try
            {
                con.abrirConeccion();
                string cadena = "insert into articulos(nombre,apellido_paterno,apellido_materno,id_tipo,correo_electronico,numero_celular,direccion,fecha_nacimiento,activo,contrasena) values ('" + usu.nombre + "','" + usu.apellido_paterno + "','" + usu.apellido_materno + "'," + usu.id_tipo + ",'" + usu.correo_electronico + "','" + usu.numero_celular + "','" + usu.direccion + "','" + usu.fecha_nacimiento + "'," + usu.activo + ",'" + usu.contrasena + "')";
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                comando.ExecuteNonQuery();
                con.conexion.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool Actualizar(Usuario usu, int id) 
        {
            try
            {
                con.abrirConeccion();
                string cadena = "update USUARIOS set nombre ='" + usu.nombre + "', apellido_paterno ='" + usu.apellido_paterno + "', apellido_materno ='" + usu.apellido_materno + "', id_tipo =" + usu.id_tipo + ", correo_electronico ='" + usu.correo_electronico + "',', numero_telefono = '" + usu.numero_celular + "', direccion = '" + usu.direccion + "', fecha_nacimiento'" + usu.fecha_nacimiento + "', activo = " + usu.activo + ",'" + usu.contrasena + "' where codigo=" + id;
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Desactivar(int id) 
        {
            try
            {
                con.abrirConeccion();
                string cadena = "update USUARIOS set activo = 0 where id ="+id;
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Activar(int id)
        {
            try
            {
                con.abrirConeccion();
                string cadena = "update USUARIOS set activo = 1 where id =" + id;
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Usuario> MostarLista() 
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDA;
            cmd.Connection = con.conexion;
            cmd.CommandText = "select * from USUARIOS";
            cmd.CommandType = CommandType.Text;
            sqlDA = new SqlDataAdapter(cmd);
            sqlDA.Fill(ds);
            var myData = ds.Tables[0].AsEnumerable().Select(r => new Usuario
            {
                nombre = r.Field<string>("nombre"),
                apellido_paterno = r.Field<string>("apellido_paterno"),
                apellido_materno = r.Field<string>("apellido_materno"),
                contrasena = r.Field<string>("contrasena"),
                correo_electronico = r.Field<string>("correo_electronico"),
                numero_celular = r.Field<string>("numero_celular"),
                activo = r.Field<bool>("activo"),
                direccion = r.Field<string>("direccion"),
                fecha_nacimiento = r.Field<DateTime>("fecha_necimineto"),
                id = r.Field<int>("id"),
                id_tipo = r.Field<int>("id_tipo")
            });
            var list = myData.ToList(); // For if you really need a List and not IEnumerable
            return list;
        }
    }
}
