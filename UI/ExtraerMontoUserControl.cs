using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class ExtraerMontoUserControl : UserControl
    {
        private Cuenta cuenta = new Cuenta() { Balance = 1000 };

        public ExtraerMontoUserControl()
        {
            InitializeComponent();

            this.MostrarBalanceActual();
        }

        private void textBoxMontoAExtraer_KeyDown(object sender, KeyEventArgs e)
        {
            // this.labelBalanceActual.Text = $"Balance Actual: ${this.textBoxMontoAExtraer.Text}";
        }

        private void buttonExtraer_Click(object sender, EventArgs e)
        {
            int balanceInicial = this.cuenta.Balance;
            try
            {
                int montoAExtraer = int.Parse(this.textBoxMontoAExtraer.Text);

                cuenta.Extraer(montoAExtraer);

                int balanceFinal = this.cuenta.Balance;

                MostrarBalanceActual();
                MostrarExtraccion(balanceInicial - balanceFinal);
            }
            catch (BalanceInsuficienteException)
            {
                //MessageBox.Show("El monto ingresado es superior al balance actual");
                MessageBox.Show("El monto excede al balance actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostrarExtraccion(int montoExtraido)
        {
            this.textBoxDetalleExtraccion.Text = $"Se extrajo ${montoExtraido} el ${this.dateTimePicker1.Value}";
        }

        private void MostrarBalanceActual()
        {
            this.labelBalanceActual.Text = $"Balance Actual: ${this.cuenta.Balance}";
        }
    }
}
