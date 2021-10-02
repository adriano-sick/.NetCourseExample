using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ChocolateService
    {
        public List<Chocolate> GetChocolates()
        {
            try
            {
                var lista = new List<Chocolate>();
                lista.Add(null);
                return lista;

            }
            catch(Exception e)
            {
                return new();
            }
            
        }

        public Chocolate GetChocolate(string id)
        {
            return null;
        }
    }
}
