using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Plato
    {
        private string _nombre;
        private double _precioBase = 300;
        private int _cantidadDeIngredientes;

        //Lo inicializamos para que no genere "nullreferenceexception"
        private List<int> _puntajes = new List<int>();

        //Propiedad o "get and set".
        //Bajo el nombre de CantidadDeIngredientes "encapsulamos" el acceso a la variable
        //_cantidadDeIngredientes
        public int CantidadDeIngredientes
        {
            get { return _cantidadDeIngredientes; }
            set {
                if (value < 0)
                {
                    _cantidadDeIngredientes = 0;
                }
                else
                {
                    _cantidadDeIngredientes = value;
                }
            }
        }


        public string GetNombre()
        {
            return this._nombre;
        }

        public void SetNombre(string unNombre)
        {
            this._nombre = unNombre;
        }

        /// <summary>
        /// double getPrecio(): “Devuelve el precio que se calcula según la 
        /// cantidad de ingredientes. Si la cantidad de ingredientes es mayor a 
        /// 3, cada ingrediente se cobra 20 pesos. Si es menor, 
        /// cada uno se cobra 30 pesos.”
        /// </summary>
        /// <returns></returns>
        public double GetPrecio()
        {
            double precioFinal = this._precioBase;

            if (this._cantidadDeIngredientes > 0)
            {
                if (this._cantidadDeIngredientes > 3)
                {
                    precioFinal = precioFinal + CantidadDeIngredientes * 20;
                }
                else
                {
                    precioFinal = precioFinal + CantidadDeIngredientes * 30;
                }
            }

            return precioFinal;
        }


        public Plato()
        {
        }

        public Plato(string elNombre, int cantidadDeIngredientes)
        {
            this._nombre = elNombre;
            this.CantidadDeIngredientes = cantidadDeIngredientes;
        }

        /*>>double getOpinionPromedio(): “Devuelve el promedio de las opiniones sobre ese plato”.
>>AgregarOpinion(int unPuntaje)*/

        public double getOpinionPromedio()
        {
            double sumaPromedio = 0;
            if (this._puntajes.Count>0)
            {
                for (int i = 0; i < this._puntajes.Count; i++)
                {
                    sumaPromedio = sumaPromedio + this._puntajes[i];
                }

                sumaPromedio = sumaPromedio / this._puntajes.Count;
            }

            return sumaPromedio;

        }

        public void AgregarOpinion(int unPuntaje)
        {
            _puntajes.Add(unPuntaje);
            
        }



    }
}
