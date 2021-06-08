using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Empresa
    {
        private string _razonSocial;

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        private string _cuil;

        public string CUIL
        {
            get { return _cuil; }
            set { _cuil = value; }
        }



        private List<Producto> productos;
        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }


        private List<FormaDePago> formas;

        public List<FormaDePago> MetodosDePagoAceptados
        {
            get { return formas; }
            set { formas = value; }
        }


        public Empresa()
        {
            this.CUIL = "456489789";
            this.RazonSocial = "Universidad Provincial de Ezeiza";

            /* Productos que tiene la empresa */
            Producto tornillo = new Producto("Tornillo", 200);
            Producto tuerca = new Producto("Tuerca", 12);

            this.productos = new List<Producto>();
            this.productos.Add(tornillo);
            this.productos.Add(tuerca);
            this.productos.Add(new Producto("Martillo", 600));


            this.formas = new List<FormaDePago>();

            TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito();
            TarjetaDeDebito tarjetaDeDebito = new TarjetaDeDebito();
            Efectivo efectivo = new Efectivo();

            formas.Add(tarjetaDeCredito);
            formas.Add(tarjetaDeDebito);
            formas.Add(efectivo);
        }
    }
}