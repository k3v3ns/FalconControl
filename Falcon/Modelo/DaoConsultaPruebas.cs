using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Falcon.Modelo.Dto;

namespace Falcon.Modelo
{
    class DaoConsultaPruebas
    {
        public SqlConnection conexion = new SqlConnection("Data Source="+ Environment.MachineName +";Initial Catalog=Falcon;Integrated Security=True");

        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();
        //METODOS CRUD
        public List<ConsultaPruebas> VerRegistros(string Condicion)
        {
            Comando.Connection = conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);
            conexion.Open();
            LeerFilas = Comando.ExecuteReader();
            //DTO

            List<ConsultaPruebas> ListaGenerica = new List<ConsultaPruebas>();//Lista generica 
            //Diccionario
            //Serializacion- XML, JSON, Nativa 
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ConsultaPruebas
                {
                    ID = LeerFilas.GetInt32(0),
                    Fecha = LeerFilas.GetString(1),
                    TipoPrueba = LeerFilas.GetString(2),
                    Cantidad = LeerFilas.GetString(3),
                   
                });
            }
            LeerFilas.Close();
            conexion.Close();
            return ListaGenerica;
        }

    }
}
