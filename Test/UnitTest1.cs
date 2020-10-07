using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(BalanceInsuficienteException))]
        public void SeExtraeUnMontoMayorAlBalance()
        {
            Cuenta cuenta = new Cuenta() { Balance = 100 };

            cuenta.Extraer(101);
        }

        [TestMethod]
        [DataRow(100, 50, 50)]
        [DataRow(100, 70, 30)]
        public void SeExtraeUnMontoMenorAlBalance(int balanceInicial, int balanceFinal, int monto)
        {
            Cuenta cuenta = new Cuenta() { Balance = balanceInicial };

            cuenta.Extraer(monto);

            Assert.AreEqual(balanceFinal, cuenta.Balance);
        }
    }
}
