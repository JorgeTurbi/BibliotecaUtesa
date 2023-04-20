using System;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmatricula.Text) || string.IsNullOrEmpty(txtcarrera.Text) ||
        string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) ||
        string.IsNullOrEmpty(txttelefono.Text) || string.IsNullOrEmpty(txtcorreo.Text))
            {

                MessageBox.Show("NO PUEDE DEJAR CAMPOS VACIOS", "ERROR CAMPOS");
            }
            else
            {
                var registro = new Modelo.ModeloEstudiante
                {
                        Matricula=txtmatricula.Text,
                        Carrera=txtcarrera.Text,
                        Nombres=txtnombre.Text,
                        Apellidos   =txtapellido.Text,
                        Telefono=txttelefono.Text,
                        Email_Estudiante=txtcorreo.Text,


                };

                Librery.Estudiante estudiante = new Librery.Estudiante();
                var res = estudiante.NuevoEstudiante(registro);

                if (res)
                {
                    MessageBox.Show("Estudiante ha sido  registrado exitosamente");
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
            txtmatricula.Clear();
            txtcarrera.Clear();
            txtnombre.Clear(); 
            txtapellido.Clear();
            txttelefono.Clear(); 
            txtcorreo.Clear(); 
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaEstudiante frmConsult = new frmConsultaEstudiante();
            frmConsult.Show();
        }
    }
}
