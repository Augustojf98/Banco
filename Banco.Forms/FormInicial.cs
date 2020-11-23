using System;
using Banco.Entidades;
using Banco.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Forms
{
    public partial class FormInicial : Form
    {
        private BancoServicio bancoServicio;
        private int cantidadCuentas;

        public FormInicial()
        {
            InitializeComponent();
            bancoServicio = new BancoServicio();
            this.Text = "Banco Hipotecario";
            this.dataGridView1.DataSource = bancoServicio.CuentaServicio.ClienteServicio.TraerClientes();
            this.dataGridView1.ReadOnly = true;
            this.dataGridView2.DataSource = bancoServicio.CuentaServicio.TraerCuentas();
            this.dataGridView2.CellValueChanged += DataGridView2_CellValueChanged;
        }

        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Cuenta cuenta = new Cuenta();

            cuenta.NroCuenta = (int)this.dataGridView2.Rows[e.RowIndex].Cells[1].Value;
            cuenta.Saldo = (float)this.dataGridView2.Rows[e.RowIndex].Cells[2].Value;

            this.bancoServicio.CuentaServicio.EditarSaldo(cuenta.NroCuenta, cuenta.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;
            this.dataGridView1.DataSource = bancoServicio.CuentaServicio.ClienteServicio.TraerClientes();
            this.dataGridView2.DataSource = bancoServicio.CuentaServicio.TraerCuentas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Cuenta cuenta in (List<Cuenta>)dataGridView2.DataSource)
            {
                this.bancoServicio.CuentaServicio.EditarSaldo(cuenta.NroCuenta, cuenta.Saldo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNuevaCuenta formNuevaCuenta = new FormNuevaCuenta(bancoServicio);
            formNuevaCuenta.Owner = this;
            formNuevaCuenta.Show();
            this.Enabled = false;
            cantidadCuentas = this.bancoServicio.CuentaServicio.TraerCuentas().Count;
            formNuevaCuenta.FormClosed += FormNuevaCuenta_FormClosed;
        }

        private void FormNuevaCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = this.bancoServicio.CuentaServicio.Cuentas;
            if(this.cantidadCuentas < this.bancoServicio.CuentaServicio.Cuentas.Count)
                MessageBox.Show("La cuenta se ha generado correctamente.\nPara ver los nuevos números de cuenta, debe refrescar la lista.");
        }
    }
}
