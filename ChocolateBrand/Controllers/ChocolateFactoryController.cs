using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using Services.Factory;
using Services.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChocolateBrand.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChocolateFactoryController : ControllerBase
    {
        private ChocolateFactoryService _chocolateFactoryService;

        public ChocolateFactoryController()
        {
            _chocolateFactoryService = new ChocolateFactoryService();
        }


        [HttpPost]
        public void FabricarChocolate()
        {
            _chocolateFactoryService.FabricarChocolate();
        }

    }
}
