using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Cadete : Categoria
    {
        public override float SueldoNeto()
        {
            return 1500;
        }

        public Cadete()
        {
            this.Nombre = "Cadete";
        }
    }
}
