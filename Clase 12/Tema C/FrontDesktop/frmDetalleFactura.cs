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
    public partial class frmDetalleFactura : Form
    {
        public frmDetalleFactura()
        {
            InitializeComponent();
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        private void frmDetalleFactura_Load(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = factura.Detalles;

            this.txtTotalFactura.Text = factura.TotalFactura().ToString();

        }
    }
}
