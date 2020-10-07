using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AgregarBalanceUserControl : UserControl
    {
        private VentanaPrincipal ventanaPrincipal;

        public AgregarBalanceUserControl(VentanaPrincipal ventanaPrincipal)
        {
            InitializeComponent();

            this.ventanaPrincipal = ventanaPrincipal;
        }

        private void buttonIrAExtraerMonto_Click(object sender, EventArgs e)
        {
            this.ventanaPrincipal.IrAExtraerMonto();
        }
    }
}
