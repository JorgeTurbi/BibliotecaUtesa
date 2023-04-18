using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modelo;

namespace Biblioteca.Librery
{
    public  class Empleado
    {


        public bool NuevoEmpleado(ModelEmpleado empleado)
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["DbBiblioteca"];
            bool respuesta = false;
            try
            {
                SqlConnection conexionSql = new SqlConnection(cadenaConexion.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("Sp_NuevoEmpleado");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@Nombres", empleado.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@Dirección", empleado.Dirección);
                cmd.Parameters.AddWithValue("@Telefono", empleado.Teléfono);
                cmd.Parameters.AddWithValue("@Email", empleado.Email);
                cmd.Parameters.AddWithValue("@cargo", empleado.cargo);

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
