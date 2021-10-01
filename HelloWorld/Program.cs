using Fabrica;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabrica = new FabricaDeChocolate();
            var chocolate1 = fabrica.CriarChocolate("Dark");
            var chocolate2 = fabrica.CriarChocolate("White");
            var chocolate3 = fabrica.CriarChocolate("Milk");
            var chocolate4 = fabrica.CriarChocolate("Truffle");

            var chocolates = new List<Chocolate>();
            Chocolate[] arrayDeChocolates = { chocolate2, chocolate3, chocolate4 };

            chocolates.Add(chocolate1);
            chocolates.AddRange(arrayDeChocolates);

            var chocolatesTipoPequeno = chocolates.
                                                Where(chocolate => chocolate.Tipo.Length <= 4).ToList();

            foreach (var item in chocolatesTipoPequeno)
            {
                Console.WriteLine(item.Tipo);
            }
        }
    }

}
