using Fabrica;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {

        FabricaDeChocolate fabrica;

        [SetUp]
        public void Setup()
        {
            fabrica = new FabricaDeChocolate();
        }

        [Test]
        [TestCase("Dark")]
        [TestCase("white")]
        [TestCase("millk")]
        public void ChocolateTemTipoCerto(string tipo)
        {
            var chocolateDaFabrica = fabrica.CriarChocolate(tipo);
            var chocolate = new Chocolate()
            {
                Tipo = tipo,
                PorcentagemDeAcucar = 30
            };

            
            Assert.IsTrue(chocolate.Tipo == chocolateDaFabrica.Tipo);
        }
    }
}