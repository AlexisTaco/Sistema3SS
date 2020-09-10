using Sistema3SS_2020.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Repositorio
{
    public class Proyectos_repositorio
    {
        Coneccion con = new Coneccion();
        Proyecto proyecto = new Proyecto();
        public List<Temporadas> BuscarTemporadas() 
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from TEMPORADAS";
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Temporadas
                {
                    id = r.Field<int>("id"),
                    fecha_final = Convert.ToDateTime(r.Field<DateTime>("fecha_final")),
                    fecha_inicial = Convert.ToDateTime(r.Field<DateTime>("fecha_inicial")),

                }

                );
                var list = myData.ToList(); // For if you really need a List and not IEnumerable
                return list;
            }
            catch (Exception e)
            {
                var a = e.Message;
                return null;
            }


        }
        public bool Insertar(Proyecto proy)
        {
            try
            {
                con.abrirConeccion();
                string cadena = "Insert into PROYECTOS(id,fecha_inicial,fecha_final,idUsuario) values (" + proy.id + ",'" + proy.fecha_incial + "','" + proy.fecha_final + "','" + proy.idUsuarioAutoriso + "')";
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                comando.ExecuteNonQuery();
                con.conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                var a = e.Message;
                return false;
            }
        }
    }
}
