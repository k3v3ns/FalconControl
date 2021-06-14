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
using System.Runtime.InteropServices;


namespace Falcon
{
   public class Inactividad
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        struct LASTINPUTINFO
        {
            public int cbSize; // TAMAÑO DE LA ESTRUCTURA EN BYTES ¿?
            public int dwTime; // MOMENTO (MILISEGUNDOS DESDE QUE SE INICIO LA SESION) EN QUE SE PULSA UNA TECLA O SE ACTIVA EL MOUSE
        }

        private LASTINPUTINFO INPUT = new LASTINPUTINFO(); // PARA USAR LA ESTRUCTURA EN LA FUNCION GetLastInputInfo

        public void Activacion(Timer timer1)
        {
            INPUT.cbSize = Marshal.SizeOf(INPUT); // ¿? PERO ES NECESARIO
            timer1.Interval = 1000; // MONITORIZAREMOS GetLastInputInfo CADA SEGUNDO
            timer1.Start();


            
        }
        public void evento(Timer timer1)
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


    }
}
