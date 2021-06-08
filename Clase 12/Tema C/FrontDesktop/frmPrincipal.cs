using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;


namespace FrontDesktop
{
    public partial class frmPrincial : Form
    {
        public frmPrincial()
        {
            InitializeComponent();
        }

        Empresa objEmpresa = new Empresa();
        Factura objFactura = new Factura();

        private void frmPrincial_Load(object sender, EventArgs e)
        {
            this.cboxIVA.Checked = true;
            this.cboxProductos.DataSource = objEmpresa.Productos;
            this.cboxProductos.DisplayMember = "Nombre";

            this.cboxMedioDePago.DataSource = objEmpresa.MetodosDePagoAceptados;
            this.cboxMedioDePago.DisplayMember = "Nombre";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto objProductoDelFormulario = (Producto) cboxProductos.SelectedItem;
            int cantidad =  int.Parse(txtCantidadDelProducto.Text);


            objFactura.AgregarProducto(objProductoDelFormulario, cantidad);

            CargarLista();
        }

        private void CargarLista()
        {
            lboxDetalleDeVenta.DataSource = null;

            lboxDetalleDeVenta.DataSource = objFactura.Detalles;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FormaDePago objFormaDePago = (FormaDePago)cboxMedioDePago.SelectedItem;

            Cliente objCliente = new Cliente();
            objCliente.Nombre = txtNombreCliente.Text;
            objCliente.Apellido = txtApellidoCliente.Text;
            objCliente.AplicaDescuento = cboxAplicaDescuentoCliente.Checked;

            objFactura.Cliente = objCliente;
            objFactura.FormaDePago = objFormaDePago;

            objFactura.AplicaIVA = cboxIVA.Checked;

            objFactura.Fecha = DateTime.Now;
            objFactura.Numero = "12";

            //MessageBox.Show("El total de la factura es: " + objFactura.TotalFactura());

            frmDetalleFactura otroFormulario = new frmDetalleFactura();
            otroFormulario.Factura = objFactura;
            otroFormulario.ShowDialog();
            

        }
    }
}
