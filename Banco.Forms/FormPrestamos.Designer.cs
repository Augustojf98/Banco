namespace Banco.Forms
{
    partial class FormPrestamos
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
            this.components = new System.ComponentModel.Container();
            this.listBoxTipoPrestamos = new System.Windows.Forms.ListBox();
            this.prestamoTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCuotaInteres = new System.Windows.Forms.TextBox();
            this.textBoxCuotaTotal = new System.Windows.Forms.TextBox();
            this.textBoxCuotaCapital = new System.Windows.Forms.TextBox();
            this.buttonSimular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTNA = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.textBoxPlazo = new System.Windows.Forms.TextBox();
            this.textBoxLinea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComisionTotal = new System.Windows.Forms.TextBox();
            this.listBoxPrestamos = new System.Windows.Forms.ListBox();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoTipoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTipoPrestamos
            // 
            this.listBoxTipoPrestamos.DataSource = this.prestamoTipoBindingSource;
            this.listBoxTipoPrestamos.FormattingEnabled = true;
            this.listBoxTipoPrestamos.ItemHeight = 16;
            this.listBoxTipoPrestamos.Location = new System.Drawing.Point(3, 94);
            this.listBoxTipoPrestamos.Name = "listBoxTipoPrestamos";
            this.listBoxTipoPrestamos.Size = new System.Drawing.Size(237, 452);
            this.listBoxTipoPrestamos.TabIndex = 0;
            // 
            // prestamoTipoBindingSource
            // 
            this.prestamoTipoBindingSource.DataSource = typeof(Banco.Entidades.PrestamoTipo);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAlta);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCuotaInteres);
            this.panel1.Controls.Add(this.textBoxCuotaTotal);
            this.panel1.Controls.Add(this.textBoxCuotaCapital);
            this.panel1.Controls.Add(this.buttonSimular);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxTNA);
            this.panel1.Controls.Add(this.textBoxMonto);
            this.panel1.Controls.Add(this.textBoxPlazo);
            this.panel1.Controls.Add(this.textBoxLinea);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBoxTipoPrestamos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 551);
            this.panel1.TabIndex = 1;
            // 
            // buttonAlta
            // 
            this.buttonAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlta.Location = new System.Drawing.Point(298, 489);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(235, 40);
            this.buttonAlta.TabIndex = 22;
            this.buttonAlta.Text = "ALTA";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cuota (Interés): $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "CUOTA TOTAL: $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cuota (Capital): $";
            // 
            // textBoxCuotaInteres
            // 
            this.textBoxCuotaInteres.Enabled = false;
            this.textBoxCuotaInteres.Location = new System.Drawing.Point(411, 380);
            this.textBoxCuotaInteres.Name = "textBoxCuotaInteres";
            this.textBoxCuotaInteres.Size = new System.Drawing.Size(165, 22);
            this.textBoxCuotaInteres.TabIndex = 18;
            // 
            // textBoxCuotaTotal
            // 
            this.textBoxCuotaTotal.Enabled = false;
            this.textBoxCuotaTotal.Location = new System.Drawing.Point(411, 423);
            this.textBoxCuotaTotal.Name = "textBoxCuotaTotal";
            this.textBoxCuotaTotal.Size = new System.Drawing.Size(165, 22);
            this.textBoxCuotaTotal.TabIndex = 17;
            // 
            // textBoxCuotaCapital
            // 
            this.textBoxCuotaCapital.Enabled = false;
            this.textBoxCuotaCapital.Location = new System.Drawing.Point(411, 337);
            this.textBoxCuotaCapital.Name = "textBoxCuotaCapital";
            this.textBoxCuotaCapital.Size = new System.Drawing.Size(165, 22);
            this.textBoxCuotaCapital.TabIndex = 16;
            // 
            // buttonSimular
            // 
            this.buttonSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimular.Location = new System.Drawing.Point(298, 276);
            this.buttonSimular.Name = "buttonSimular";
            this.buttonSimular.Size = new System.Drawing.Size(235, 40);
            this.buttonSimular.TabIndex = 15;
            this.buttonSimular.Text = "Simular";
            this.buttonSimular.UseVisualStyleBackColor = true;
            this.buttonSimular.Click += new System.EventHandler(this.buttonSimular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "TNA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Plazo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Línea:";
            // 
            // textBoxTNA
            // 
            this.textBoxTNA.Enabled = false;
            this.textBoxTNA.Location = new System.Drawing.Point(353, 137);
            this.textBoxTNA.Name = "textBoxTNA";
            this.textBoxTNA.Size = new System.Drawing.Size(223, 22);
            this.textBoxTNA.TabIndex = 10;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(353, 180);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(223, 22);
            this.textBoxMonto.TabIndex = 9;
            // 
            // textBoxPlazo
            // 
            this.textBoxPlazo.Location = new System.Drawing.Point(353, 223);
            this.textBoxPlazo.Name = "textBoxPlazo";
            this.textBoxPlazo.Size = new System.Drawing.Size(223, 22);
            this.textBoxPlazo.TabIndex = 8;
            // 
            // textBoxLinea
            // 
            this.textBoxLinea.Enabled = false;
            this.textBoxLinea.Location = new System.Drawing.Point(353, 94);
            this.textBoxLinea.Name = "textBoxLinea";
            this.textBoxLinea.Size = new System.Drawing.Size(223, 22);
            this.textBoxLinea.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "TIPOS PRÉSTAMO:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxComisionTotal);
            this.panel2.Controls.Add(this.listBoxPrestamos);
            this.panel2.Location = new System.Drawing.Point(599, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 551);
            this.panel2.TabIndex = 2;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(7, 35);
            this.textBoxCliente.MaximumSize = new System.Drawing.Size(500, 21);
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(500, 21);
            this.textBoxCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRÉSTAMOS AL CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "COMISIÓN TOTAL: $";
            // 
            // textBoxComisionTotal
            // 
            this.textBoxComisionTotal.Enabled = false;
            this.textBoxComisionTotal.Location = new System.Drawing.Point(226, 496);
            this.textBoxComisionTotal.Name = "textBoxComisionTotal";
            this.textBoxComisionTotal.Size = new System.Drawing.Size(178, 22);
            this.textBoxComisionTotal.TabIndex = 2;
            // 
            // listBoxPrestamos
            // 
            this.listBoxPrestamos.DataSource = this.prestamoBindingSource;
            this.listBoxPrestamos.FormattingEnabled = true;
            this.listBoxPrestamos.ItemHeight = 16;
            this.listBoxPrestamos.Location = new System.Drawing.Point(3, 94);
            this.listBoxPrestamos.Name = "listBoxPrestamos";
            this.listBoxPrestamos.Size = new System.Drawing.Size(668, 372);
            this.listBoxPrestamos.TabIndex = 1;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(Banco.Entidades.Prestamo);
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1287, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.prestamoTipoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTipoPrestamos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComisionTotal;
        private System.Windows.Forms.ListBox listBoxPrestamos;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCuotaInteres;
        private System.Windows.Forms.TextBox textBoxCuotaTotal;
        private System.Windows.Forms.TextBox textBoxCuotaCapital;
        private System.Windows.Forms.Button buttonSimular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTNA;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxPlazo;
        private System.Windows.Forms.TextBox textBoxLinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource prestamoTipoBindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
    }
}