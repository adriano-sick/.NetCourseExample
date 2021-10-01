using Fabrica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TesteDeFabrica
    {
        [TestMethod]
        public void ChocolateCriouCorretamente()
        {
            var tipo = "Dark";
            var chocolate = new Chocolate();
            chocolate.PorcentagemDeAcucar = 30;
            chocolate.Tipo = tipo;

            var fabrica = new FabricaDeChocolate();
            var chocolateDaFabrica = fabrica.CriarChocolate(tipo);

            Assert.IsTrue(chocolate.Tipo == chocolateDaFabrica.Tipo);
        }

        [TestMethod]
        public void ChocolateNaoEhNulo()
        {
            var fabrica = new FabricaDeChocolate();
            var chocolateDaFabrica = fabrica.CriarChocolate("Dark");

            Assert.IsNotNull(chocolateDaFabrica);
        }
    }
}
