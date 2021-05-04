using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Excepciones
{
    public class ExcepcionNegocioClienteSinNombre : ExcepcionDeNegocio
    {
        public ExcepcionNegocioClienteSinNombre()
        {
            this.Descripcion = "¡No puede crear un cliente sin indicar cuál es su nombre!";
        }
    }
}
