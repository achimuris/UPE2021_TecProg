using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Factura
    {
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private string _numero;

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private bool _aplicaIVA;

        public bool AplicaIVA
        {
            get { return _aplicaIVA; }
            set { _aplicaIVA = value; }
        }



        /// <summary>
        /// Se encarga de devolver el total de la factura
        /// </summary>
        /// <returns></returns>
        public double TotalFactura()
        {
            double total = 0;


            //1 Tornillos cantidad: 20 - Precio: 200  --> SubTotal 4000
            //2 Tuercas cantidad 5 - Precio 12 --> Subtotal 60
            foreach (DetalleFactura objDetalle in Detalles)
            {
                total = total + objDetalle.SubTotal();
            }

            if (this.AplicaIVA)
            {
                total = total * 1.21;
            }


            total = (total * FormaDePago.ObtenerRecargo()) + total;

            if (this.Cliente.AplicaDescuento && total > 1000)
            {
                total = total - 50;
            }

            return total;
        }

        private FormaDePago _formaDePago;

        public FormaDePago FormaDePago
        {
            get { return _formaDePago; }
            set { _formaDePago = value; }
        }


        private Cliente _cliente;

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }


        private List<DetalleFactura> detalleFacturas;
        public List<DetalleFactura> Detalles
        {
            get { return detalleFacturas; }
            set { detalleFacturas = value; }
        }

        public void AgregarProducto(Producto producto, int cantidad)
        {
            DetalleFactura objDetalle = new DetalleFactura();
            objDetalle.Cantidad = cantidad;
            objDetalle.Producto = producto;

            this.detalleFacturas.Add(objDetalle);
        }

        public Factura()
        {
            this.detalleFacturas = new List<DetalleFactura>();
        }
    }
}