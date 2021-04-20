using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPorPresentismo : Bono
    {
        public float DevolverBono(int pCantidadDeAusentes)
        {
            float bono = 0;

            switch (pCantidadDeAusentes)
            {
                case 0:
                    bono = 100;
                    break;
                case 1:
                    bono = 50;
                    break;
                default:
                    bono = 0;
                    break;
            }

            return bono;
        }
    }
}
