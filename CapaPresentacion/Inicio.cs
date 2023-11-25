﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Llamo a las Capas relacionadas
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        //Se crea una variable de tipo Usuario, global para todos los metodos de esta clase
        private static Usuario usuarioActual;
        //Almacena el menu activo
        private static IconMenuItem MenuActivo = null;
        //Indica el formulario activo en el panel
        private static Form FormularioActivo = null;
      
        //Constructor que recibe como parametro un objeto de tipo Usuario 
        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { Apellido = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                //Se almacena el usuario que se logueo actualmente
                usuarioActual = objusuario;

            InitializeComponent();
        }
        


        private void Inicio_Load(object sender, EventArgs e)
        {
            //Esta línea de código crea una lista de objetos de tipo Permiso llamada ListaPermisos
            //al llamar al método Listar de la clase CN_Permiso. La variable usuarioActual.
            //IdUsuario se utiliza como argumento para el método Listar. de la clase CN_Permiso
            //ListaPermisos contendrá la lista de permisos asociados al usuario actual
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            //Recorre todo el menu icono por icono y lo almacena en "iconmenu"
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                //Compara de la ListaPermiso los "nombres" que se encuentren relacionados
                //devuelve true en caso de que asi sea
                //"Any" determina si una secuencia contiene elementos
                //"m" es cada uno de los elementos que contiene la lista
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                //si no se encuentra coincidencia no se muestar el icono de menu
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
                //menuventas.Image = Properties.Resources.ardu;
                //menuventas.ImageScalingSize = new Size(40, 40);

            }

            //Muestra el nombre de usuario que se encuentra "logueado"
            lblusuario.Text = $"{usuarioActual.Apellido}, {usuarioActual.Nombre}";
            lblusuarioinicio.Text = $"{usuarioActual.Apellido}, {usuarioActual.Nombre}";

            //lblusuarioinicio.Text = usuarioActual.Apellido;
            txtidusuario.Text = Convert.ToString( usuarioActual.IdUsuario);
            timerReloj.Interval = 1000;
            timerReloj.Start();

        }


        //Metodo para mostrar la hora
        private void timerReloj_Tick_1(object sender, EventArgs e)
        {
            lblreloj.Text = DateTime.Now.ToString("hh:mm tt");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        //Recibe el menu seleccionado y el formulario a mostrar
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            //Pone en color "" el boton anteriormente seleccionado
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.MediumTurquoise;
            }
            //Cambia de color el boton de menu seleccionado
            menu.BackColor = Color.DarkCyan;
            
            //Almacena el menu recibido como parametro en MenuActivo
            MenuActivo = menu;

            //Cierra el formulario no activo que se abrio previamente
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                panelvista.Visible = false;
               
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

            //Agrega el formulario seleccionado en el "contenedor" recibido como parametro
            contenedor.Controls.Add(formulario);
            
            //Permite que el formulario sea visible
            formulario.Show();

        }

        
        private void menuusuarios_Click(object sender, EventArgs e)
        {
            //Envia el menu seleccionado y el formulario a mostrar como parametros. "Es necesario castearlo previamente"
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
            panelclousing();

        }


        private void submenucategoria_Click(object sender, EventArgs e)
        {
            //Envia el menu seleccionado y el formulario a mostrar como parametros
            AbrirFormulario(menumantenedor, new frmCategoria());
            panelclousing();
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            //Envia el menu seleccionado y el formulario a mostrar como parametros
            AbrirFormulario(menumantenedor, new frmProducto());
            panelclousing();
        }


        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
            panelclousing();
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
            panelclousing();
        }


        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
            panelclousing();
        }



        private void menuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
            panelclousing();
        }


        private void menubackup_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmBackup());
            panelclousing();
        }

        private void menudetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmReportes(usuarioActual));
            panelclousing();
        }


        private void menuestadisticas_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmGraficos());
            panelclousing();
        }

        private void submenucategoria_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmCategoria());
            panelclousing();
        }

        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmReportes(usuarioActual));
            panelclousing();
        }

        private void panelclousing()
        {
            panelvista.Visible = false;
        }

    }
}
