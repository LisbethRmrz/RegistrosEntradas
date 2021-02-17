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
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataTable dt;
        private string sCn;
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
            conectar.Abrir();
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtuser.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcorreo.Text = "";
            txtcargo.Text = "";
            txtcorreo.Text = "";
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE usuarios SET usuario='" + txtuser.Text + "' ,nombres='" + txtnombre.Text + "', apellidos='" + txtapellido.Text + "', correo='" + txtcorreo.Text + "', cargo='" + txtcargo.Text + "', contra='" + txtcontraseña.Text + "' " + "where id='" + txtid.Text + "'", conectar.con);
                int filas = cmd.ExecuteNonQuery();
                conectar.Cerrar();

                txtid.Text = "";
                txtuser.Text = "";
                txtnombre.Text = "";
                txtapellido.Text = "";
                txtcorreo.Text = "";
                txtcargo.Text = "";
                txtcorreo.Text = "";

                if (filas > 0)
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conectar.CargarUsuarios(DatosUsuarios);
            conectar.Cerrar();
        }

        private void DatosUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DatosUsuarios.Rows[e.RowIndex];
            txtid.Text = Convert.ToString(fila.Cells[0].Value);
            txtuser.Text = Convert.ToString(fila.Cells[1].Value);
            txtnombre.Text = Convert.ToString(fila.Cells[2].Value);
            txtapellido.Text = Convert.ToString(fila.Cells[3].Value);
            txtcorreo.Text = Convert.ToString(fila.Cells[4].Value);
            txtcargo.Text = Convert.ToString(fila.Cells[5].Value);
            txtcontraseña.Text = Convert.ToString(fila.Cells[6].Value);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM usuarios WHERE id='" + txtid.Text + "'", conectar.con);
                int filas = cmd.ExecuteNonQuery();
                conectar.CargarUsuarios(DatosUsuarios);
                conectar.Cerrar();

                txtid.Text = "";
                txtuser.Text = "";
                txtnombre.Text = "";
                txtapellido.Text = "";
                txtcorreo.Text = "";
                txtcargo.Text = "";
                txtcorreo.Text = "";

                if (filas > 0)
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conectar.Cerrar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            conectar.Abrir();
            da = new SqlDataAdapter("select id as [No.], usuario as [Usuario], nombres as [Nombre], apellidos  as [Apellidos], correo as [Correo], cargo as [Cargo], contra as [Contraseña] from usuarios where nombres LIKE'%" + txtbuscar.Text + "%'", conectar.con);
            dt = new DataTable();
            da.Fill(dt);
            DatosUsuarios.DataSource = dt;
            conectar.Cerrar();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Asegurese de ingresar únicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Asegurese de ingresar únicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No está permitida la tecla espacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
