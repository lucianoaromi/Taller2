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
    public partial class frmClientes : Form
    {
        public frmClientes()
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
            // Obtener los valores de los TextBox y ComboBox
            string documento = textBoxDocumento.Text;
            string nombre = textBoxNombre.Text;
            string correo = textBoxCorreo.Text;
            string estado = comboBoxEstado.SelectedItem != null ? comboBoxEstado.SelectedItem.ToString() : "Sin estado";

            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrWhiteSpace(documento) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(estado))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin agregar datos al DataGridView
            }

            // Verificar si el número de documento tiene exactamente 8 dígitos
            if (documento.Length != 8 || !documento.All(char.IsDigit))
            {
                MessageBox.Show("El número de documento debe contener exactamente 8 dígitos.", "Número de Documento Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin agregar datos al DataGridView
            }

            // Agregar los valores al DataGridView
            dataGridView1.Rows.Add(documento, nombre, correo, estado);

            // Limpiar los TextBox después de guardar
            textBoxDocumento.Clear();
            textBoxNombre.Clear();
            textBoxCorreo.Clear();

            // Restablecer el ComboBox
            comboBoxEstado.SelectedIndex = -1;
        }



    }
}
