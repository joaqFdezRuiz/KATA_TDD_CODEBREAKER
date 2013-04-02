using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CodeBreakerTests
{
    public class CadenaUsuarioTest
    {
        [TestFixture]
        public class Test_Cadena_Usuario {
            CodeBreaker.Clases.ICadenaUsuario SUT = new CodeBreaker.Clases.CadenaUsuario();
            private string resultado;

            [SetUp]
            public void Setup() {
                resultado = SUT.ObtenerCadenaUsuario("aaAA");
            }
            [Test]
            public void Test_Obtener_Cadena_Usuario() {
                Assert.AreEqual(resultado, "AAAA");
            }
        }
    }
}
