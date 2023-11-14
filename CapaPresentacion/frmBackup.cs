using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmBackup : Form
    {
        SqlConnection con=new SqlConnection("server= .\\sqlexpress; database = ARDUINO_BD; integrated security = true");

        public frmBackup()
        {
            InitializeComponent();
        }

        private void limpiarDatos()
        {
            txt_backup.Clear();
            txt_backup.Text = " Seleccione un destino...";
            txt_restore.Clear();
            txt_restore.Text = " Seleccione el archivo .bak";
            txt_nombre_backup.Clear();
            btn_backup.Enabled = false;
            btn_restore.Enabled = false;
        }


        private void btn_examinar_backup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_backup.Text = dlg.SelectedPath;
                txt_nombre_backup.Enabled = true;
                btn_backup.Enabled = true;
                //pictureBox4.Enabled = true;
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if (txt_backup.Text == string.Empty)
            {
                MessageBox.Show("Please enter backup file location");
            }
            else
            {
                string cmd = "BACKUP DATABASE ["+ database + "] TO DISK= '"+ txt_backup.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Database backup done successfuly");
                con.Close();
                btn_backup.Enabled = false;
            }
        }

        private void btn_examinar_restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_restore.Text = dlg.FileName;
                btn_restore.Enabled = true;
                //pictureBox3.Enabled = true;
            }
        }


        private void btn_restore_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();
            try
            {
                string str1 = string.Format("ALTER DATABASE ["+ database +"] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txt_restore.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "]  SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Database restore done successfuly");
                con.Close();
            }
            catch
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            MessageBox.Show("Campos limpios.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
