using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falcon
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
                label1.Text = "Cargando el sistema al " + progressBar1.Value+"%";

            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            

                    Login ModForm = new Login();
                    ModForm.Show();
                    //this.Show();
                
               
              
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
