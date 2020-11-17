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
        public FormInicial()
        {
            InitializeComponent();
            bancoServicio = new BancoServicio();
            this.Text = "Banco Hipotecario";
            this.dataGridView1.DataSource = bancoServicio.CuentaServicio.ClienteServicio.TraerClientes();
            this.dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = bancoServicio.CuentaServicio.ClienteServicio.TraerClientes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
