using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Singleton;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Falcon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
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


        private void button1_Click(object sender, EventArgs e)
        {
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
      
        private void Form6_Load(object sender, EventArgs e)
        {
            INPUT.cbSize = Marshal.SizeOf(INPUT); // ¿? PERO ES NECESARIO
            timer1.Interval = 1000; // MONITORIZAREMOS GetLastInputInfo CADA SEGUNDO
            timer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Acceso_Chain_of_responsability cosa = new Acceso_Chain_of_responsability();
            cosa.logear(this.user.Text, this.password.Text);
            this.Close();
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Botones_validados cosa = new Botones_validados();
            cosa.BotonSalir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.SoloNumerosYLetras(e);
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textbox_Validados cosa = new Textbox_Validados();
            cosa.SoloNumerosYLetras(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetLastInputInfo(ref INPUT); // COMPROBAMOS LA FUNCION CADA SEGUNDO

            int TOTAL = Environment.TickCount; // MILISEGUNDOS DESDE QUE SE INICIO LA SESION
            int ULTIMO = INPUT.dwTime; // MILISEGUNDOS DESDE LA ULTIMA ACTIVIDAD (TECLADO Y MOUSE)
            int INTERVALO = (TOTAL - ULTIMO) / 1000; // DIFERENCIA EN SEGUNDOS 

           // label4.Text = INTERVALO.ToString() ; // MUESTRA EL INTERVALO EN SEGUNDOS TRANSCURRIDOS DESDE LA ULTIMA ACTIVIDAD

            if (INTERVALO >= 20)
            {
                timer1.Stop();
                MessageBox.Show("Tiempo de inactividad agotado");
                Application.Exit();
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
