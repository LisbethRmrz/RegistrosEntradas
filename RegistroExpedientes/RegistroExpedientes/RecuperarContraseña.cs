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
    public partial class RecuperarContraseña : Form
    {
        private SqlConnection conect;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;
        public RecuperarContraseña()
        {
            InitializeComponent();
            conexion conectar = new conexion();
            sCn = conectar.cadena;
            conect = new SqlConnection(sCn);
        }

        private void RecuperarBT_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {
            UsuarioText.Focus();
            VerificacionLabel.Visible = false;
            correotext.Enabled = false;
            RecuperarBT.Enabled = false;
        }

        private void UsuarioText_KeyUp(object sender, KeyEventArgs e)
        {
            conect.Open();
            string consulta = "SELECT COUNT(*) AS Total FROM usuarios WHERE usuario = '" + UsuarioText.Text + "'";
            da = new SqlDataAdapter(consulta, conect);
            dr = da.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                if (UsuarioText.Text == "")
                {
                    VerificacionLabel.Visible = false;
                }
                else if (Convert.ToInt32(dr["Total"].ToString().Trim()) == 0)
                {
                    VerificacionLabel.Visible = true;
                    VerificacionLabel.Text = "Usuario no existente.";
                    correotext.Enabled = false;
                    UsuarioText.Focus();
                }
                else
                {
                    VerificacionLabel.Visible = true;
                    VerificacionLabel.Text = "Usuario encontrado exitosamente.";
                    correotext.Enabled = true;
                    correotext.Focus();
                }
            }
            dr.Close();
            conect.Close();
        }

        private void correotext_KeyUp(object sender, KeyEventArgs e)
        {
            conect.Open();
            string consulta = "SELECT COUNT(*) AS Total FROM usuarios WHERE usuario = '" + UsuarioText.Text + "' AND correo='" + correotext.Text + "'";
            da = new SqlDataAdapter(consulta, conect);
            dr = da.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["Total"].ToString().Trim()) == 0)
                {
                    RecuperarBT.Enabled = false;
                }
                else
                {
                    RecuperarBT.Enabled = true;
                }
            }
            dr.Close();
            conect.Close();
        }
    }
}
