using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        //Almacena el menu activo
        private static IconMenuItem MenuActivo = null;
        //Indica el formulario activo en el panel
        private static Form FormularioActivo = null;
      
        
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }
        



        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            //Recorre todos los menus de la lista
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
                //menuventas.Image = Properties.Resources.ardu;
                //menuventas.ImageScalingSize = new Size(40, 40);

            }

            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        //Recibe el menu seleccionado y el formulario a mostrar
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            //Pone en color blanco el boton anteriormente seleccionado
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.MediumTurquoise;
            }
            //Cambia de color el boton de menu seleccionado
            menu.BackColor = Color.DarkCyan;
            MenuActivo = menu;

            //Cierra el formulario no activo que se abrio previamente
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            //TopLevel = false no permite que el tamaño del formulario sea superior al externo
            formulario.TopLevel = false;
            //FormBorderStyle.None quita el estilo de bordes de la venta
            formulario.FormBorderStyle = FormBorderStyle.None;
            //DockStyle.Fill copa todo el espacio del contenedor disponible
            formulario.Dock = DockStyle.Fill;
            //Muestra del color "Negro" como fondo del formulario
            formulario.BackColor = Color.DarkCyan;

            //Agrega el formulario seleccionado en el "contenedor", recibido como parametro
            contenedor.Controls.Add(formulario);
            //Muestar el formulario
            formulario.Show();

        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            //Envia el menu seleccionado y el formulario a mostrar como parametros. "Es necesario castearlo previamente"
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
            //menuusuarios.Image = Properties.Resources.verde;

        }


        private void submenucategoria_Click(object sender, EventArgs e)
        {
            //Envia el menu seleccionado y el formulario a mostrar como parametros
            AbrirFormulario(menumantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            //Envia el menu seleccionado y el formulario a mostrar como parametros
            AbrirFormulario(menumantenedor, new frmProducto());
        }


        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas());
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
        }


        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

    }
}
