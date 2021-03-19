using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistroExpedientes
{
    public partial class ActualizarContraseña : Form
    {
        private SqlConnection conect;
        private SqlCommand insert1;
        private static string usuario;
        private string sCn;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public ActualizarContraseña()
        {
            InitializeComponent();
            conexion conectar = new conexion();
            sCn = conectar.cadena;
            conect = new SqlConnection(sCn);
        }

        private void RecuperarBT_Click(object sender, EventArgs e)
        {
            if (ContraseñaNueva.Text == "" || ConfimarContraseña.Text == "")
            {
                MessageBox.Show("Debe llenar los campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conect.Open();
                if (ContraseñaNueva.Text == ConfimarContraseña.Text)
                {
                    string insertar = "UPDATE usuarios SET contra = @contra WHERE usuario = @usuario";
                    insert1 = new SqlCommand(insertar, conect);
                    insert1.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar));
                    insert1.Parameters["@usuario"].Value = Usuario;
                    insert1.Parameters.Add(new SqlParameter("@contra", SqlDbType.VarChar));
                    insert1.Parameters["@contra"].Value = ContraseñaNueva.Text;
                    insert1.ExecuteNonQuery();
                    MessageBox.Show("Contraseña actualizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    login LG = new login();
                    //this.Visible = false;
                    this.Close();
                    LG.Visible = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conect.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActualizarContraseña_Load(object sender, EventArgs e)
        {
            ContraseñaNueva.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Visible = false;
            //login log = new login();
            //log.Visible = true;
        }
    }
}
