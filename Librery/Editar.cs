using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Biblioteca.Librery
{
    public  class Editar
    {

        public ModelEmpleado BuscarEmpleado(int Id, string Tabla)
        {
            ModelEmpleado modelEmpleado = new ModelEmpleado();


            try
            {
                SqlConnection conexionSql = new SqlConnection(EliminarRegistros.cadena);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("buscar");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Tabla", Tabla);




                conexionSql.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    modelEmpleado.Id = (int)dr[0];
                    modelEmpleado.Cedula = dr[1].ToString();
                    modelEmpleado.Nombres = dr[2].ToString();
                    modelEmpleado.Apellidos = dr[3].ToString();
                    modelEmpleado.Dirección = dr[4].ToString();
                    modelEmpleado.Teléfono = dr[5].ToString();
                    modelEmpleado.Email = dr[6].ToString();
                    modelEmpleado.cargo = dr[7].ToString();



                }
                conexionSql.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return modelEmpleado;
        }


        public ModeloEstudiante BuscarEstudiante(int Id, string Tabla)
        {
            ModeloEstudiante modelEstudi = new ModeloEstudiante();


            try
            {
                SqlConnection conexionSql = new SqlConnection(EliminarRegistros.cadena);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("buscar");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Tabla", Tabla);




                conexionSql.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    modelEstudi.Id = (int)dr["Id"];
                    modelEstudi.Matricula = dr["Matricula"].ToString();
                    modelEstudi.Carrera = dr["Carrera"].ToString();
                    modelEstudi.Nombres = dr["Nombres"].ToString();
                    modelEstudi.Apellidos = dr["Apellidos"].ToString();
                    modelEstudi.Telefono = dr["Telefono"].ToString();
                    modelEstudi.Email_Estudiante = dr["t"].ToString();
                



                }
                conexionSql.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return modelEstudi;
        }

        public ModeloLibro BuscarLibro(int Id, string Tabla)
        {
            ModeloLibro  modelolibro = new ModeloLibro();


            try
            {
                SqlConnection conexionSql = new SqlConnection(EliminarRegistros.cadena);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("buscar");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Tabla", Tabla);




                conexionSql.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    modelolibro.Id = (int)dr["Id"];
                    modelolibro.Codigo = dr["Codigo"].ToString();
                    modelolibro.Autor = dr["Autor"].ToString();
                    modelolibro.Titulo = dr["Titulo"].ToString();
                    modelolibro.Descripcion = dr["Descripcion"].ToString();
                    modelolibro.Edicion = dr["Edicion"].ToString();
                



                }
                conexionSql.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return modelolibro;
        }


        public bool ActualizarEmpleado(ModelEmpleado modelo)
        {
            bool respuesta = false;
            try
            {
                SqlConnection conexionSql = new SqlConnection(EliminarRegistros.cadena);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ("Sp_EditarEmpleado");
                cmd.Connection = conexionSql;

                cmd.Parameters.AddWithValue("@Id", modelo.Id);
                cmd.Parameters.AddWithValue("@Cedula", modelo.Cedula);
                cmd.Parameters.AddWithValue("@Nombres", modelo.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", modelo.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", modelo.Teléfono);
                cmd.Parameters.AddWithValue("@Email", modelo.Email);
                cmd.Parameters.AddWithValue("@cargo", modelo.cargo);


                conexionSql.Open();

                var dr = cmd.ExecuteNonQuery();

                conexionSql.Close();

                respuesta = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                respuesta=false;
            }

            return respuesta;

        }
        


    }
}
