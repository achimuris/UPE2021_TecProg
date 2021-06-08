using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public abstract class FormaDePago
    {

        
        /// <summary>
        /// Este método se encarga de devolver un porcentaje de
        /// descuento o de recargo
        /// </summary>
        /// <returns>porcentaje</returns>
        public abstract float ObtenerRecargo();

        public string Nombre { get; set; }

    }
}