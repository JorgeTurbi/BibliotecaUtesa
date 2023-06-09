﻿using Biblioteca.Librery;
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
    public partial class frmConsultaEstudiante : Form
    {
        public frmConsultaEstudiante()
        {
            InitializeComponent();
            cargarConsulta();
        }

        private void frmConsultaEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Estudiante' table. You can move, or remove it, as needed.
       

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmEstudiante registrar = new frmEstudiante();
            registrar.Show();
            this.Close();   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = null;
            try
            {
                string tabla = "Estudiante";
                EliminarRegistros eliminarRegistros = new EliminarRegistros();
                DataGridViewRow row = dgvEstudiante.CurrentRow;
                if (row.Cells[0].Value != null || Convert.ToInt16(row.Cells[0].Value) > -1 || row != null)
                {
                    int codigo = (int)row.Cells[0].Value;
                    eliminarRegistros.Eliminar(codigo, tabla);
                    cargarConsulta();
                    dgvEstudiante.Refresh();
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


        private void cargarConsulta()
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("consultaEstudiante", EliminarRegistros.cadena);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvEstudiante.DataSource = tabla;
        }
    }
}
