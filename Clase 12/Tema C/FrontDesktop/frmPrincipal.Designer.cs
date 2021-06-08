
namespace FrontDesktop
{
    partial class frmPrincial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.cboxAplicaDescuentoCliente = new System.Windows.Forms.CheckBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.cboxProductos = new System.Windows.Forms.ComboBox();
            this.cboxMedioDePago = new System.Windows.Forms.ComboBox();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.cboxIVA = new System.Windows.Forms.CheckBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lboxDetalleDeVenta = new System.Windows.Forms.ListBox();
            this.txtCantidadDelProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 62);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(12, 87);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoCliente.TabIndex = 1;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(74, 62);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(74, 88);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCliente.TabIndex = 3;
            // 
            // cboxAplicaDescuentoCliente
            // 
            this.cboxAplicaDescuentoCliente.AutoSize = true;
            this.cboxAplicaDescuentoCliente.Location = new System.Drawing.Point(15, 114);
            this.cboxAplicaDescuentoCliente.Name = "cboxAplicaDescuentoCliente";
            this.cboxAplicaDescuentoCliente.Size = new System.Drawing.Size(162, 17);
            this.cboxAplicaDescuentoCliente.TabIndex = 4;
            this.cboxAplicaDescuentoCliente.Text = "¿Aplica descuento especial?";
            this.cboxAplicaDescuentoCliente.UseVisualStyleBackColor = true;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(399, 72);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(58, 13);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Productos:";
            // 
            // cboxProductos
            // 
            this.cboxProductos.FormattingEnabled = true;
            this.cboxProductos.Location = new System.Drawing.Point(483, 69);
            this.cboxProductos.Name = "cboxProductos";
            this.cboxProductos.Size = new System.Drawing.Size(121, 21);
            this.cboxProductos.TabIndex = 6;
            // 
            // cboxMedioDePago
            // 
            this.cboxMedioDePago.FormattingEnabled = true;
            this.cboxMedioDePago.Location = new System.Drawing.Point(483, 112);
            this.cboxMedioDePago.Name = "cboxMedioDePago";
            this.cboxMedioDePago.Size = new System.Drawing.Size(121, 21);
            this.cboxMedioDePago.TabIndex = 7;
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.AutoSize = true;
            this.lblMedioDePago.Location = new System.Drawing.Point(399, 115);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(78, 13);
            this.lblMedioDePago.TabIndex = 8;
            this.lblMedioDePago.Text = "Forma de pago";
            // 
            // cboxIVA
            // 
            this.cboxIVA.AutoSize = true;
            this.cboxIVA.Location = new System.Drawing.Point(15, 156);
            this.cboxIVA.Name = "cboxIVA";
            this.cboxIVA.Size = new System.Drawing.Size(87, 17);
            this.cboxIVA.TabIndex = 9;
            this.cboxIVA.Text = "¿Aplica IVA?";
            this.cboxIVA.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(483, 156);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(106, 23);
            this.btnAgregarProducto.TabIndex = 10;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(662, 115);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lboxDetalleDeVenta
            // 
            this.lboxDetalleDeVenta.FormattingEnabled = true;
            this.lboxDetalleDeVenta.Location = new System.Drawing.Point(389, 201);
            this.lboxDetalleDeVenta.Name = "lboxDetalleDeVenta";
            this.lboxDetalleDeVenta.Size = new System.Drawing.Size(348, 95);
            this.lboxDetalleDeVenta.TabIndex = 12;
            // 
            // txtCantidadDelProducto
            // 
            this.txtCantidadDelProducto.Location = new System.Drawing.Point(669, 72);
            this.txtCantidadDelProducto.Name = "txtCantidadDelProducto";
            this.txtCantidadDelProducto.Size = new System.Drawing.Size(68, 20);
            this.txtCantidadDelProducto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad";
            // 
            // frmPrincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadDelProducto);
            this.Controls.Add(this.lboxDetalleDeVenta);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.cboxIVA);
            this.Controls.Add(this.lblMedioDePago);
            this.Controls.Add(this.cboxMedioDePago);
            this.Controls.Add(this.cboxProductos);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cboxAplicaDescuentoCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Name = "frmPrincial";
            this.Text = "Sistema de venta - Minorista - Parcial tema C";
            this.Load += new System.EventHandler(this.frmPrincial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.CheckBox cboxAplicaDescuentoCliente;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ComboBox cboxProductos;
        private System.Windows.Forms.ComboBox cboxMedioDePago;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.CheckBox cboxIVA;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ListBox lboxDetalleDeVenta;
        private System.Windows.Forms.TextBox txtCantidadDelProducto;
        private System.Windows.Forms.Label label1;
    }
}

