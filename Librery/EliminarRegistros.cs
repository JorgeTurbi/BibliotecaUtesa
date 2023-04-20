using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca.Librery
{
    public class EliminarRegistros
    {
        public static string cadena = @"Data Source=DEV-001\MSSQLSERVER01;Initial Catalog=Biblioteca;Integrated Security=True";
     

        public bool Eliminar(int Id, string Tabla)
        {
           
            bool respuesta = false;
            try
            {
                SqlConnection conexionSql = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("Sp_EliminarRegistro");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Tabla", Tabla);




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

        //public List<ModelEmpleado> consultaEmpleado(string tabla)
        //    {
           
        //    bool respuesta = false;
        //    try
        //    {
        //        SqlConnection conexionSql = new SqlConnection(cadena);
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = ("Sp_Consulta");
        //        cmd.Connection = conexionSql;

        //        cmd.Parameters.AddWithValue("@Tabla", tabla);




        //        conexionSql.Open();

        //        var dr = cmd.ExecuteNonQuery();

        //        conexionSql.Close();

        //        respuesta = true;
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }


        //    return respuesta;


          

        //    }
    }
}
