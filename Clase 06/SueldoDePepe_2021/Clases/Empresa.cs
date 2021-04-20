using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
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

        private List<Categoria> _categorias = new List<Categoria>();

        protected List<Categoria> Categorias
        {
            get { return _categorias; }
            set { _categorias = value; }
        }

        public List<Categoria> CategoriasDisponibles()
        {
            Cadete objCadete = new Cadete();
            Gerente objGerente = new Gerente();

            this.Categorias.Add(objCadete);
            this.Categorias.Add(objGerente);

            return this.Categorias;
        }



        private List<Empleado> _empleados = new List<Empleado>();

        public List<Empleado> Empleados
        {
            get { return _empleados; }
            set { _empleados = value; }
        }

        /// <summary>
        /// CalcularSueldo(Empleado objEmpleado)
        /// sueldoFinal =  empleado.Categoria.SueldoNeto()
        /// si tiene bono por resultado
        /// sueldoFinal = sueldoFinal  + objEmpleado.BonoPorResultado.DevolverBono(empleado.Categoria)
        /// Si tiene bono por presentismo
        /// sueldoFinal = sueldoFinal + objEmpleado.BonoPorPresentismo.DevolverBono(objEmpleado.CantidadDeAusentes)
        /// </summary>
        /// <param name="pEmpleado"></param>
        /// <returns>sueldoFinal</returns>
        public string CalcularSueldo(Empleado pEmpleado)
        {
            float sueldoFinal = 0;
            string liquidacion = string.Empty;

            sueldoFinal = pEmpleado.Categoria.SueldoNeto();

            liquidacion = "Liquidación del empleado " + pEmpleado.Nombre;
            liquidacion += "\nEl sueldo neto = " + pEmpleado.Categoria.SueldoNeto();

            if (pEmpleado.BonoPorResultado != null)
            {
                liquidacion += "\nTiene bonoPorResultado: %" + pEmpleado.BonoPorResultado.DevolverBono(pEmpleado.Categoria);
                sueldoFinal += pEmpleado.BonoPorResultado.DevolverBono(pEmpleado.Categoria);
            }
            else
            {
                liquidacion += "\nNO Tiene bonoPorResultado: $0";
            }

            if (pEmpleado.BonoPorPresentismo != null)
            {
                sueldoFinal += pEmpleado.BonoPorPresentismo.DevolverBono(pEmpleado.CantidadDeAusentes);
                liquidacion += "\nTiene bono por presentismo y le corresponde un total de: $" + pEmpleado.BonoPorPresentismo.DevolverBono(pEmpleado.CantidadDeAusentes);


            }
            else
            {
                liquidacion += "\nNO Tiene bono por Presentismo: $0";
            }


            return liquidacion;
        }

        /// <summary>
        /// Le cambia la categoria al empleado por la informada en el parametro
        /// </summary>
        /// <param name="pEmpleado"></param>
        /// <param name="pCategoria"></param>
        public void CambiarCategoriaDelEmpleado(Empleado pEmpleado, Categoria pCategoria)
        {
            pEmpleado.Categoria = pCategoria;
        }

        /// <summary>
        /// Se encarga de modificar la cantidad de ausentes correspondiente a un empleado en particular
        /// </summary>
        /// <param name="pEmpleado"></param>
        /// <param name="pCantidadDeAusentes"></param>
        public void CargarCantidadDeAusentes(Empleado pEmpleado, int pCantidadDeAusentes)
        {
            pEmpleado.CantidadDeAusentes = pCantidadDeAusentes;
        }

    }
}
