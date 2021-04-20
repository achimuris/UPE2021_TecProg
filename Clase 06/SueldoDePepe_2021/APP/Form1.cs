using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected Empresa objEmpresa = new Empresa();
        private void button1_Click(object sender, EventArgs e)
        {

            Empleado objEmpleado = new Empleado();

            objEmpleado.Nombre = txtNombreEmpleado.Text;

            Categoria objCategoria = (Categoria)cmbCategorias.SelectedValue;

            objEmpleado.Categoria = objCategoria;

            objEmpleado.BonoPorResultado = DevolverBonoPorResultado();

            objEmpleado.BonoPorPresentismo = DevolverBonoPorPresentismo();


            MessageBox.Show(objEmpresa.CalcularSueldo(objEmpleado));
        }

        private BonoPorPresentismo DevolverBonoPorPresentismo()
        {
            if (cboxAplicaBonoPorPresentismo.Checked)
            {
                return new BonoPorPresentismo();
            }
            else
            {
                return null;
            }
        }

        private BonoPorResultado DevolverBonoPorResultado()
        {
            BonoPorResultado objBonoPorResultado = null;

            if (rbtnBonoPorResultadoSIN.Checked)
            {
                //No tiene bono por resultado
                objBonoPorResultado = null;
            }


            if (rbtnBonoPorResultadoFijo.Checked)
            {
                objBonoPorResultado = new BonoPorResultadoFijo();
            }

            if (rbtnBonoPorResultadoVariable.Checked)
            {
                objBonoPorResultado = new BonoPorResultadoVariable();
            }
            

            return objBonoPorResultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            objEmpresa.RazonSocial = "Fulanito S.A.";

            objEmpresa.CUIL = "20-123456789-7";



            cmbCategorias.DataSource = objEmpresa.CategoriasDisponibles();

            cmbCategorias.DisplayMember = "Nombre";

        }
    }
}
