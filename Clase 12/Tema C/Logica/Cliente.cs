using System;

namespace Logica
{
    public class Cliente
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private bool _aplicaDescuento;
        public bool AplicaDescuento
        {
            get { return _aplicaDescuento; }
            set { _aplicaDescuento = value; }
        }
    }
}
