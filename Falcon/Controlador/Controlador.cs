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
using Falcon.Modelo.Dto;
using Falcon.Modelo;

namespace Falcon.Controlador
{
    class Controlador
    {
        Consultas_prueba vista;

        //Constructor
        public Controlador(Consultas_prueba View)
        {
            vista = View;
            //inicializar eventos
            vista.Load += new EventHandler(ClientList);
            vista.button1.Click += new EventHandler(ClientList);
            vista.cb_tipoprueba.TextChanged += new EventHandler(ClientList);
        }

        private void ClientList(object sender, EventArgs e)
        {
            DaoConsultaPruebas db = new DaoConsultaPruebas();
            vista.dgv_consultas.DataSource =
                db.VerRegistros(vista.cb_tipoprueba.Text);
        }


    }
}
