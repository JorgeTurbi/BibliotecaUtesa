using Biblioteca.Librery;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (string.IsNullOrEmpty(txtusuario.Text) && string.IsNullOrEmpty(txtclave.Text))
            {
                 MessageBox.Show("Introduzca un usuario y contraseña validos","usuario invalido");
                limpiarControlesLogin();


            }
            else if( !login.IniciarSession(txtusuario.Text,txtclave.Text))
            {
                MessageBox.Show("Credenciales invalidas");
                limpiarControlesLogin();
            }
            else
            {
                limpiarControlesLogin();
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();

            }
           

        }

        private void  limpiarControlesLogin()
        {
            txtusuario.Clear();
            txtclave.Clear();
        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login login = new Login();

                if (string.IsNullOrEmpty(txtusuario.Text.ToLower()) && string.IsNullOrEmpty(txtclave.Text))
                {
                    MessageBox.Show("Introduzca un usuario y contraseña validos", "usuario invalido");
                    limpiarControlesLogin();


                }
                else if (!login.IniciarSession(txtusuario.Text, txtclave.Text))
                {
                    MessageBox.Show("Credenciales invalidas");
                    limpiarControlesLogin();
                }
                else
                {
                    limpiarControlesLogin();
                    frmMain frmMain = new frmMain();
                    this.Hide();
                    frmMain.Show();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
