using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Biblioteca.Librery
{
    public  class Login
    {
  
        public bool IniciarSession(string usuario, string clave)
        {
            var cadenaConexion =  ConfigurationManager.ConnectionStrings["DbBiblioteca"];
            bool respuesta =false;
            try
            {
                SqlConnection conexionSql = new SqlConnection(cadenaConexion.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("ObtenerUsuarios");
                cmd.Connection = conexionSql;                  

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                conexionSql.Open();

                 SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    respuesta = true;
                }

                dr.Close();
                conexionSql.Close();    


            }
            catch (Exception ex)
            {

               Console.WriteLine(ex.Message);   
            }


            return respuesta;   

        }



    }
}
