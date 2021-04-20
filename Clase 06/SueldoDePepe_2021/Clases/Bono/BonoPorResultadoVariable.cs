using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPorResultadoVariable : BonoPorResultado
    {
        /// <summary>
        /// Devuelve el 10% del sueldo neto
        /// </summary>
        /// <param name="pCategoria"></param>
        /// <returns></returns>
        public override float DevolverBono(Categoria pCategoria)
        {
            return (float)(pCategoria.SueldoNeto() * 0.1);
        }
    }
}
