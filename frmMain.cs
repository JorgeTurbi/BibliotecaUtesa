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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void nuevoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibro frmLibro = new frmLibro();
            frmLibro.Show();
        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiante frmEstudiante = new frmEstudiante();  
            frmEstudiante.Show();   
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstudiante frmConsult = new frmConsultaEstudiante();
            frmConsult.Show();
        }
    }
}
