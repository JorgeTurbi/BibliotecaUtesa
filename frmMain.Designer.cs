namespace Biblioteca
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casaDeCambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEmpleadoToolStripMenuItem,
            this.nuevoLibroToolStripMenuItem,
            this.nuevoEstudianteToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // crearEmpleadoToolStripMenuItem
            // 
            this.crearEmpleadoToolStripMenuItem.Name = "crearEmpleadoToolStripMenuItem";
            this.crearEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.crearEmpleadoToolStripMenuItem.Text = "Nuevo Empleado";
            this.crearEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.crearEmpleadoToolStripMenuItem_Click);
            // 
            // nuevoLibroToolStripMenuItem
            // 
            this.nuevoLibroToolStripMenuItem.Name = "nuevoLibroToolStripMenuItem";
            this.nuevoLibroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nuevoLibroToolStripMenuItem.Text = "Nuevo Libro";
            this.nuevoLibroToolStripMenuItem.Click += new System.EventHandler(this.nuevoLibroToolStripMenuItem_Click);
            // 
            // nuevoEstudianteToolStripMenuItem
            // 
            this.nuevoEstudianteToolStripMenuItem.Name = "nuevoEstudianteToolStripMenuItem";
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nuevoEstudianteToolStripMenuItem.Text = "Nuevo Estudiante";
            this.nuevoEstudianteToolStripMenuItem.Click += new System.EventHandler(this.nuevoEstudianteToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.libroToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.estudianteToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libroToolStripMenuItem.Text = "Libro";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumadoraToolStripMenuItem,
            this.casaDeCambioToolStripMenuItem,
            this.nominaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // sumadoraToolStripMenuItem
            // 
            this.sumadoraToolStripMenuItem.Name = "sumadoraToolStripMenuItem";
            this.sumadoraToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sumadoraToolStripMenuItem.Text = "Sumadora";
            // 
            // casaDeCambioToolStripMenuItem
            // 
            this.casaDeCambioToolStripMenuItem.Name = "casaDeCambioToolStripMenuItem";
            this.casaDeCambioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.casaDeCambioToolStripMenuItem.Text = "Casa de Cambio";
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nominaToolStripMenuItem.Text = "Nomina";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 477);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casaDeCambioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

