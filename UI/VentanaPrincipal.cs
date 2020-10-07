using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();

            this.panelPrincipal.Controls.Clear();
            this.panelPrincipal.Controls.Add(new AgregarBalanceUserControl(this));
        }

        public void IrAExtraerMonto()
        {
            this.panelPrincipal.Controls.Clear();
            this.panelPrincipal.Controls.Add(new ExtraerMontoUserControl());
        }
    }
}
