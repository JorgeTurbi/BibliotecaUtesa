using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmConsultaEstudiante : Form
    {
        public frmConsultaEstudiante()
        {
            InitializeComponent();
        }

        private void frmConsultaEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.bibliotecaDataSet.Estudiante);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmEstudiante registrar = new frmEstudiante();
            registrar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
