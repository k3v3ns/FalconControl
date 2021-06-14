using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falcon.Modelo.Dto
{
    class ConsultaPruebas
    {
        //ATRIBUTOS 
        int _ID;
        string _Fecha;
        string _TipoPrueba;
        string _Cantidad;
        //PROPIEDADES GETTERS AND SETTERS
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public string TipoPrueba
        {
            get
            {
                return _TipoPrueba;
            }

            set
            {
                _TipoPrueba = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }
    }
}
