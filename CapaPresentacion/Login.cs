using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            List<Usuario> TEST = new CN_Usuario().Listar();

            //Devuelve solo una clase de la lista de clases, los cuales tienen documento y clave iguales a los que se encuentran en los texbox
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {

                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();
                //Permite cerrar el formulario, unir la funcion de llamar al formulario de Login
                form.FormClosing += frm_closing;

            }
            else
            {
                MessageBox.Show("No se encontro el usario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
