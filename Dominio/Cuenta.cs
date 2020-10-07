using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuenta
    {
        public int Balance { get; set; }

        public void Extraer(int montoAExtraer)
        {
            if (montoAExtraer > this.Balance)
            {
                throw new BalanceInsuficienteException();
            }

            this.Balance -= montoAExtraer;
        }
    }
}
