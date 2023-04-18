using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class ConexionBD
    {

        public string stringconection;
        private SqlConnection conexion;

        public ConexionBD()
        {
            string cadenaConexion = @"Data Source=DEV-001\\MSSQLSERVER01;Initial Catalog=Biblioteca;Integrated Security=True";
            this.stringconection = cadenaConexion;
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
