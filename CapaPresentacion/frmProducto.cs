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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox y ComboBox
            string codigo = codigoTextBox.Text.Trim();
            string nombre = nombreTextBox.Text.Trim();
            string descripcion = descripcionTextBox.Text.Trim();
            string categoria = categoriaComboBox.SelectedItem != null ? categoriaComboBox.SelectedItem.ToString() : "Sin categoria";
            string estado = estadoComboBox.SelectedItem != null ? estadoComboBox.SelectedItem.ToString() : "Sin estado";

            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin guardar si hay campos vacíos
            }

            // Agregar los valores al DataGridView
            dataGridView1.Rows.Add(codigo, nombre, descripcion, categoria, estado);

            // Limpiar los TextBox después de guardar
            codigoTextBox.Clear();
            nombreTextBox.Clear();
            descripcionTextBox.Clear();

            // Restablecer los ComboBox
            categoriaComboBox.SelectedIndex = -1;
            estadoComboBox.SelectedIndex = -1;
        }



        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

    }
}
