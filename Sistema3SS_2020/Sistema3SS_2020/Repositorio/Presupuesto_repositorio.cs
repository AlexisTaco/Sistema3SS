using Sistema3SS_2020.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Repositorio
{
    public class Presupuesto_repositorio
    {
        Coneccion con = new Coneccion();
        public List<Tipo_presupuesto> BuscarTiposPresupuesto()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from TIPOS_PRESUPUESTOS";
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Tipo_presupuesto
                {
                    id = r.Field<int>("id"),
                    Nombre = r.Field<string>("Nombre")

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

        internal bool RegistrarDetallePresupuesto(Presupuesto presupuesto)
        {
            try
            {
                con.abrirConeccion();
                string cadena = "Insert into DETALLE_PRESUPUESTO(id,idConcepcion,idPresupuesto,idGranja) values (" + presupuesto.id + "," + presupuesto.detalle.concepcion.id + "," + presupuesto.id + "," + presupuesto.detalle.granja.id + ")";
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

        public List<Concepcion> BuscarTiposConcepcion()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from CONCEPCION";
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Concepcion
                {
                    id = r.Field<int>("id"),
                    nombres = r.Field<string>("Nombre")

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
        public List<Gastos> BuscarTiposGastos()
        {
           
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from GASTOS";
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Gastos
                {
                    id = r.Field<int>("id"),
                    Nombre = r.Field<string>("Nombre")

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
        public List<Concepto_gastos> BuscarTiposConceptos_gasto()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from CONCEPTOS_GASTOS";
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Concepto_gastos
                {
                    id = r.Field<int>("id"),
                     ConceptoDes = r.Field<string>("Contenido")

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
        public bool RegistrarPresupuesto(Presupuesto presupuesto )
        {

            try
            {
                con.abrirConeccion();
                string cadena = "Insert into PRESUPUESTOS(id,idTipo,idGasto) values (" +presupuesto.id + "," + presupuesto.IdTipo + "," + presupuesto.detalle.gastos.id + ")";
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
        public int AsignarIdDalle()
        {
            Coneccion con = new Coneccion();
            try
            {

                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from DETALLE_PRESUPUESTO";
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Presupuesto
                {
                    id = r.Field<int>("id")

                }

                );
                var list = myData.ToList(); // For if you really need a List and not IEnumerable
                bool res = false;
                int cont = 0;
                do
                {

                    if (list.Count != 0)
                    {
                        foreach (var item in list)
                        {
                            if (item.id != cont)
                            {
                                res = false;
                            }
                            else
                            {
                                res = true;
                            }
                        }
                    }
                    else
                    {
                        res = true;
                    }
                    cont++;
                } while (res != true);
                return cont;
            }
            catch (Exception e)
            {
                var a = e.Message;
                return 0;
            }


        }
        public int AsignarId()
        {
            Coneccion con = new Coneccion();
            try
            {

                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from PRESUPUESTOS";
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Presupuesto
                {
                    id = r.Field<int>("id")

                }

                );
                var list = myData.ToList(); // For if you really need a List and not IEnumerable
                bool res = false;
                int cont = 0;
                do
                {

                    if (list.Count != 0)
                    {
                        foreach (var item in list)
                        {
                            if (item.id != cont)
                            {
                                res = false;
                            }
                            else
                            {
                                res = true;
                            }
                        }
                    }
                    else
                    {
                        res = true;
                    }
                    cont++;
                } while (res != true);
                return cont;
            }
            catch (Exception e)
            {
                var a = e.Message;
                return 0;
            }


        }
        public bool RegistraEnProyecto(int idProyecto, int IdPresupuesto) 
        {
            try
            {
                con.abrirConeccion();
                string cadena = "update DETALLE_PROYECTOS set idPresupuesto = "+IdPresupuesto+" where id =" + idProyecto;
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
