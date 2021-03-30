using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Carta
    {
        private List<Plato> platos = new List<Plato>();

        public List<Plato> Platos
        {
            get { return platos; }
            set { platos = value; }
        }

        public void AgregarPlato(Plato unPlato)
        {
            this.platos.Add(unPlato);
        }

        public void RemoverPlato(Plato unPlato)
        {
            this.platos.Remove(unPlato);
        }

        //>>double PrecioPromedio(): “Devuelve el promedio de precios de todos los platos”
        //>>Plato PlatoConMejorOpinion(): “Devuelve el plato con mejor opinión”


        public double PrecioPromedio()
        {
            double precioPromedio = 0;
            double precioAcumulado = 0;

            foreach (Plato unPlato in this.platos)
            {
                precioAcumulado = precioAcumulado + unPlato.GetPrecio();
            }

            precioPromedio = precioAcumulado / this.platos.Count;

            return precioPromedio;
        
        }


        public Plato PlatoConMejorOpinion()
        {
            //Declaro el plato
            Plato mejorPlato;

            //Instanció un plato
            mejorPlato = new Plato();

            double mejorOpinion = 0;

            foreach (Plato unPlato in this.platos)
            {
                if (unPlato.getOpinionPromedio() > mejorOpinion)
                {
                    mejorPlato = unPlato;
                    mejorOpinion = unPlato.getOpinionPromedio();
                }
            }

            return mejorPlato;
        }



    }
}