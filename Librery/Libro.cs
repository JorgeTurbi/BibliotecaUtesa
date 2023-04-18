using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Librery
{
    public  class Libro
    {


        public bool NuevoLibro(ModeloLibro libro)
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["DbBiblioteca"];
            bool respuesta = false;
            try
            {
                SqlConnection conexionSql = new SqlConnection(cadenaConexion.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("Sp_RegistrarLibro");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Codigo", libro.Codigo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", libro.Descripcion);
                cmd.Parameters.AddWithValue("@Edicion", libro.Edicion);
         
                

                conexionSql.Open();

                var dr = cmd.ExecuteNonQuery();

                conexionSql.Close();

                respuesta = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return respuesta;

        }
    }
}
