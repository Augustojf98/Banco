using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Entidades;
using Banco.Negocio;

namespace Banco.Forms
{
    public partial class FormPrestamos : Form
    {
        private BancoServicio banco;
        private Cliente cliente;

        public FormPrestamos(BancoServicio bancoServicio, Cliente clienteSeleccionado)
        {
            InitializeComponent();
            this.banco = bancoServicio;
            this.cliente = clienteSeleccionado;

            this.listBoxPrestamos.DataSource = banco.PrestamoServicio.TraerPrestamos().Where(w => w.IdCliente == cliente.Id).ToList();
            this.listBoxTipoPrestamos.DataSource = banco.PrestamoServicio.TraerTiposPrestamo();
            this.listBoxTipoPrestamos.SelectedIndexChanged += ListBoxTipoPrestamos_SelectedIndexChanged;

            this.textBoxCliente.Text = string.Format("{0}, {1}", cliente.Apellido, cliente.Nombre);
        }

        private void ListBoxTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCuotaCapital.Text = "";
            textBoxCuotaInteres.Text = "";
            textBoxCuotaTotal.Text = "";
            this.textBoxLinea.Text = (this.listBoxTipoPrestamos.SelectedItem as PrestamoTipo).Linea;
            this.textBoxTNA.Text = string.Format("{0} %", (this.listBoxTipoPrestamos.SelectedItem as PrestamoTipo).TNA);
        }

        private void buttonSimular_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxMonto.Text != "" || textBoxPlazo.Text != "" || textBoxLinea.Text != "" || textBoxTNA.Text != "")
                {
                    Prestamo prestamo = new Prestamo();
                    prestamo.Linea = (listBoxTipoPrestamos.SelectedItem as PrestamoTipo).Linea;
                    prestamo.TNA = (listBoxTipoPrestamos.SelectedItem as PrestamoTipo).TNA;
                    prestamo.Monto = double.Parse(textBoxMonto.Text);
                    prestamo.Plazo = int.Parse(textBoxPlazo.Text);

                    textBoxCuotaCapital.Text = prestamo.CuotaCapital.ToString();
                    textBoxCuotaInteres.Text = prestamo.CuotaInteres.ToString();
                    textBoxCuotaTotal.Text = prestamo.Cuota.ToString();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxCuotaTotal.Text != "0" && textBoxCuotaTotal.Text != "")
                {
                    Prestamo prestamo = new Prestamo();
                    prestamo.Linea = (listBoxTipoPrestamos.SelectedItem as PrestamoTipo).Linea;
                    prestamo.TNA = (listBoxTipoPrestamos.SelectedItem as PrestamoTipo).TNA;
                    prestamo.Monto = double.Parse(textBoxMonto.Text);
                    prestamo.Plazo = int.Parse(textBoxPlazo.Text);
                    prestamo.IdCliente = cliente.Id;

                    this.banco.PrestamoServicio.CargarPrestamo(prestamo);
                }
                else
                {
                    MessageBox.Show("Debe realizar una simulación correcta previamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
