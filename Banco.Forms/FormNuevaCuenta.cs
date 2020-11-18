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
    public partial class FormNuevaCuenta : Form
    {
        private BancoServicio banco;
        public FormNuevaCuenta(BancoServicio bancoServicio)
        {
            InitializeComponent();
            this.banco = bancoServicio;
            try
            {
                this.comboBox1.DataSource = banco.CuentaServicio.ClienteServicio.Clientes;
            }
            catch (SinClientesException ex)
            {
                MessageBox.Show(string.Format("ERROR.\n{0}.", ex.Message));
                this.Owner.Enabled = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)this.comboBox1.SelectedItem;

                this.banco.CuentaServicio.NuevaCuenta(cliente.Id, float.Parse(this.textBox1.Text), this.textBox2.Text);

                this.Owner.Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR.\n{0}.", ex.Message));
                this.Owner.Enabled = true;
                this.Close();
            }
        }
    }
}
