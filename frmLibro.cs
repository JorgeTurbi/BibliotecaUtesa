using Biblioteca.Librery;
using System;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtcodigo.Text) || string.IsNullOrEmpty(txtautor.Text) ||
         string.IsNullOrEmpty(txttitulo.Text) || string.IsNullOrEmpty(txtdescipcion.Text) ||
         string.IsNullOrEmpty(txtedicion.Text))
            {

                MessageBox.Show("NO PUEDE DEJAR CAMPOS VACIOS", "ERROR CAMPOS");
            }
            else
            {
                var registro = new Modelo.ModeloLibro
                {

                    Codigo = txtcodigo.Text,
                    Autor = txtautor.Text,
                    Titulo = txttitulo.Text,
                    Descripcion = txtdescipcion.Text,
                    Edicion = txtedicion.Text,

                };

                Libro book = new Libro();
                var res = book.NuevoLibro(registro);

                if (res)
                {
                    MessageBox.Show("Libro registrado exitosamente");
                    limpiarcontroles();
                }
                else
                {
                    MessageBox.Show("Error al Registrar");
                    limpiarcontroles();
                }

            }


        }
        public void limpiarcontroles()
        {
            txtcodigo.Clear();
            txtautor.Clear();
            txttitulo.Clear();
            txtdescipcion.Clear();
            txtedicion.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           frmConsultaLibros frmConsultaLibros = new frmConsultaLibros();
            frmConsultaLibros.Show();
            this.Close();
        }
    }
}
