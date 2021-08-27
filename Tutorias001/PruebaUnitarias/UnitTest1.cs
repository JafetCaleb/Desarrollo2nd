using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaPresentacion;

namespace PruebaUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            Login aux = new Login();
            bool prueba = aux.logins("Cata","cata");
            Assert.AreEqual(prueba, true);
        }
    }
}
