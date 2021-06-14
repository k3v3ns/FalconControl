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

namespace Falcon
{
    public partial class Paqueteria : Form
    {
        private int mod = 0;
        public Paqueteria(string usuario)
        {
            InitializeComponent();
            this.CenterToScreen();
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wnsg, int wparam, int lparam);

        BaseDeDatos bd = new BaseDeDatos();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form6 ModForm = new Form6();
            //this.Hide();
            //ModForm.ShowDialog();
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 ModForm = new Form1();
            //this.Hide();
            //ModForm.ShowDialog();
            //this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas_paquetería ModForm = new Consultas_paquetería();
            this.Hide();
            ModForm.Show();
            this.Show();
        }

        private void Paqueteria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'falconDataSet7.Paqueteria' Puede moverla o quitarla según sea necesario.
            this.paqueteriaTableAdapter1.Fill(this.falconDataSet7.Paqueteria); //<-- Este me da error al abrir este form
            // TODO: esta línea de código carga datos en la tabla 'falconDataSet4.Paqueteria' Puede moverla o quitarla según sea necesario.
            //this.paqueteriaTableAdapter.Fill(this.falconDataSet4.Paqueteria);

        }

        //VALIDACIONES
        public void Refresh()
        {
            tb_guia.Text = "";
            dt_fecha2.Text = "";
            cb_paqueteria2.Text = "";
            cb_temperatura.Text = "";
            cb_proveedor2.Text = "";
            tb_factura2.Text = "";
            tb_paquetes2.Text = "";
            dgv_paqueteria.DataSource = bd.SelectDataTable("select * from paqueteria");
            panel8.Enabled = true;
            panel3.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = true;
            bnt_agregar.Enabled = true;
            btn_eliminar.Enabled = true;

            tb_guia.Enabled = true;
            button4.Text = "Limpiar";
            button2.Visible = true;
            btn_eliminar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login ModForm = new Login();
            this.Hide();
            ModForm.Show();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Botones_validados cosa = new Botones_validados();
            cosa.BotonSalir();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Consultas_paquetería ModForm = new Consultas_paquetería();
            ModForm.ShowDialog();
        }

        private void bnt_agregar_Click(object sender, EventArgs e)
        {
            if (mod == 0)
            {
                //string agregar = "insert into Paqueteria values(" + tb_guia.Text + ",'" + dt_fecha.Text + "','" + cb_paqueteria.Text + "'," + tb_temperatura.Text + ",'"+cb_proveedor.Text+"',"+tb_factura.Text+","+tb_paquetes.Text+")";
                string agregar = "insert into Paqueteria values(" + tb_guia.Text + ",'" + dt_fecha2.Text + "','" + cb_paqueteria2.Text + "','" + cb_temperatura.Text + "','" + cb_proveedor2.Text + "','" + tb_factura2.Text + "'," + tb_paquetes2.Text + ")";

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
            else
            {
                if (tb_guia.Text == "" && tb_paquetes2.Text == "")
                {
                    MessageBox.Show("Introduzca un ID y la Cantidad a modificar para continuar");
                }
                else
                {
                    string actualizar = "update paqueteria set No_paquetes=" + tb_paquetes2.Text + "where Guia=" + tb_guia.Text;
                    if (bd.executecommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente");
                        Refresh();
                    }
                }
                
            }

            
          
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_paqueteria.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Favor de seleccionar el registro a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Los registros eliminados no se podran recuperar\n¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string eliminar = "delete Paqueteria where Guia=" + dgv_paqueteria.SelectedCells[0].Value.ToString();
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

            /*panel3.Enabled = false;
            panel8.Enabled = false;
            panel10.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;
            bnt_agregar.Enabled = false;

            if (tb_guia.Text == "")
            {
                MessageBox.Show("Introduzca un numero de guia para continuar");
            }
            else
            {
                if (MessageBox.Show("Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string eliminar = "delete Paqueteria where Guia=" + tb_guia.Text;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (mod == 0)
            {
                tb_guia.Text = "";
                dt_fecha2.Text = "";
                cb_paqueteria2.Text = "";
                cb_temperatura.Text = "";
                cb_proveedor2.Text = "";
                tb_factura2.Text = "";
                tb_paquetes2.Text = "";
            }
            else
            {
                tb_guia.Text = "";
                dt_fecha2.Text = "";
                cb_paqueteria2.Text = "";
                cb_temperatura.Text = "";
                cb_proveedor2.Text = "";
                tb_factura2.Text = "";
                tb_paquetes2.Text = "";
                button2.Visible = true;
                btn_eliminar.Visible = true;
                button4.Text = "Limpiar";
                tb_guia.Enabled = true;
                mod = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_paqueteria.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Favor de seleccionar el registro a modificar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                tb_guia.Text = dgv_paqueteria.SelectedCells[0].Value.ToString();
                dt_fecha2.Text = dgv_paqueteria.SelectedCells[1].Value.ToString();
                cb_paqueteria2.Text = dgv_paqueteria.SelectedCells[2].Value.ToString();
                cb_temperatura.Text = dgv_paqueteria.SelectedCells[3].Value.ToString();
                cb_proveedor2.Text = dgv_paqueteria.SelectedCells[4].Value.ToString();
                tb_factura2.Text = dgv_paqueteria.SelectedCells[5].Value.ToString();
                tb_paquetes2.Text = dgv_paqueteria.SelectedCells[6].Value.ToString();

                button2.Visible = false;
                btn_eliminar.Visible = false;
                button4.Text = "Cancelar";
                tb_guia.Enabled = false;

                mod = 1;
            }

            /*panel3.Enabled = false;
            panel8.Enabled = false;
            btn_eliminar.Enabled = false;
            button4.Enabled = false;
            bnt_agregar.Enabled = false;

            if (tb_guia.Text == "" && tb_paquetes2.Text == "")
            {
                MessageBox.Show("Introduzca un ID y la Cantidad a modificar para continuar ");
            }
            string actualizar = "update paqueteria set No_paquetes=" + tb_paquetes2.Text + "where Guia=" + tb_guia.Text;
            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Registro actualizado correctamente");
                Refresh();
            }*/
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void cb_paqueteria2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_paqueteria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_paqueteria2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cb_proveedor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_proveedor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_proveedor2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void tb_guia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_guia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.SoloNumerosYLetras(e);
            Textbox_Validados cosa1 = new Textbox_Validados();
            cosa1.LongitudId(tb_guia,lbl);
        }

        private void tb_factura2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.SoloNumerosYLetras(e);
            Textbox_Validados cosa1 = new Textbox_Validados();
            cosa1.Factura(tb_factura2,lbl2);
        }

        private void tb_paquetes2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.SoloNumeros(e);
            Textbox_Validados cosa1 = new Textbox_Validados();
            cosa1.LongitudCantidades(tb_paquetes2);
        }

        private void cb_temperatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_temperatura.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cb_temperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dt_fecha2_ValueChanged(object sender, EventArgs e)
        {
            //dt_fecha2.Value = DateTime.Today.AddDays(-7);
        }

        private void Cerrar_sesion_Click(object sender, EventArgs e)
        {
            Botones_validados cosa = new Botones_validados();
            cosa.CerrarSesion();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
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

        private void dgv_paqueteria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*tb_guia.Text = dgv_paqueteria.SelectedCells[0].Value.ToString();
            dt_fecha2.Text = dgv_paqueteria.SelectedCells[1].Value.ToString();
            cb_paqueteria2.Text = dgv_paqueteria.SelectedCells[2].Value.ToString();
            cb_temperatura.Text = dgv_paqueteria.SelectedCells[3].Value.ToString();
            cb_proveedor2.Text = dgv_paqueteria.SelectedCells[4].Value.ToString();
            tb_factura2.Text = dgv_paqueteria.SelectedCells[5].Value.ToString();
            tb_paquetes2.Text = dgv_paqueteria.SelectedCells[6].Value.ToString();*/
        }
    }
}

