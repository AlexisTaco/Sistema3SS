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

        internal Concepcion BuscarTiposConcepcionPorId(int concepcionId)
        {
            throw new NotImplementedException();
        }

        internal bool RegistrarDetallePresupuesto(Presupuesto presupuesto)
        {
            try
            {
                con.abrirConeccion();
                string cadena = "Insert into DETALLE_PRESUPUESTOS(id,idConcepcion,idPresupuesto,idGranja,idProyecto,idGasto) values (" + presupuesto.id + "," + presupuesto.detalle.concepcion.id + "," + presupuesto.id + "," + presupuesto.detalle.granja.id + "," + presupuesto.idProyecto+ "," + presupuesto.detalle.gastos.id + ")";
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

        internal List<Detalle_presupuesto> BuscarDetallaPorIdProyecto(int idProyecto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDA;
                cmd.Connection = con.conexion;
                cmd.CommandText = "select * from DETALLE_PRESUPUESTOS wehre idProyecto = " + idProyecto;
                cmd.CommandType = CommandType.Text;
                sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                var myData = ds.Tables[0].AsEnumerable().Select(r => new Detalle_presupuesto
                {
                    id = r.Field<int>("id"),
                    idPresupuesto = r.Field<int>("idPresupuesto"),
                    idConcepcion = r.Field<int>("Concepcion"),
                    idGranja = r.Field<int>("idGranja"),
                    idProyecto = r.Field<int>("idProyecto"),
                    idGasto = r.Field<int>("idGasto")

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
                string cadena = "Insert into PRESUPUESTOS(id,idTipo) values (" +presupuesto.id + "," + presupuesto.IdTipo + ")";
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
    }
}
