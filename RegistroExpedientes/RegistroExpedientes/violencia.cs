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
    public partial class violencia : Form
    {
        conexion conectar = new conexion();
        private SqlConnection conect;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataTable dt;
        private string sCn;
        public violencia()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            if (txtexpediente.Text == "" || txtvictima.Text == "" || txtvictimario.Text == "" || dateentrada.Text == "")
            {
                MessageBox.Show("Los campos que contengan (*) deben estar llenos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DateTime enteri = Convert.ToDateTime(dateentrada.Value.Date.ToString("dd-MM-yyyy"));
                    string InsertarRegistros;
                    InsertarRegistros = "insert into violencia (fechain, n_exp, nombre_victima, nombre_victimario, audiencia, fecha_audiencia, resolucion, observaciones, folio)";
                    InsertarRegistros += "values (@fechain, @n_exp, @nombre_victima, @nombre_victimario, @audiencia, @fecha_audiencia, @resolucion, @observaciones, @folio)";
                    insert1 = new SqlCommand(InsertarRegistros, conectar.con);

                    insert1.Parameters.Add(new SqlParameter("@fechain", SqlDbType.Date));
                    insert1.Parameters["@fechain"].Value = enteri;
                    insert1.Parameters.Add(new SqlParameter("@n_exp", SqlDbType.VarChar));
                    insert1.Parameters["@n_exp"].Value = txtexpediente.Text;
                    insert1.Parameters.Add(new SqlParameter("@nombre_victima", SqlDbType.VarChar));
                    insert1.Parameters["@nombre_victima"].Value = txtvictima.Text;
                    insert1.Parameters.Add(new SqlParameter("@nombre_victimario", SqlDbType.VarChar));
                    insert1.Parameters["@nombre_victimario"].Value = txtvictimario.Text;
                    insert1.Parameters.Add(new SqlParameter("@audiencia", SqlDbType.VarChar));
                    insert1.Parameters["@audiencia"].Value = txtaudiencia.Text;
                    insert1.Parameters.Add(new SqlParameter("@fecha_audiencia", SqlDbType.VarChar));
                    insert1.Parameters["@fecha_audiencia"].Value = txtfecha_audiencia.Text;
                    insert1.Parameters.Add(new SqlParameter("@resolucion", SqlDbType.VarChar));
                    insert1.Parameters["@resolucion"].Value = txtresolucion.Text;
                    insert1.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.VarChar));
                    insert1.Parameters["@observaciones"].Value = txtobservaciones.Text;
                    insert1.Parameters.Add(new SqlParameter("@folio", SqlDbType.VarChar));
                    insert1.Parameters["@folio"].Value = txtfolio.Text;
                    insert1.ExecuteNonQuery();

                    //Limpiamos los textbox

                    dateentrada.Text = "";
                    txtexpediente.Text = "";
                    txtvictima.Text = "";
                    txtvictimario.Text = "";
                    txtaudiencia.Text = "";
                    txtfecha_audiencia.Text = "";
                    txtresolucion.Text = "";
                    txtobservaciones.Text = "";
                    txtfolio.Text = "";

                    MessageBox.Show("Registro agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conectar.CargarRegistrosViolencia(DatosViolencia);
                    conectar.Cerrar();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            conectar.Cerrar();
        }

        private void violencia_Load(object sender, EventArgs e)
        {
            conectar.CargarRegistrosViolencia(DatosViolencia);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dateentrada.Text = "";
            txtexpediente.Text = "";
            txtvictima.Text = "";
            txtvictimario.Text = "";
            txtaudiencia.Text = "";
            txtfecha_audiencia.Text = "";
            txtresolucion.Text = "";
            txtobservaciones.Text = "";
            txtfolio.Text = "";
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtexpediente.Text == "" || txtvictima.Text == "" || txtvictimario.Text == "" || dateentrada.Text == "")
            {
                MessageBox.Show("Los campos que contengan (*) deben estar llenos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                conectar.Abrir();
                try
                {
                    var enter = dateentrada.Value.ToString("yyyy-MM-dd");
                    SqlCommand cmd = new SqlCommand("UPDATE violencia SET fechain='" + enter + "' ,n_exp='" + txtexpediente.Text + "', nombre_victima='" + txtvictima.Text + "', nombre_victimario='" + txtvictimario.Text + "', audiencia='" + txtaudiencia.Text + "', fecha_audiencia='" + txtfecha_audiencia.Text + "', resolucion='" + txtresolucion.Text + "',observaciones='" + txtobservaciones.Text + "', folio='" + txtfolio.Text +  "' " + "where id='" + codigo.Text + "'", conectar.con);
                    int filas = cmd.ExecuteNonQuery();
                    conectar.Cerrar();

                    dateentrada.Text = "";
                    txtexpediente.Text = "";
                    txtvictima.Text = "";
                    txtvictimario.Text = "";
                    txtaudiencia.Text = "";
                    txtfecha_audiencia.Text = "";
                    txtresolucion.Text = "";
                    txtobservaciones.Text = "";
                    txtfolio.Text = "";

                    if (filas > 0)
                    {
                        MessageBox.Show("Registro actualizado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                conectar.CargarRegistrosViolencia(DatosViolencia);
                conectar.Cerrar();

            }
        }

        private void DatosViolencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DatosViolencia.Rows[e.RowIndex];
            codigo.Text = Convert.ToString(fila.Cells[0].Value);
            dateentrada.Text = Convert.ToString(fila.Cells[1].Value);
            txtexpediente.Text = Convert.ToString(fila.Cells[2].Value);
            txtvictima.Text = Convert.ToString(fila.Cells[3].Value);
            txtvictimario.Text = Convert.ToString(fila.Cells[4].Value);
            txtaudiencia.Text = Convert.ToString(fila.Cells[5].Value);
            txtfecha_audiencia.Text = Convert.ToString(fila.Cells[6].Value);
            txtresolucion.Text = Convert.ToString(fila.Cells[7].Value);
            txtobservaciones.Text = Convert.ToString(fila.Cells[8].Value);
            txtfolio.Text = Convert.ToString(fila.Cells[9].Value);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM violencia WHERE id='" + codigo.Text + "'", conectar.con);
                int filas = cmd.ExecuteNonQuery();
                conectar.CargarRegistrosViolencia(DatosViolencia);
                conectar.Cerrar();

                dateentrada.Text = "";
                txtexpediente.Text = "";
                txtvictima.Text = "";
                txtvictimario.Text = "";
                txtaudiencia.Text = "";
                txtfecha_audiencia.Text = "";
                txtresolucion.Text = "";
                txtobservaciones.Text = "";
                txtfolio.Text = "";

                if (filas > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            da = new SqlDataAdapter("select id as [No.], fechain as [Fecha], n_exp as [Expediente], nombre_victima as [Víctima], nombre_victimario as [Victimario], audiencia as [Audiencia], fecha_audiencia as [Fecha Audiencia], resolucion as [Resolución], observaciones as [Observaciones], folio as [Folio] from violencia where nombre_victima LIKE'%" + txtbuscar.Text + "%'", conectar.con);
            dt = new DataTable();
            da.Fill(dt);
            DatosViolencia.DataSource = dt;
            conectar.Cerrar();
        }

        private void txtvictima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Asegurese de ingresar únicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtvictimario_KeyPress(object sender, KeyPressEventArgs e)
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
