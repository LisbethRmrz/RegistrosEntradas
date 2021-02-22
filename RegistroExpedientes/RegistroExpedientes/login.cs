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
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace RegistroExpedientes
{
    public partial class login : Form
    {
        private SqlConnection conect;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;

        public login()
        {
            InitializeComponent();
            conexion conectar = new conexion();
            sCn = conectar.cadena;
            conect = new SqlConnection(sCn);
        }

        public void log(string usuario, string contraseña)
        {
            conect.Open();

            int es = 0;
            string consulta = "SELECT COUNT(*) AS total FROM usuarios WHERE usuario='" + usuario + "' AND contra='" + contraseña + "'";
            da = new SqlDataAdapter(consulta, conect);
            dr = da.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                es = (int)dr["total"];
            }
            dr.Close();
            if (es != 0)
            {
                string consulta1 = "SELECT usuario,cargo FROM usuarios WHERE usuario='" + usuario + "' AND contra='" + contraseña + "'";
                da = new SqlDataAdapter(consulta1, conect);
                dr = da.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                    string rol = dr["cargo"].ToString().Trim();
                    string nombre = dr["cargo"].ToString().Trim();
                    MessageBox.Show("Bienvenid@: " + nombre + "", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (rol == "Administrador")
                    {
                        Form1 MP = new Form1();
                        MP.Visible = true;
                        this.Visible = false;
                    }
                    else
                    {
                        Auxiliar MS = new Auxiliar();
                        MS.Visible = true;
                        this.Visible = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontraseña.Clear();
            }
            dr.Close();
            conect.Close();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnacceder_Click(object sender, EventArgs e)
        {
            log(this.txtusuario.Text, this.txtcontraseña.Text);
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {

            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Black;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.Black;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            RecuperarContraseña RC = new RecuperarContraseña();
            RC.Visible = true;
        }
    }
}
