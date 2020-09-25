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
        //Coneccion con = new Coneccion();
        //public List<Temporadas> BuscarTemporadas()
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter sqlDA;
        //        cmd.Connection = con.conexion;
        //        cmd.CommandText = "select * from TEMPORADAS";
        //        cmd.CommandType = CommandType.Text;
        //        sqlDA = new SqlDataAdapter(cmd);
        //        sqlDA.Fill(ds);
        //        var myData = ds.Tables[0].AsEnumerable().Select(r => new Temporadas
        //        {
        //            id = r.Field<int>("id"),
        //            fecha_final = Convert.ToDateTime(r.Field<DateTime>("fecha_final")),
        //            fecha_inicial = Convert.ToDateTime(r.Field<DateTime>("fecha_inicial")),

        //        }

        //        );
        //        var list = myData.ToList(); // For if you really need a List and not IEnumerable
        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return null;
        //    }


        //}

        //public List<Proyecto> MostarLista()
        //{

        //    SqlCommand cmd = new SqlCommand();
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter sqlDA;
        //    cmd.Connection = con.conexion;
        //    cmd.CommandText = "select * from PROYECTOS";
        //    cmd.CommandType = CommandType.Text;
        //    sqlDA = new SqlDataAdapter(cmd);
        //    sqlDA.Fill(ds);
        //    var myData = ds.Tables[0].AsEnumerable().Select(r => new Proyecto
        //    {
        //        id = Convert.ToInt32(r.Field<int>("id")),
        //        idUsuarioAutoriso = Convert.ToInt32(r.Field<int>("idUsuario")),
        //        fecha_incial = Convert.ToDateTime(r.Field<DateTime>("fecha_inicial")),
        //        fecha_final = Convert.ToDateTime(r.Field<DateTime>("fecha_final"))
        //    });
        //    var list = myData.ToList(); // For if you really need a List and not IEnumerable
        //    return list;
        //}

        //internal List<SemanasTemporada> BuscarSemanasTempo()
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter sqlDA;
        //    cmd.Connection = con.conexion;
        //    cmd.CommandText = "select * from SEMANAS_TEMPORADA";
        //    cmd.CommandType = CommandType.Text;
        //    sqlDA = new SqlDataAdapter(cmd);
        //    sqlDA.Fill(ds);
        //    var myData = ds.Tables[0].AsEnumerable().Select(r => new SemanasTemporada
        //    {
        //        id = Convert.ToInt32(r.Field<int>("id")),
        //        fecha_inicial = Convert.ToDateTime(r.Field<DateTime>("fecha_inicial")),
        //        fecha_final = Convert.ToDateTime(r.Field<DateTime>("fecha_final")),
        //    });
        //    var list = myData.ToList(); // For if you really need a List and not IEnumerable
        //    return list;
        //}

        //public Temporadas BuscarIdTemporadaPorfechas(DateTime fechaIni, DateTime fechaFin)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter sqlDA;
        //        cmd.Connection = con.conexion;
        //        cmd.CommandText = "select * from TEMPORADAS where fecha_inicial = " + fechaIni + "and fecha_final =" + fechaFin + "";
        //        cmd.CommandType = CommandType.Text;
        //        sqlDA = new SqlDataAdapter(cmd);
        //        sqlDA.Fill(ds);
        //        var myData = ds.Tables[0].AsEnumerable().Select(r => new Temporadas
        //        {
        //            id = r.Field<int>("id")
        //        }

        //        );
        //        return myData.FirstOrDefault(); // For if you really need a List and not IEnumerable
        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return null;
        //    }


        //}
        //public bool Insertar(Proyecto proy)
        //{
        //    try
        //    {
        //        con.abrirConeccion();
        //        string cadena = "Insert into PROYECTOS(id,fecha_inicial,fecha_final,idUsuario) values (" + proy.id + "," + proy.fecha_incial.ToShortDateString() + "," + proy.fecha_final.ToShortDateString() + "," + proy.idUsuarioAutoriso + ")";
        //        SqlCommand comando = new SqlCommand(cadena, con.conexion);
        //        comando.ExecuteNonQuery();
        //        con.conexion.Close();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return false;
        //    }
        //}
        //public bool InsertarDetalle(Detalle_proyecto detalle_Proyecto)
        //{
        //    try
        //    {
        //        con.abrirConeccion();
        //        string cadena = "Insert into DETALLE_PROYECTOS(id,idProyecto,idTemporada) values (" + detalle_Proyecto.id + "," + detalle_Proyecto.idProyecto + "," + detalle_Proyecto.idTemporada + ")";
        //        SqlCommand comando = new SqlCommand(cadena, con.conexion);
        //        comando.ExecuteNonQuery();
        //        con.conexion.Close();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return false;
        //    }
        //}
        //public int AsignarIdDetalle()
        //{
        //    Coneccion con = new Coneccion();
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter sqlDA;
        //        cmd.Connection = con.conexion;
        //        cmd.CommandText = "select * from DETALLE_PROYECTOS";
        //        cmd.CommandType = CommandType.Text;
        //        sqlDA = new SqlDataAdapter(cmd);
        //        sqlDA.Fill(ds);
        //        var myData = ds.Tables[0].AsEnumerable().Select(r => new Detalle_proyecto
        //        {
        //            id = r.Field<int>("id")

        //        }

        //        );
        //        var list = myData.ToList(); // For if you really need a List and not IEnumerable
        //        bool res = false;
        //        int cont = 0;
        //        do
        //        {

        //            if (list.Count != 0)
        //            {
        //                foreach (var item in list)
        //                {
        //                    if (item.id != cont)
        //                    {
        //                        res = false;
        //                    }
        //                    else
        //                    {
        //                        res = true;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                res = true;
        //            }
        //            cont++;
        //        } while (res != true);
        //        return cont;

        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return 0;
        //    }


        //}
        //public int AsignarId()
        //{
        //    Coneccion con = new Coneccion();
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter sqlDA;
        //        cmd.Connection = con.conexion;
        //        cmd.CommandText = "select * from PROYECTOS";
        //        cmd.CommandType = CommandType.Text;
        //        sqlDA = new SqlDataAdapter(cmd);
        //        sqlDA.Fill(ds);
        //        var myData = ds.Tables[0].AsEnumerable().Select(r => new Detalle_proyecto
        //        {
        //            id = r.Field<int>("id")

        //        }

        //        );
        //        var list = myData.ToList(); // For if you really need a List and not IEnumerable
        //        bool res = false;
        //        int cont = 0;
        //        do
        //        {

        //            if (list.Count != 0)
        //            {
        //                foreach (var item in list)
        //                {
        //                    if (item.id != cont)
        //                    {
        //                        res = false;
        //                    }
        //                    else
        //                    {
        //                        res = true;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                res = true;
        //            }
        //            cont++;
        //        } while (res != true);
        //        return cont;
        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return 0;
        //    }


        //}
        //public Detalle_proyecto BuscarDetallePorIdPoryecto(int id) 
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter sqlDA;
        //        cmd.Connection = con.conexion;
        //        cmd.CommandText = "select * from DETALLE_PROYECTOS where idProyecto = "+id+"";
        //        cmd.CommandType = CommandType.Text;
        //        sqlDA = new SqlDataAdapter(cmd);
        //        sqlDA.Fill(ds);
        //        var myData = ds.Tables[0].AsEnumerable().Select(r => new Detalle_proyecto
        //        {
        //            id = r.Field<int>("id")

        //        }

        //        );
        //        var list = myData.ToList().FirstOrDefault(); // For if you really need a List and not IEnumerable
        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return null;
        //    }
        //}

        //public List<Concepcion> BuscarConcepciones()
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter sqlDA;
        //        cmd.Connection = con.conexion;
        //        cmd.CommandText = "select * from CONCEPCION";
        //        cmd.CommandType = CommandType.Text;
        //        sqlDA = new SqlDataAdapter(cmd);
        //        sqlDA.Fill(ds);
        //        var myData = ds.Tables[0].AsEnumerable().Select(r => new Concepcion
        //        {
        //            id = r.Field<int>("id"),
        //            nombres = r.Field<string>("Nombre")

        //        }

        //        );
        //        var list = myData.ToList(); // For if you really need a List and not IEnumerable
        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        var a = e.Message;
        //        return null;
        //    }


        //}
    }
}
