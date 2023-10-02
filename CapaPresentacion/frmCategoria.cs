using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }


            private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el valor del TextBox y ComboBox
            string descripcion = textBoxDescripcion.Text.Trim();
            string estado = comboBoxEstado.SelectedItem != null ? comboBoxEstado.SelectedItem.ToString() : "Sin estado";

            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin guardar si hay campos vacíos
            }

            // Agregar los valores al DataGridView
            dataGridView1.Rows.Add(descripcion, estado);

            // Limpiar el TextBox después de guardar
            textBoxDescripcion.Clear();
        }


    }
}
