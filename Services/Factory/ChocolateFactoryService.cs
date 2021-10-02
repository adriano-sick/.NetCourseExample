using Entities;
using Entities.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Factory
{
    public class ChocolateFactoryService
    {
        private Chocolate chocolateEmProducao;

        public ChocolateFactoryService()
        {
            chocolateEmProducao = new Chocolate()
            {
                Temperatura = 50,
                Temperado = false
            };
        }
        public Chocolate FabricarChocolate()
        {
            TemperarChocolate();
            return chocolateEmProducao;
        }

        private void TemperarChocolate()
        {
            var chocolate = new Chocolate();
            
            Thread medeTemperatura = new Thread(new ThreadStart(MedeTemperatura));
            Thread mexeChocolate = new Thread(new ThreadStart(MexeChocolate));

            medeTemperatura.Start();
            mexeChocolate.Start();

            //

            medeTemperatura.Join();
            chocolateEmProducao.Temperado = true;
            mexeChocolate.Join();
            
        }

        private void MexeChocolate()
        {
            while (true)
            {
                chocolateEmProducao.Temperatura -= 1;
                Thread.Sleep(300);
            }
            
        }

        private void MedeTemperatura()
        {
            do
            {
                Thread.Sleep(1000);
                if (chocolateEmProducao.Temperado) break;
            }
            while (chocolateEmProducao.Temperatura>28);

        }

        public Embalagem FabricarEmbalagem()
        {
            return new Embalagem();
        }

        public Produto MontarProduto()
        {
            return new Produto();
        }

    }
}
