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
    public partial class registros : Form
    {

        conexion conectar = new conexion();
        private SqlConnection conect;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataTable dt;
        private string sCn;
        public registros()
        {
            InitializeComponent();

        }

        private void registros_Load(object sender, EventArgs e)
        {
            conectar.CargarRegistros(DatosRegistros);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            if (txtexpediente.Text == "" || dateentrada.Text == "" || txtnombres.Text == "" || txtapellidos.Text == "" || txtinfracciones.Text == "" || txtofendidos.Text == "")
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                try
                {
                    DateTime enteri = Convert.ToDateTime(dateentrada.Value.Date.ToString("dd-MM-yyyy"));
                    DateTime audi = Convert.ToDateTime(dateaudiencia.Value.Date.ToString("dd-MM-yyyy"));
                    string InsertarRegistros;
                    InsertarRegistros = "INSERT INTO datos(exp_año, fechain, nombre, apellido, infracciones, ofendidos, audienciainicial, observaciones)";
                    InsertarRegistros += "VALUES (@exp_año, @fechain, @nombre, @apellido, @infracciones, @ofendidos, @audienciainicial, @observaciones)";
                    insert1 = new SqlCommand(InsertarRegistros, conectar.con);

                    insert1.Parameters.Add(new SqlParameter("@exp_año", SqlDbType.VarChar));
                    insert1.Parameters["@exp_año"].Value = txtexpediente.Text;
                    insert1.Parameters.Add(new SqlParameter("@fechain", SqlDbType.Date));
                    insert1.Parameters["@fechain"].Value = enteri;
                    insert1.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                    insert1.Parameters["@nombre"].Value = txtnombres.Text;
                    insert1.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                    insert1.Parameters["@apellido"].Value = txtapellidos.Text;
                    insert1.Parameters.Add(new SqlParameter("@infracciones", SqlDbType.VarChar));
                    insert1.Parameters["@infracciones"].Value = txtinfracciones.Text;
                    insert1.Parameters.Add(new SqlParameter("@ofendidos", SqlDbType.VarChar));
                    insert1.Parameters["@ofendidos"].Value = txtofendidos.Text;
                    insert1.Parameters.Add(new SqlParameter("@audienciainicial", SqlDbType.Date));
                    insert1.Parameters["@audienciainicial"].Value = audi;
                    insert1.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.VarChar));
                    insert1.Parameters["@observaciones"].Value = txtobservaciones.Text;

                    insert1.ExecuteNonQuery();

                    //Limpiamos los textbox

                    codigo.Text = "";
                    txtexpediente.Text = "";
                    dateentrada.Text = "";
                    txtnombres.Text = "";
                    txtapellidos.Text = "";
                    txtinfracciones.Text = "";
                    txtofendidos.Text = "";
                    dateaudiencia.Text = "";
                    txtobservaciones.Text = "";

                    MessageBox.Show("Registro agregado");
                    conectar.CargarRegistros(DatosRegistros);             
                    conectar.Cerrar();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }               
            }
            conectar.Cerrar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            codigo.Text = "";
            txtexpediente.Text = "";
            dateentrada.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtinfracciones.Text = "";
            txtofendidos.Text = "";
            dateaudiencia.Text = "";
            txtobservaciones.Text = "";
        }

        private void DatosRegistros_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btnguardar_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnguardar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            try
            {
                //DateTime enter = Convert.ToDateTime(dateentrada.Value.Date.ToString("dd-MM-yyyy"));
                //DateTime aud = Convert.ToDateTime(dateaudiencia.Value.Date.ToString("dd-MM-yyyy"));
                var enter = dateentrada.Value.ToString("yyyy-MM-dd");
                var aud = dateaudiencia.Value.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand("UPDATE datos SET exp_año='" + txtexpediente.Text + "' ,fechain='" + enter + "', nombre='" + txtnombres.Text + "', apellido='" + txtapellidos.Text + "', infracciones='" + txtinfracciones.Text + "', ofendidos='" + txtofendidos.Text + "', audienciainicial='" + aud + "', observaciones='" + txtobservaciones.Text + "' " + "where id='" + codigo.Text + "'", conectar.con);
                int filas = cmd.ExecuteNonQuery();
                conectar.Cerrar();

                codigo.Text = "";
                txtexpediente.Text = "";
                dateentrada.Text = "";
                txtnombres.Text = "";
                txtapellidos.Text = "";
                txtinfracciones.Text = "";
                txtofendidos.Text = "";
                dateaudiencia.Text = "";
                txtobservaciones.Text = "";

                if (filas > 0)
                {
                    MessageBox.Show("Registro actualizado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conectar.CargarRegistros(DatosRegistros);
            conectar.Cerrar();
        }

        private void DatosRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatosRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DatosRegistros.Rows[e.RowIndex];
            codigo.Text = Convert.ToString(fila.Cells[0].Value);
            txtexpediente.Text = Convert.ToString(fila.Cells[1].Value);
            dateentrada.Text = Convert.ToString(fila.Cells[2].Value);
            txtnombres.Text = Convert.ToString(fila.Cells[3].Value);
            txtapellidos.Text = Convert.ToString(fila.Cells[4].Value);
            txtinfracciones.Text = Convert.ToString(fila.Cells[5].Value);
            txtofendidos.Text = Convert.ToString(fila.Cells[6].Value);
            dateaudiencia.Text = Convert.ToString(fila.Cells[7].Value);
            txtobservaciones.Text = Convert.ToString(fila.Cells[8].Value);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            try {
                SqlCommand cmd = new SqlCommand("DELETE FROM datos WHERE id='" + codigo.Text + "'", conectar.con);
                int filas = cmd.ExecuteNonQuery();
                conectar.CargarRegistros(DatosRegistros);
                conectar.Cerrar();

                codigo.Text = "";
                txtexpediente.Text = "";
                dateentrada.Text = "";
                txtnombres.Text = "";
                txtapellidos.Text = "";
                txtinfracciones.Text = "";
                txtofendidos.Text = "";
                dateaudiencia.Text = "";
                txtobservaciones.Text = "";

                if (filas > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex){
                MessageBox.Show("" + ex.Message);
            }
            conectar.Cerrar();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            conectar.Abrir();
            da = new SqlDataAdapter("select id as [No.], exp_año as [Registro], fechain as [Entrada], nombre as [Nombre], apellido as [Apellido], infracciones as [Infracciones], ofendidos as [Ofendidos], audienciainicial as [Audiencia Inicial], observaciones as [Observaciones] from datos where nombre LIKE'%" + txtbuscar.Text + "%'", conectar.con);
            dt = new DataTable();
            da.Fill(dt);
            DatosRegistros.DataSource = dt;
            //DatosRegistros.Columns[0].Visible = false;
            //DatosRegistros.Columns[2].DefaultCellStyle.Format = "0.00";
            conectar.Cerrar();
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Asegurese de ingresar únicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Asegurese de ingresar únicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtofendidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Asegurese de ingresar únicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
