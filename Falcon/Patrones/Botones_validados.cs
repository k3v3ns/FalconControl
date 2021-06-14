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
using System.Data.Sql;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Falcon.Controlador;
using Falcon.Modelo;

namespace Falcon
{
    class Botones_validados
    {
        public void BotonSalir()
        {
            if (MessageBox.Show("Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
        public void CerrarSesion()
        {
            

        }
        




    }
}   
