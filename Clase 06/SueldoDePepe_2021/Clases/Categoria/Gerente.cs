using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Gerente : Categoria
    {
        public override float SueldoNeto()
        {
            return 1000;
        }

        public Gerente()
        {
            this.Nombre = "Gerente";
        }
    }
}
