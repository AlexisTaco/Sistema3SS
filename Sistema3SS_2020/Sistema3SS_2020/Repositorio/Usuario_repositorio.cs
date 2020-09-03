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
                string cadena = "select * from USUARIOS where id ="+id.ToString();
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                myReader = comando.ExecuteReader();
                Usuario usu = new Usuario();
                if (myReader.Read())
                {
                    usu.nombre = myReader["nombre"].ToString().Trim();
                    usu.contrasena = myReader["contrasena"].ToString().Trim();
                    usu.id_tipo = Convert.ToInt32(myReader["id_tipo"].ToString().Trim());
                    usu.correo_electronico = myReader["correo_electronico"].ToString().Trim();
                    usu.apellido_materno = myReader["apellido_materno"].ToString().Trim();
                    usu.apellido_paterno = myReader["apellido_paterno"].ToString().Trim();
                    usu.direccion = myReader["direccion"].ToString().Trim();
                    usu.numero_celular = myReader["numero_celular"].ToString().Trim();
                    usu.fecha_nacimiento = Convert.ToDateTime(myReader["fecha_necimineto"].ToString().Trim());
                    usu.id_tipo = Convert.ToInt32(myReader["id"]);
                    usu.activo = Convert.ToBoolean(myReader["activo"]);
                    con.CerrarConeccion();
                    return usu;
                }
                else
                {
                    return null;
                }

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
                string cadena = "select * from USUARIOS where nombre = '" + nombre.ToString()+"'";
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                myReader = comando.ExecuteReader();
                Usuario usu = new Usuario();
                if (myReader.Read())
                {
                    usu.nombre = myReader["nombre"].ToString().Trim();
                    usu.contrasena = myReader["contrasena"].ToString().Trim();
                    usu.id_tipo = Convert.ToInt32(myReader["id_tipo"].ToString().Trim());
                    usu.correo_electronico = myReader["correo_electronico"].ToString().Trim();
                    usu.apellido_materno = myReader["apellido_materno"].ToString().Trim();
                    usu.apellido_paterno = myReader["apellido_paterno"].ToString().Trim();
                    usu.direccion = myReader["direccion"].ToString().Trim();
                    usu.numero_celular = myReader["numero_celular"].ToString().Trim();
                    usu.fecha_nacimiento = Convert.ToDateTime(myReader["fecha_necimineto"].ToString().Trim());
                    usu.id_tipo = Convert.ToInt32(myReader["id"]);
                    usu.activo = Convert.ToBoolean(myReader["activo"]);
                    con.CerrarConeccion();
                    return usu;
                }
                else
                {
                    return null;
                }

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
                var fechaModify = usu.fecha_nacimiento.ToString("yyyy-MM-dd");
                int act;
                if (usu.activo == true)
                {
                    act = 1;
                }
                else
                {
                    act = 0;
                }
                string cadena = "insert into USUARIOS(nombre,apellido_paterno,apellido_materno,id_tipo,correo_electronico,numero_celular,direccion,fecha_necimineto,activo,contrasena,id) values ('" + usu.nombre + "','" + usu.apellido_paterno + "','" + usu.apellido_materno + "'," + usu.id_tipo + ",'" + usu.correo_electronico + "','" + usu.numero_celular + "','" + usu.direccion + "'," + fechaModify + "," + act + ",'" + usu.contrasena + "',"+usu.id+")";
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                comando.ExecuteNonQuery();
                con.conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                var a = e.Message.Trim();
                return false;
            }

        }
        public bool Actualizar(Usuario usu, int id) 
        {
            try
            {
                int act;
                con.abrirConeccion();
                var fechaModify = usu.fecha_nacimiento.ToString("yyyy-MM-dd");
                if (usu.activo == true)
                {
                    act = 1;
                }
                else
                {
                    act = 0;
                }
                string cadena = "update USUARIOS set nombre = '" + usu.nombre + "', apellido_paterno = '" + usu.apellido_paterno + "', apellido_materno = '" + usu.apellido_materno + "', id_tipo =" + usu.id_tipo + ", correo_electronico = '" + usu.correo_electronico + "', numero_celular = '" + usu.numero_celular + "', direccion = '" + usu.direccion + "', fecha_necimineto = " + fechaModify + ", activo = " + act + ", contrasena = '" + usu.contrasena + "' where id =" + id;
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                var a = e.Message.Trim();
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
