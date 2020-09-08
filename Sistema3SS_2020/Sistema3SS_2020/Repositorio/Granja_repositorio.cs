﻿using Sistema3SS_2020.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Repositorio
{
    public class Granja_repositorio
    {
        Coneccion con = new Coneccion();
        public List<Granja> MostarLista()
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDA;
            cmd.Connection = con.conexion;
            cmd.CommandText = "select * from GRANJAS";
            cmd.CommandType = CommandType.Text;
            sqlDA = new SqlDataAdapter(cmd);
            sqlDA.Fill(ds);
            var myData = ds.Tables[0].AsEnumerable().Select(r => new Granja
            {
                id = r.Field<int>("id"),
                nombre = r.Field<string>("nombre"),
                nombre_responsable = r.Field<string>("nombre_responsable"),
                ubicacion = r.Field<string>("ubicacion"),
                apellido_materno_responsable = r.Field<string>("apellido_materno_responsable"),
                apellido_paterno_responsable = r.Field<string>("apellido_paterno_responsable"),
                numero_estanques = r.Field<int>("numero_estanques"),
                perimetro_hetareas = r.Field<double>("perimetro_hectareas"),
                nombre_completo_responsable = r.Field<string>("nombre_responsable") + r.Field<string>("apellido_paterno_responsable") + r.Field<string>("apellido_materno_responsable")
            }

            );
            var list = myData.ToList(); // For if you really need a List and not IEnumerable
            return list;
        }
        internal Granja ConsultarPorId(int id)
        {
            try
            {
                con.abrirConeccion();
                SqlDataReader myReader = null;
                var state = con.conexion.State;
                string cadena = "select * from GRANJAS where id =" + id.ToString();
                SqlCommand comando = new SqlCommand(cadena, con.conexion);
                myReader = comando.ExecuteReader();
                Granja gran = new Granja();
                if (myReader.Read())
                {
                    gran.id = Convert.ToInt32(myReader["id"].ToString().Trim());
                    gran.nombre = myReader["nombre"].ToString().Trim();
                    gran.ubicacion = myReader["ubicacion"].ToString().Trim();
                    gran.nombre_responsable = myReader["nombre_responsable"].ToString().Trim();
                    gran.apellido_paterno_responsable = myReader["apellido_paterno_responsable"].ToString().Trim();
                    gran.apellido_materno_responsable = myReader["apellido_materno_responsable"].ToString().Trim();
                    gran.numero_estanques = Convert.ToInt32( myReader["numero_estanques"].ToString().Trim());
                    gran.perimetro_hetareas = Convert.ToDouble(myReader["perimetro_hectareas"].ToString().Trim());
                    con.CerrarConeccion();
                    return gran;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                var a = e.Message;
                throw;
            }
        }

        public bool Insertar(Granja gran) 
        {
            try
            {
                con.abrirConeccion();
                string cadena = "Insert into GRANJAS(id,nombre,ubicacion,nombre_responsable,apellido_paterno_responsable,apellido_materno_responsable,numero_estanques,perimetro_hectareas) values (" + gran.id + ",'" + gran.nombre + "','" + gran.ubicacion + "','" + gran.nombre_responsable + "','" + gran.apellido_paterno_responsable + "','" + gran.apellido_materno_responsable + "'," + gran.numero_estanques + "," + gran.perimetro_hetareas +")";
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
        public bool Actualizar(Granja gran, int id)
        {
            try
            {

                con.abrirConeccion();
                string cadena = "update GRANJAS set nombre = '" + gran.nombre + "', ubicacion = '" + gran.ubicacion + "', nombre_responsable = '" + gran.nombre_responsable + "', apellido_paterno_responsable ='" + gran.apellido_paterno_responsable + "', apellido_materno_responsable = '" + gran.apellido_materno_responsable + "', numero_estanques = " + gran.numero_estanques + ", perimetro_hectareas = " + gran.perimetro_hetareas + " where id =" + id;
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
    }
}
