using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPorResultadoFijo : BonoPorResultado
    {
        public override float DevolverBono(Categoria pCategoria)
        {
            return 80;
        }
    }
}
