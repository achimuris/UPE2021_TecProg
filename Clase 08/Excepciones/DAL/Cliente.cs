using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Cliente
    {
        public bool Alta(Entidades.Cliente pCliente)
        {
            SqlParameter[] parametros = new SqlParameter[3];

            Conexion objConexion = new Conexion();


            parametros[0] = objConexion.crearParametro("@pNombre", pCliente.Nombre);
            parametros[1] = objConexion.crearParametro("@pApellido", pCliente.Apellido);
            parametros[2] = objConexion.crearParametro("@pFechaNacimiento", pCliente.FechaDeNacimiento);




            return (objConexion.EscribirPorStoreProcedure("sp_crear_cliente", parametros) > 0); 
        }
    }
}
