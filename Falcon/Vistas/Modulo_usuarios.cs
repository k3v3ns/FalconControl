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
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Falcon
{
    public partial class Modulo_usuarios : Form
    {
        private int mod = 0;

        public Modulo_usuarios(string usuario)
        {
            InitializeComponent();
            labelB.Text ="Tu sesión:  "+usuario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wnsg, int wparam, int lparam);

        BaseDeDatos bd = new BaseDeDatos();

        private void Modulo_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'falconDataSet6.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.falconDataSet6.Usuarios);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mod == 0)
            {
                
                
                if (tb_usuario.Text == "" || tb_pass.Text == "" || cb_tipo.Text == "")
                {
                    MessageBox.Show("Introduzca los datos para continuar");

                }
                else
                {
                    if (tb_pass.TextLength > 16)
                    {
                        MessageBox.Show("La contraseña debe tener máximo 16 caracteres", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    string agregar = "insert into Usuarios values('" + tb_usuario.Text + "','" + tb_pass.Text + "','" + cb_tipo.Text + "')";
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        Refresh();
                    }

                }

                mod = 0;

            }
            else
            {
                Textbox_Validados cosa = new Textbox_Validados();
                cosa.ContraseñaSegura(tb_pass, lbl);

                string actualizar = "update Usuarios set Password=" + "'" + tb_pass.Text + "'" + "where Usuario=" + "'" + tb_usuario.Text + "'";
                if (bd.executecommand(actualizar))
                {
                    MessageBox.Show("Registro actualizado correctamente");
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                    Refresh();
                }

                mod = 0;
            }
            
           


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Favor de seleccionar el registro a modificar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                cb_tipo.Enabled = false;
                button3.Visible = false;
                button4.Visible = false;
                button2.Visible = false;
                tb_usuario.Enabled = false;
                CancelarBtn.Visible = true;

                tb_usuario.Text = dgv_usuarios.SelectedCells[0].Value.ToString();
                tb_pass.Text = dgv_usuarios.SelectedCells[1].Value.ToString();
                cb_tipo.Text = dgv_usuarios.SelectedCells[2].Value.ToString();

                mod = 1;

            }

            /*if (tb_usuario.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("Introduzca el usuario y la contraseña a modificar para continuar ");

            }
            else
            {
                Textbox_Validados cosa = new Textbox_Validados();
                cosa.ContraseñaSegura(tb_pass,lbl);

                string actualizar = "update Usuarios set Password=" + "'" + tb_pass.Text + "'" + "where Usuario=" + "'" + tb_usuario.Text + "'";
                if (bd.executecommand(actualizar))
                {
                    MessageBox.Show("Registro actualizado correctamente");
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                    Refresh();
                }
            }*/
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Favor de seleccionar el registro a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Los registros eliminados no se podran recuperar\n¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string eliminar = "delete Usuarios where Usuario=" + "'" + dgv_usuarios.SelectedCells[0].Value.ToString() + "'";
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
                
            
            
            /*button1.Enabled = false;
            button2.Enabled = false;
            tb_pass.Enabled = false;
            cb_tipo.Enabled = false;

            if (tb_usuario.Text == "")
            {
                MessageBox.Show("Introduzca un ID para continuar");
            }
            else
            {
                if (MessageBox.Show("Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string eliminar = "delete Usuarios where Usuario=" + "'" + tb_usuario.Text + "'";
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Login ModForm = new Login();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    

        //VALIDACIONES
        public void Refresh()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            cb_tipo.Enabled = true;
            tb_pass.Enabled = true;
            tb_usuario.Text = "";
            tb_pass.Text = "";
            cb_tipo.Text = " ";
            lbl.Enabled = false;

            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            tb_usuario.Enabled = true;
            CancelarBtn.Visible = false;


            dgv_usuarios.DataSource = bd.SelectDataTable("select * from usuarios");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Paqueteria ModForm = new Paqueteria(labelS.Text);
            MessageBox.Show("Ha entrado a paquetería");

            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pruebas ModForm = new Pruebas(labelS.Text);
            MessageBox.Show("Ha entrado a pruebas");

            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void tb_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.LongitudDeUsuario(tb_usuario,lbl2);

            Textbox_Validados cosa1 = new Textbox_Validados();
            cosa1.SoloNumerosYLetras(e);
            
 
        }

        private void tb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.ContraseñaSegura(tb_pass,lbl);
       
        }

        private void cb_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Cerrar_sesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                Login ModForm = new Login();
                ModForm.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Login ModForm = new Login();
            this.Close();
            ModForm.Show();
            
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            mod = 0;
            Refresh();
        }
    }
}
