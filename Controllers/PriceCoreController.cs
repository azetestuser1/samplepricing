using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace samplepricing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceCoreController : ControllerBase
    {
        private readonly ILogger<PriceCoreController> _logger;
	
        public PriceCoreController(ILogger<PriceCoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public PricingCore Get(int id)
        {
            var rng = new Random();
	    PricingCore pricingCore = new PricingCore();
	    pricingCore.Date = DateTime.Today ;
	    pricingCore.Price = new Decimal(rng.NextDouble()*50+10);
	    pricingCore.Id = id;
	    pricingCore.Currency = "USD";
	    Console.WriteLine(pricingCore);
	    return pricingCore;
        }
    }
}
