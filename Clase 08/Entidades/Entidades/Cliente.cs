using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private DateTime _fechaDeNacimiento;

        public DateTime FechaDeNacimiento
        {
            get { return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }
        }



    }
}
