using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Entidades.Cliente objEntidad = new Entidades.Cliente();

            objEntidad.Apellido = txtApellido.Text;
            objEntidad.Nombre = txtNombre.Text;
            objEntidad.FechaDeNacimiento = dtpFechaNacimiento.Value;


            BLL.Cliente objClienteNegocio = new BLL.Cliente();

            if (objClienteNegocio.Alta(objEntidad))
            {
                MessageBox.Show("¡Cliente creado con exito!");
            }


        }
    }
}
