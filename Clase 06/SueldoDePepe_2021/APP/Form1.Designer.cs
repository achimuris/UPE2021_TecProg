
namespace APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnBonoPorResultadoVariable = new System.Windows.Forms.RadioButton();
            this.rbtnBonoPorResultadoFijo = new System.Windows.Forms.RadioButton();
            this.rbtnBonoPorResultadoSIN = new System.Windows.Forms.RadioButton();
            this.lblBonosPorResultados = new System.Windows.Forms.Label();
            this.cboxAplicaBonoPorPresentismo = new System.Windows.Forms.CheckBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular sueldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(181, 91);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 23);
            this.cmbCategorias.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria";
            // 
            // rbtnBonoPorResultadoVariable
            // 
            this.rbtnBonoPorResultadoVariable.AutoSize = true;
            this.rbtnBonoPorResultadoVariable.Location = new System.Drawing.Point(118, 167);
            this.rbtnBonoPorResultadoVariable.Name = "rbtnBonoPorResultadoVariable";
            this.rbtnBonoPorResultadoVariable.Size = new System.Drawing.Size(118, 19);
            this.rbtnBonoPorResultadoVariable.TabIndex = 3;
            this.rbtnBonoPorResultadoVariable.TabStop = true;
            this.rbtnBonoPorResultadoVariable.Text = "10% sobre el neto";
            this.rbtnBonoPorResultadoVariable.UseVisualStyleBackColor = true;
            // 
            // rbtnBonoPorResultadoFijo
            // 
            this.rbtnBonoPorResultadoFijo.AutoSize = true;
            this.rbtnBonoPorResultadoFijo.Location = new System.Drawing.Point(118, 192);
            this.rbtnBonoPorResultadoFijo.Name = "rbtnBonoPorResultadoFijo";
            this.rbtnBonoPorResultadoFijo.Size = new System.Drawing.Size(68, 19);
            this.rbtnBonoPorResultadoFijo.TabIndex = 4;
            this.rbtnBonoPorResultadoFijo.TabStop = true;
            this.rbtnBonoPorResultadoFijo.Text = "$80 fijos";
            this.rbtnBonoPorResultadoFijo.UseVisualStyleBackColor = true;
            // 
            // rbtnBonoPorResultadoSIN
            // 
            this.rbtnBonoPorResultadoSIN.AutoSize = true;
            this.rbtnBonoPorResultadoSIN.Location = new System.Drawing.Point(118, 217);
            this.rbtnBonoPorResultadoSIN.Name = "rbtnBonoPorResultadoSIN";
            this.rbtnBonoPorResultadoSIN.Size = new System.Drawing.Size(145, 19);
            this.rbtnBonoPorResultadoSIN.TabIndex = 5;
            this.rbtnBonoPorResultadoSIN.TabStop = true;
            this.rbtnBonoPorResultadoSIN.Text = "Sin bono por resultado";
            this.rbtnBonoPorResultadoSIN.UseVisualStyleBackColor = true;
            // 
            // lblBonosPorResultados
            // 
            this.lblBonosPorResultados.AutoSize = true;
            this.lblBonosPorResultados.Location = new System.Drawing.Point(91, 140);
            this.lblBonosPorResultados.Name = "lblBonosPorResultados";
            this.lblBonosPorResultados.Size = new System.Drawing.Size(121, 15);
            this.lblBonosPorResultados.TabIndex = 6;
            this.lblBonosPorResultados.Text = "Bonos por resultados:";
            // 
            // cboxAplicaBonoPorPresentismo
            // 
            this.cboxAplicaBonoPorPresentismo.AutoSize = true;
            this.cboxAplicaBonoPorPresentismo.Location = new System.Drawing.Point(479, 192);
            this.cboxAplicaBonoPorPresentismo.Name = "cboxAplicaBonoPorPresentismo";
            this.cboxAplicaBonoPorPresentismo.Size = new System.Drawing.Size(189, 19);
            this.cboxAplicaBonoPorPresentismo.TabIndex = 7;
            this.cboxAplicaBonoPorPresentismo.Text = "¿Aplica bono por presentismo?";
            this.cboxAplicaBonoPorPresentismo.UseVisualStyleBackColor = true;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(553, 94);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 23);
            this.txtNombreEmpleado.TabIndex = 8;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(463, 98);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(51, 15);
            this.lblNombreEmpleado.TabIndex = 9;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.cboxAplicaBonoPorPresentismo);
            this.Controls.Add(this.lblBonosPorResultados);
            this.Controls.Add(this.rbtnBonoPorResultadoSIN);
            this.Controls.Add(this.rbtnBonoPorResultadoFijo);
            this.Controls.Add(this.rbtnBonoPorResultadoVariable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnBonoPorResultadoVariable;
        private System.Windows.Forms.RadioButton rbtnBonoPorResultadoFijo;
        private System.Windows.Forms.RadioButton rbtnBonoPorResultadoSIN;
        private System.Windows.Forms.Label lblBonosPorResultados;
        private System.Windows.Forms.CheckBox cboxAplicaBonoPorPresentismo;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
    }
}

