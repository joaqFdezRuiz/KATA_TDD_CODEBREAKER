using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodeBreaker;

namespace CodeBreakerTests
{
    public class ClaveMalignoTest
    {
        [TestFixture]
        public class Test_Para_Generar_Longitud_Clave
        {
            CodeBreaker.Clases.IClaveMaligno SUT = new CodeBreaker.Clases.ClaveMaligno();
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.GenerarClave();
            }

            [Test]
            public void Test_Longitud_Clave()
            {
                Assert.AreEqual(resultado.Length, CodeBreaker.Clases.ClaveMaligno.LONGITUD_CODIGO);
            }
        }

        [TestFixture]
        public class Test_Para_Generar_Valores_Clave {
            CodeBreaker.Clases.IClaveMaligno SUT = new CodeBreaker.Clases.ClaveMaligno();
            private string resultado;

            [SetUp]
            public void Setup() {
                resultado = SUT.GenerarClave();
            }

            [Test]
            public void Test_Valores_Clave() {
                for (int i = 0; i < resultado.Length; i++)
                {
                    Assert.Contains(resultado[i].ToString(), CodeBreaker.Clases.ClaveMaligno.CARACTERES_VALIDOS);
                }
            }
        }
    }
}
