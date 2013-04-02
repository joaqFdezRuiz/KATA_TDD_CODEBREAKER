using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CodeBreakerTests
{
    public class JuegoTest
    {
        [TestFixture]
        public class Test_Juego_1 {
            CodeBreaker.Clases.IJuego SUT = new CodeBreaker.Clases.Juego("NRRI", "RRRN");
            private string resultado;

            [SetUp]
            public void Setup() {
                resultado = SUT.ObtenerResultado();
            }
            [Test]
            public void Test_Resultado_1() {
                Assert.AreEqual(resultado, "XX*");
            }
        }

        [TestFixture]
        public class Test_Juego_2
        {
            CodeBreaker.Clases.IJuego SUT = new CodeBreaker.Clases.Juego("RANI", "YNYI");
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado();
            }
            [Test]
            public void Test_Resultado_2()
            {
                Assert.AreEqual(resultado, "X*");
            }
        }

        [TestFixture]
        public class Test_Juego_3
        {
            CodeBreaker.Clases.IJuego SUT = new CodeBreaker.Clases.Juego("RANI", "RMVI");
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado();
            }
            [Test]
            public void Test_Resultado_3()
            {
                Assert.AreEqual(resultado, "XX");
            }
        }

        [TestFixture]
        public class Test_Juego_4
        {
            CodeBreaker.Clases.IJuego SUT = new CodeBreaker.Clases.Juego("NRRI", "RRVN");
            private string resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado();
            }
            [Test]
            public void Test_Resultado_4()
            {
                Assert.AreEqual(resultado, "X**");
            }
        }



        [TestFixture]
        public class Test_Cadena_Igual_Clave {
            CodeBreaker.Clases.IJuego SUT = new CodeBreaker.Clases.Juego("VMAR", "VMAR");
            private string resultado;

            [SetUp]
            public void Setup() {
                resultado = SUT.ObtenerResultado();
            }
            [Test]
            public void Test_Resultado_Cadena_Igual_Clave() {
                Assert.AreEqual(resultado, "XXXX");
            }
        }

    }
}
