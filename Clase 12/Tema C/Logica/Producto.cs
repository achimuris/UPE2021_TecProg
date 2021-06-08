using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Producto
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private double _precio;

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        /// <summary>
        /// Constructor definido por nosotros
        /// </summary>
        /// <param name="unNombre"></param>
        /// <param name="unPrecio"></param>
        public Producto(string unNombre, double unPrecio)
        {
            this._precio = unPrecio;
            this.Nombre = unNombre;
        }


    }
}