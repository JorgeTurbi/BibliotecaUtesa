using Biblioteca.Librery;
using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmEditarEmpleado : Form
    {
        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {

        }

        public void cargarRegistro(int Id)
        {
            Editar editar = new Editar();  
            frmConsultaEmpleados frmConsultaEmpleados = new frmConsultaEmpleados();
            if (Id>0)
            {

                ModelEmpleado empleado = editar.BuscarEmpleado(Id,"Empleado");

                if (empleado != null)
                {

                    txtCodigo.Text = (string)empleado.Id.ToString();
                    txtcedula.Text = (string)empleado.Cedula.ToString();
                    txtnombre.Text = (string)empleado.Nombres.ToString();
                    txtapellido.Text = (string)empleado.Apellidos.ToString();
                    txttelefono.Text = (string)empleado.Teléfono.ToString();
                    txtemail.Text = (string)empleado.Email.ToString();
                    txtcargo.Text = (string)empleado.cargo.ToString();

                }
                
            }
            else
            {
                frmConsultaEmpleados.Show();
                this.Close();
            }
        }
    }
}
