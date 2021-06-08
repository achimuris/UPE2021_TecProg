using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Efectivo : FormaDePago
    {
        public override float ObtenerRecargo()
        {
            return (float)-0.1;
        }
    }
}