using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class DetalleFactura
    {
        private Producto _producto;

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }


        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public double SubTotal()
        {
            return (this.Cantidad * Producto.Precio);
        }

        public override string ToString()
        {
            return this.Cantidad + " - " + this._producto.Nombre;
        }

    }
}