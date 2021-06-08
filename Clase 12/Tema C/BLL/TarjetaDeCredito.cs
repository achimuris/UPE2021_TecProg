using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class TarjetaDeCredito : FormaDePago
    {
        public override float ObtenerRecargo()
        {
            return (float)0.1;
        }


        //public override string ToString()
        //{
        //    return "Tarjeta de crédito";
        //}

        public TarjetaDeCredito()
        {
            Nombre = "Tarjeta de crédito";
        }
    }
}