using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Excepciones
{
    public class ExcepcionDeNegocio : Exception
    {
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
