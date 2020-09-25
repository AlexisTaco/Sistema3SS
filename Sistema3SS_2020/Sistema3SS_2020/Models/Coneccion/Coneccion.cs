using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Coneccion
    {
        public SqlConnection conexion = new SqlConnection("Server=.;Database=Sistema3SSPruebas;Trusted_Connection=True;");
        public virtual void abrirConeccion() 
        {
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public virtual void CerrarConeccion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
