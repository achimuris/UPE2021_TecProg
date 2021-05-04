using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Cliente
    {

        public const int  EdadValidaParaSerCliente = 18;

        public bool Alta(Entidades.Cliente pCliente)
        {
            DAL.Cliente objDAL = new DAL.Cliente();

            if (string.IsNullOrEmpty(pCliente.Apellido))
            {
                throw new Entidades.Excepciones.ExcepcionNegocioClienteSinApellido();
            }

            if (string.IsNullOrEmpty(pCliente.Nombre))
            {
                throw new Entidades.Excepciones.ExcepcionNegocioClienteSinNombre();
            }

            if ((DateTime.Now.Year - pCliente.FechaDeNacimiento.Year) < EdadValidaParaSerCliente)
            {
                throw new Entidades.Excepciones.ExcepcionNegocioClienteNoCumpleRequisitoDeEdad();
            }

            return objDAL.Alta(pCliente);
        }
    }
}
