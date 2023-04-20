using Biblioteca.Librery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmConsultaLibros : Form
    {
        public frmConsultaLibros()
        {
            InitializeComponent();
            cargarConsulta();
        }

        private void frmConsultaLibros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet1.libro' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLibro frmLibro = new frmLibro();
            frmLibro.Show();
        }

        private void cargarConsulta()
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("consultaLibro", EliminarRegistros.cadena);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = null;
            try
            {
                string tabla = "Libro";
                EliminarRegistros eliminarRegistros = new EliminarRegistros();
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells[0].Value != null || Convert.ToInt16(row.Cells[0].Value) > -1 || row != null)
                {
                    int codigo = (int)row.Cells[0].Value;
                    eliminarRegistros.Eliminar(codigo, tabla);
                    cargarConsulta();
                    dataGridView1.Refresh();
                    MessageBox.Show("Registro Eliminado Exitosamente", "Información");
                }
                else
                {
                    MessageBox.Show("no existe registro seleccionado", "Error");

                }
            }
            catch (Exception ex)
            {

                mensaje = ex.Message.ToString();
            }
            if (mensaje != null)
            {

                MessageBox.Show(mensaje);
            }
        }
    }
}
