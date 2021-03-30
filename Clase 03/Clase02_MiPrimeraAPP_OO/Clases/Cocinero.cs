using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Cocinero
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

        private string _email;
        public string DireccionDeCorreoElectronico
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
