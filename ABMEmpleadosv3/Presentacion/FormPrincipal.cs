using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMEmpleadosv3.Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var desicion = MessageBox.Show("¿Seguro que deseas salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desicion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void empleado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados formEmpleados = new Empleados();

            formEmpleados.FormClosed += (s, args) => this.Show();

            formEmpleados.Show();

            this.Hide();
        }

        private void facundoNicolasGuzmánOlariagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFNGO formFNGO = new FrmFNGO();

            formFNGO.FormClosed += (s, args) => this.Show();

            formFNGO.Show();

            this.Hide();
        }
    }
}
