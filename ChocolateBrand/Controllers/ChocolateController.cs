using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using Services.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChocolateBrand.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChocolateController : ControllerBase
    {
        private ChocolateService _chocolateService;

        public ChocolateController()
        {
            _chocolateService = new ChocolateService();
        }

        [HttpGet]
        public List<Chocolate> Get()
        {
            var t = ChocolateStoreService.Seguimento;            

            try
            {
                var listaDeChocolates = _chocolateService.GetChocolates();
                if (listaDeChocolates?[0]?.OrigemCacau == "Hawaii")
                {
                    return listaDeChocolates.Take(1).ToList();
                }
                return listaDeChocolates;
            }
            catch(Exception e)
            {
                return new List<Chocolate>();
            }

        }

        [HttpGet("{id}")]
        public Chocolate Get(string id)
        {
            var chocolate = _chocolateService.GetChocolate(id);
            var origem = chocolate?.OrigemCacau;
            return chocolate;
        }

    }
}
