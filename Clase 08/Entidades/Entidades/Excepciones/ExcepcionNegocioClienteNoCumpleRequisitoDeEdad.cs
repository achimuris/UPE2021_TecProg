using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Excepciones
{
    public class ExcepcionNegocioClienteNoCumpleRequisitoDeEdad : ExcepcionDeNegocio
    {
        public ExcepcionNegocioClienteNoCumpleRequisitoDeEdad()
        {
            this.Descripcion = "¡El o la o le cliente debe tener al menos 18 años!";
        }
    }
}
