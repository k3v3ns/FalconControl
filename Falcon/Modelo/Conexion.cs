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

namespace Falcon.Modelo
{
      public class Conexion
    {

       //CONEXION A BASE DE DATOS CON EL PATRON DE DISEÑO SINGLETON

            public static SqlConnection cnn = null;
            public static Conexion conector = null;
            public static Conexion Instancia
            {
                get
                {
                    if (conector == null)
                    {
                        conector = new Conexion();
                        Console.WriteLine("Clase ConexionAbierta");
                    }
                    return conector;
                }
            }
            private Conexion()
            {

            }
            public SqlConnection getConexion()
            {
                if (cnn == null)
                {
                    cnn = new SqlConnection("Data Source="+ Environment.MachineName + ";Initial Catalog=Falcon;Integrated Security=True");
                cnn.Open();
                    Console.WriteLine("Conexion abierta");
                }
                return cnn;
            }
            public void disconnect()
            {
                SqlConnection sql = getConexion();
                cnn.Close();
                Console.WriteLine("Conexion cerrada");
            }
        }
  
}
