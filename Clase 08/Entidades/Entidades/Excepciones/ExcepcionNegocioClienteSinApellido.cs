using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Excepciones
{
    public class ExcepcionNegocioClienteSinApellido : ExcepcionDeNegocio
    {

        public ExcepcionNegocioClienteSinApellido()
        {

            this.Descripcion = "¡No puede crear un cliente sin indicar cuál es su apellido!";
        }

    }
}
