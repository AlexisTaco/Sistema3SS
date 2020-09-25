using Sistema3SS_2020.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Repositorio
{
    public class Insumos_repositorio
    {
    //    Coneccion con = new Coneccion();
    //    public Insumos ConsultarPorId(int id) 
    //    {
    //        try
    //        {
    //            con.abrirConeccion();
    //            SqlDataReader myReader = null;
    //            var state = con.conexion.State;
    //            string cadena = "select * from INSUMOS where id =" + id.ToString();
    //            SqlCommand comando = new SqlCommand(cadena, con.conexion);
    //            myReader = comando.ExecuteReader();
    //            Insumos ins = new Insumos();
    //            if (myReader.Read())
    //            {
    //                ins.id = Convert.ToInt32( myReader["id"].ToString().Trim());
    //                ins.id_tipo = Convert.ToInt32(myReader["id_tipo"].ToString().Trim());
    //                ins.nombre = myReader["nombre"].ToString().Trim();
    //                ins.unidad_medida = myReader["unidad_medida"].ToString().Trim();
    //                ins.cantidad = Convert.ToDouble( myReader["cantidad"].ToString().Trim());
    //                con.CerrarConeccion();
    //                return ins;
    //            }
    //            else
    //            {
    //                return null;
    //            }

    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }

    //    }
    //    public bool Insertar(Insumos ins)
    //    {
    //        try
    //        {

    //            con.abrirConeccion();
    //            string cadena = "insert into INSUMOS(id,id_tipo,nombre,unidad_medida,cantidad) values (" + ins.id + "," + ins.id_tipo + ",'" + ins.nombre + "','" + ins.unidad_medida+ "'," + ins.cantidad + ")";
    //            SqlCommand comando = new SqlCommand(cadena, con.conexion);
    //            comando.ExecuteNonQuery();
    //            con.conexion.Close();
    //            return true;
    //        }
    //        catch (Exception e)
    //        {
    //            var a = e.Message.Trim();
    //            return false;
    //        }

    //    }
    //    public bool Actualizar(Insumos ins, int id)
    //    {
    //        try
    //        {
    //            con.abrirConeccion();
    //            string cadena = "update INSUMOS set id_tipo = " + ins.id_tipo + ", nombre = '" + ins.nombre + "', unidad_medida =' " + ins.unidad_medida + "', cantidad = " + ins.cantidad + " where id =" + id;
    //            SqlCommand comando = new SqlCommand(cadena, con.conexion);
    //            comando.ExecuteNonQuery();
    //            return true;
    //        }
    //        catch (Exception e)
    //        {
    //            var a = e.Message.Trim();
    //            return false;
    //        }
    //    }

    //    public List<Insumos> MostarLista()
    //    {

    //        SqlCommand cmd = new SqlCommand();
    //        DataSet ds = new DataSet();
    //        SqlDataAdapter sqlDA;
    //        cmd.Connection = con.conexion;
    //        cmd.CommandText = "select * from INSUMOS";
    //        cmd.CommandType = CommandType.Text;
    //        sqlDA = new SqlDataAdapter(cmd);
    //        sqlDA.Fill(ds);
    //        var myData = ds.Tables[0].AsEnumerable().Select(r => new Insumos
    //        {
    //            nombre = r.Field<string>("nombre"),
    //            unidad_medida = r.Field<string>("unidad_medida"),
    //            cantidad = Convert.ToDouble(r.Field<double>("cantidad")),
    //            id_tipo = Convert.ToInt32( r.Field<int>("id_tipo")),
    //            id = r.Field<int>("id"),
    //        });
    //        var list = myData.ToList(); // For if you really need a List and not IEnumerable
    //        return list;
    //    }
    }
}
