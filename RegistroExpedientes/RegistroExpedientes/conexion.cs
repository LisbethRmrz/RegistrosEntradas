using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace RegistroExpedientes
{
    class conexion
    {
        public string cadena = @"Data Source=localhost; Initial Catalog=entradas; Integrated Security=True; User Id=sa; Password=123456";
        public SqlConnection con = new SqlConnection();

        //Para el DGV
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public conexion()
        {
            con.ConnectionString = cadena;
        }


        public void Abrir()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error al abrir la conexion", MessageBoxButtons.OK);
            }
        }

        public void Cerrar()
        {
            con.Close();
        }
        //Procedimiento para cargar Registros
        public void CargarRegistros(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select id as [No.], exp_año as [Expediente], fechain as [Entrada], nombre as [Nombre], apellido as [Apellido], infracciones as [Infracciones], ofendidos as [Ofendido(s)], audienciainicial as [Audiencia Inicial], numpag as [Folio], observaciones as [Resolución] from datos", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las Entradas");
                ex.ToString();
            }
        }

        public void CargarUsuarios(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select id as [No.], usuario as [Usuario], nombres as [Nombre], apellidos  as [Apellidos], correo as [Correo], cargo as [Cargo], contra as [Contraseña] from usuarios", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Usuarios");
                ex.ToString();
            }
        }

        public void CargarRegistrosViolencia(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select id as [No.], fechain as [Fecha], n_exp as [Expediente], nombre_victima as [Víctima], nombre_victimario as [Victimario], audiencia as [Aud_Preliminar], fecha_audiencia as [Audiencia], resolucion as [Resolución], observaciones as [Observaciones], folio as [Folio] from violencia", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Registros");
                ex.ToString();
            }
        }
    }
}
