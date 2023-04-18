using Biblioteca.Librery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Biblioteca
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtnombre.Text) ||
                string.IsNullOrEmpty(txtapellido.Text) || string.IsNullOrEmpty(txtdireccion.Text) ||
                string.IsNullOrEmpty(txttelefono.Text) || string.IsNullOrEmpty(txtemail.Text) ||
                string.IsNullOrEmpty(txtcargo.Text) )
            {

                MessageBox.Show("NO PUEDE DEJAR CAMPOS VACIOS","ERROR CAMPOS");
            }
            else
            {
               var registro = new  Modelo.ModelEmpleado {
                   
                   Cedula=txtcedula.Text,
                   Nombres=txtnombre.Text,  
                   Apellidos=txtapellido.Text,  
                   Dirección=txtdireccion.Text, 
                   Teléfono=txttelefono.Text,   
                   Email=txtcargo.Text, 
                   cargo    =txtcargo.Text,
                };

                Empleado empleado = new Empleado();
              var res =  empleado.NuevoEmpleado(registro);

                if (res)
                {
                    MessageBox.Show("Empleado registrado exitosamente");
                    limpiarcontroles();
                }
                else
                {
                    MessageBox.Show("Error al Registrar Empleado");
                    limpiarcontroles();
                }

            }


            

        }
        private void limpiarcontroles()
        {
            txtcedula.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtdireccion.Clear();
             txttelefono.Clear();
            txtcargo.Clear();
            txtcargo.Clear();
            }
    }
}
