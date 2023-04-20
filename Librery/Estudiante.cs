using Biblioteca.Modelo;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Librery
{
    public  class Estudiante
    {

        public bool NuevoEstudiante(ModeloEstudiante estudiante)
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["DbBiblioteca"];
            bool respuesta = false;
            try
            {
                SqlConnection conexionSql = new SqlConnection(cadenaConexion.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("Sp_RegistrarEstudiante");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Matricula", estudiante.Matricula);
                cmd.Parameters.AddWithValue("@Carrera", estudiante.Carrera);
                cmd.Parameters.AddWithValue("@Nombres", estudiante.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", estudiante.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                cmd.Parameters.AddWithValue("@Email_Estudiante", estudiante.Email_Estudiante);

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
