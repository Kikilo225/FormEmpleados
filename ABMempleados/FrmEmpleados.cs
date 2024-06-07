using System;
using System.Data;
using System.Windows.Forms;

namespace ABMempleados
{
    public partial class FrmEmpleados : Form
    {
        ConexionBD oBD;
        public FrmEmpleados()
        {
            InitializeComponent();
            oBD = new ConexionBD();
        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargaCombo(cbDocumento, "Tipos_doc");
        }
        private void CargaCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = oBD.ConsultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }


    }
}
