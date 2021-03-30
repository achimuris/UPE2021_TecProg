using System;
using Clases;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
  

            Plato objPlato = new Plato();

            objPlato.SetNombre("Milanesa napolitana");


            Console.WriteLine("El plato se llama: " + objPlato.GetNombre());
        }
    }
}
