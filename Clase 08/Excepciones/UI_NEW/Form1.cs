using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_NEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
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
            catch (Entidades.Excepciones.ExcepcionNegocioClienteNoCumpleRequisitoDeEdad ex1)
            {
                MessageBox.Show(ex1.Descripcion + " y su fecha de nacimiento es: " + dtpFechaNacimiento.Value);

            }
            catch (Entidades.Excepciones.ExcepcionDeNegocio ex1)
            {
                MessageBox.Show(ex1.Descripcion);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }



        }
    }
}
