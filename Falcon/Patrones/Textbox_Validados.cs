
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Falcon
{
    /// <summary>Class Textbox_Validados.</summary>
    class Textbox_Validados
    {
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        public void SoloNumerosYLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64)|| (e.KeyChar >= 123 && e.KeyChar <= 255)|| (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo numero y letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        public void ContraseñaSegura(TextBox tb_pass,Label lbl)
        {

            Regex rx = new Regex(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$"); //De 8 a 16 caracteres y almenos una minisculo y mayuscula
            if (rx.IsMatch(tb_pass.Text))
            {
                lbl.Text = "Contraseña aceptable";
            }
            else 
            {
                lbl.Text = "La contraseña debe tener al menos un dígito,una mayuscula y 8 caracteres.";
                if (tb_pass.TextLength > 16)
                {
                    lbl.Text = "La contraseña debe tener máximo 16.";
                }
  
            }

        }
        public void LongitudDeUsuario(TextBox tb_usuario,Label lbl2)
        {
            if (tb_usuario.TextLength < 3)
            {
                lbl2.Text = "Minimo 3 caracteres";
            }
            else
            {
                if (tb_usuario.TextLength > 10)
                {
                    MessageBox.Show("Se permite un máximo de 10 caracteres", "Longitud máxima alcanzada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tb_usuario.Text = "";

                }
                else
                {
                    lbl2.Text = "_";
                }
            }
        }

        public void LongitudId(TextBox tb_id,Label lbl)
        {
            Regex rx = new Regex(@"^\S{1,4}$"); //De 1 a 4 caracteres
            if (rx.IsMatch(tb_id.Text))
            {
                lbl.Text = "";
            }
            else if (tb_id.TextLength > 4)
            {
          
                    lbl.Text = "4 caracteres máximo";


            }
        }

        public void LongitudCantidades(TextBox tb_cantidad)
        {
            
           
            if (tb_cantidad.TextLength > 2)
            {
                MessageBox.Show("Se permite un máximo de 2 caracteres", "Longitud máxima alcanzada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb_cantidad.Text = "";

            }
        }

        public void Factura(TextBox tb,Label lbl)
        {
            Regex rx = new Regex(@"^\S{4,16}$"); //De 4 a 16 caracteres
            if (rx.IsMatch(tb.Text))
            {
                lbl.Text = "";
            }
            else if (tb.TextLength > 16)
            {

                lbl.Text = "16 caracteres máximo";


            }
        }
    }



 }

