using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public abstract class Bono
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
}
