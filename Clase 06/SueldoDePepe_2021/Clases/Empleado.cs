using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Empleado
    {

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private Categoria _categoria;

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private int _cantidadDeAusentes;

        public int CantidadDeAusentes
        {
            get { return _cantidadDeAusentes; }
            set { _cantidadDeAusentes = value; }
        }

        private BonoPorPresentismo _bonoPorPresentismo;

        public BonoPorPresentismo BonoPorPresentismo
        {
            get { return _bonoPorPresentismo; }
            set { _bonoPorPresentismo = value; }
        }

        private BonoPorResultado _bonoPorResultado;

        public BonoPorResultado BonoPorResultado
        {
            get { return _bonoPorResultado; }
            set { _bonoPorResultado = value; }
        }


    }
}
