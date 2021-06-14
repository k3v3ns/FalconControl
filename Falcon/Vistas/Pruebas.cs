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
using Microsoft.Office.Core;

namespace Falcon
{
    public partial class Pruebas : Form
    {
        private int mod = 0;

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wnsg, int wparam, int lparam);

        struct LASTINPUTINFO
        {
            public int cbSize; // TAMAÑO DE LA ESTRUCTURA EN BYTES ¿?
            public int dwTime; // MOMENTO (MILISEGUNDOS DESDE QUE SE INICIO LA SESION) EN QUE SE PULSA UNA TECLA O SE ACTIVA EL MOUSE
        }

        private LASTINPUTINFO INPUT = new LASTINPUTINFO(); // PARA USAR LA ESTRUCTURA EN LA FUNCION GetLastInputInfo

        public Pruebas(string usuario)
        {
            InitializeComponent();
            labelB.Text = "Tu sesión:  " + usuario;
            if (usuario == "Activo")
            {
                Cerrar_sesion.Visible = true;

            }
            else
            {
                Cerrar_sesion.Visible = false;
            }
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void Pruebas_Load(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas_prueba ModForm = new Consultas_prueba();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Consultas_paquetería ModForm = new Consultas_paquetería();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login ModForm = new Login();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login ModForm = new Login();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dt_fecha.Value = DateTime.Today.AddDays(-7);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Consultas_prueba ModForm = new Consultas_prueba();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }
      

        private void bnt_agregar_Click(object sender, EventArgs e)
        {
            if (mod == 0)
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("Introduzca un ID para continuar");
                }
                else
                {

                    string agregar = "insert into prueba values(" + tb_id.Text + ",'" + dt_fecha.Text + "','" + cb_tipoprueba.Text + "'," + tb_cantidad.Text + ")";
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar");
                    }
                }
            }
            else
            {
                if (tb_id.Text == "" && tb_cantidad.Text == "")
                {
                    MessageBox.Show("Introduzca un ID y la Cantidad a modificar para continuar ");

                }
                else
                {
                    string actualizar = "update prueba set Cantidad=" + tb_cantidad.Text + "where ID=" + dgv_pruebas.SelectedCells[0].Value.ToString();
                    if (bd.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        Refresh();
                    }
                }

                mod = 0;

            }

            
           
        }
     

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_pruebas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Favor de seleccionar el registro a eliminar", "Registro no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Los registros eliminados no se podran recuperar\n\n¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string eliminar = "delete prueba where ID=" + dgv_pruebas.SelectedCells[0].Value.ToString();
                    if (bd.executecommand(eliminar))
                    {
                        MessageBox.Show("Registro eliminado correctamente");
                        Refresh();
                    }
                }
                else
                {
                    Refresh();
                }
            }

            /*panel8.Enabled = false;
            btn_modificar.Enabled = false;
            btn_Limpiar.Enabled = false;
            bnt_agregar.Enabled = false;

            if (tb_id.Text == "")
            {
                MessageBox.Show("Introduzca un ID para continuar");
            }
            else
            {
                if (MessageBox.Show("Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string eliminar = "delete prueba where ID=" + tb_id.Text;
                    if (bd.executecommand(eliminar))
                    {
                        MessageBox.Show("Registro eliminado correctamente");
                        Refresh();
                    }
                }
                else
                {
                    Refresh();
                }
            }*/

           
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Botones_validados cosa = new Botones_validados();
            cosa.BotonSalir();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Consultas_prueba ModForm = new Consultas_prueba();
            ModForm.ShowDialog();
        }

        private void panel_menus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            
        }

      private void dgv_pruebas_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
          /*tb_id.Text = dgv_pruebas.SelectedCells[0].Value.ToString();
          dt_fecha.Text = dgv_pruebas.SelectedCells[1].Value.ToString();
          cb_tipoprueba.Text = dgv_pruebas.SelectedCells[2].Value.ToString();
          tb_cantidad.Text = dgv_pruebas.SelectedCells[3].Value.ToString();*/
      }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Pruebas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'falconDataSet8.Prueba' Puede moverla o quitarla según sea necesario.
            this.pruebaTableAdapter1.Fill(this.falconDataSet8.Prueba); //<--- Este me da error cuando entro a este modulo
            // TODO: esta línea de código carga datos en la tabla 'falconDataSet3.Prueba' Puede moverla o quitarla según sea necesario.
            //  this.pruebaTableAdapter.Fill(this.falconDataSet3.Prueba);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgv_pruebas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Favor de seleccionar el registro a eliminar", "Registro no encontrado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                tb_id.Text = dgv_pruebas.SelectedCells[0].Value.ToString();
                dt_fecha.Text = dgv_pruebas.SelectedCells[1].Value.ToString();
                cb_tipoprueba.Text = dgv_pruebas.SelectedCells[2].Value.ToString();
                tb_cantidad.Text = dgv_pruebas.SelectedCells[3].Value.ToString();

                btn_modificar.Visible = false;
                btn_eliminar.Visible = false;
                btn_Limpiar.Text = "Cancelar";
                tb_id.Enabled = false;
                mod = 1;
            }

            /*panel3.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_Limpiar.Enabled = false;
            bnt_agregar.Enabled = false;

            if (tb_id.Text == "" && tb_cantidad.Text=="")
            {
                MessageBox.Show("Introduzca un ID y la Cantidad a modificar para continuar ");
                btn_eliminar.Enabled = true;
                btn_Limpiar.Enabled = true;
                bnt_agregar.Enabled = true;

            }
            string actualizar = "update prueba set Cantidad=" + tb_cantidad.Text + "where ID=" + tb_id.Text;
            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Registro actualizado correctamente");
                Refresh();
            }*/
           
        }

        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            if (mod == 0)
            {
                tb_id.Text = "";
                dt_fecha.Text = "";
                cb_tipoprueba.Text = "";
                tb_cantidad.Text = "";
            }
            else
            {
                tb_id.Text = "";
                dt_fecha.Text = "";
                cb_tipoprueba.Text = "";
                tb_cantidad.Text = "";
                btn_modificar.Visible = true;
                btn_eliminar.Visible = true;
                tb_id.Enabled = true;
                btn_Limpiar.Text = "Limpiar";
                mod = 0;
            }
            

        }

        //VALIDACIONES
        public void Refresh()
        {
            tb_id.Text = "";
            dt_fecha.Text = "";
            cb_tipoprueba.Text = "";
            tb_cantidad.Text = "";
            dgv_pruebas.DataSource = bd.SelectDataTable("select * from prueba");
            panel8.Enabled = true;
            panel3.Enabled = true;
            btn_modificar.Enabled = true;
            btn_Limpiar.Enabled = true;
            bnt_agregar.Enabled = true;
            btn_eliminar.Enabled = true;

            btn_modificar.Visible = true;
            btn_eliminar.Visible = true;
            btn_Limpiar.Text = "Limpiar";
            tb_id.Enabled = true;
        }

        private void cb_tipoprueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tipoprueba.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cb_tipoprueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.SoloNumeros(e);
            Textbox_Validados cosa1 = new Textbox_Validados();
            cosa1.LongitudCantidades(tb_cantidad);
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.SoloNumeros(e);
            Textbox_Validados cosa1 = new Textbox_Validados();
            cosa1.LongitudId(tb_id,lbl);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Inactividad cosa = new Inactividad();
            cosa.Activacion(timer1);
            cosa.evento(timer1);
        }

        private void Cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Botones_validados cosa = new Botones_validados();
            cosa.CerrarSesion();
        }

        private void BotonMinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Login cosa = new Login();
            this.Close();
            cosa.Show();

        }

        private void BarraTituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
