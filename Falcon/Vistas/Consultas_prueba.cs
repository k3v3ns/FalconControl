using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Falcon.Controlador;
using Falcon.Modelo;
using System.Runtime.InteropServices;



namespace Falcon
{
    public partial class Consultas_prueba : Form
    {
        public SqlConnection conexion = new SqlConnection("Data Source="+ Environment.MachineName + ";Initial Catalog=Falcon;Integrated Security=True");
        public Consultas_prueba()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wnsg, int wparam, int lparam);

        //BaseDeDatos bd = new BaseDeDatos();
        private void Consultas_prueba_Load(object sender, EventArgs e)
        {
          
        }
        void buscar()
        {
            //SqlDataAdapter da = new SqlDataAdapter("buscar", cm);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dt_desde.Text;
            //da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = dt_hasta.Text;
            //DataTable dt = new DataTable();
            //this.dgv_consultas.DataSource = dt;
            //da.Fill(dt);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pruebas ModForm = new Pruebas(labelS.Text);
            this.Hide();
            ModForm.Show();
            this.Show();
            Acceso_Chain_of_responsability cosa = new Acceso_Chain_of_responsability();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_tipoprueba.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de prueba");
            }
            string query = "Select * from Prueba where TipoPrueba= '"+cb_tipoprueba.Text+"'"+ " and Fecha >='" + dt_desde.Text+"'"+" and Fecha <='"+dt_hasta.Text+"'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv_consultas.DataSource = tabla;

           
        }



 

        private void button3_Click(object sender, EventArgs e)
        {
            Patrones_UX cosa = new Patrones_UX();
            cosa.ExportarDatos(dgv_consultas);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dgv_consultas.Rows)
            {
                total += Convert.ToInt32(row.Cells["Cantidad"].Value);
            }
            Lbl_total.Text = Convert.ToString(total);
        }

        private void cb_tipoprueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_tipoprueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tipoprueba.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dt_hasta_ValueChanged(object sender, EventArgs e)
        {
            dt_hasta.Value = DateTime.Today.AddDays(-7);
            
        }

        private void dt_desde_ValueChanged(object sender, EventArgs e)
        {
            dt_desde.Value = DateTime.Today.AddDays(-7);
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTituloBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
