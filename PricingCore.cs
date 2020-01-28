using System;

namespace samplepricing
{
    public class PricingCore
    {
        public DateTime Date { get; set; }

	public Decimal Price {get; set; }

	public long Id {get; set; }

	public string Currency {get; set; }
	    
	public string PriceSource {get; set; }
	/*Added a comment more data on tagging*/
    }
}
