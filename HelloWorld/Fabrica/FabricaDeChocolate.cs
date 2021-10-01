
namespace Fabrica
{
    public class FabricaDeChocolate
    {
        public Chocolate CriarChocolate(string tipo)
        {
            var chocolate = new Chocolate();

            chocolate.Tipo = tipo;
            chocolate.PorcentagemDeAcucar = 30.0f;

            return chocolate;
        }


    }

}
