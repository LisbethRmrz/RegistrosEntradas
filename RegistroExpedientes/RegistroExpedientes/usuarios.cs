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
    public partial class usuarios : Form
    {
        conexion conectar = new conexion();
        private SqlConnection conect;
        private SqlCommand insert1;
        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            conectar.CargarUsuarios(DatosUsuarios);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string InsertarUsuarios;
                InsertarUsuarios = "INSERT INTO usuarios(usuario,nombres,apellidos,correo,cargo,contra)";
                InsertarUsuarios += "VALUES(@usuario,@nombres,@apellidos,@correo,@cargo,@contra)";
                insert1 = new SqlCommand(InsertarUsuarios, conectar.con);

                insert1.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar));
                insert1.Parameters["@usuario"].Value = txtuser.Text;
                insert1.Parameters.Add(new SqlParameter("@nombres", SqlDbType.VarChar));
                insert1.Parameters["@nombres"].Value = txtnombre.Text;
                insert1.Parameters.Add(new SqlParameter("@apellidos", SqlDbType.VarChar));
                insert1.Parameters["@apellidos"].Value = txtapellido.Text;
                insert1.Parameters.Add(new SqlParameter("@correo", SqlDbType.VarChar));
                insert1.Parameters["@correo"].Value = txtcorreo.Text;
                insert1.Parameters.Add(new SqlParameter("@cargo", SqlDbType.VarChar));
                insert1.Parameters["@cargo"].Value = txtcargo.Text;
                insert1.Parameters.Add(new SqlParameter("@contra", SqlDbType.VarChar));
                insert1.Parameters["@contra"].Value = txtcontraseña.Text;
                insert1.ExecuteNonQuery();

                //Limpiamos los textbox

                txtid.Text = "";
                txtuser.Text = "";
                txtnombre.Text = "";
                txtapellido.Text = "";
                txtcorreo.Text = "";
                txtcargo.Text = "";
                txtcorreo.Text = "";

                MessageBox.Show("Usuario agregado");
                conectar.CargarUsuarios(DatosUsuarios);
                conectar.Cerrar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error, verifique la información o si el usuaio no está repetido" + ex.Message);
            }
            conectar.Cerrar();
        }
        
    }
}
