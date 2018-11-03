using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    public class Purchase
    {
        public int Issue { get; set; }
        public decimal Price { get; set; }

        public static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal> {
                { 6, 3600M },
                { 19, 500M },
                { 36, 650M },
                { 57, 13525M },
                { 68, 250M },
                { 74, 75M },
                { 83, 25.75M },
                { 97, 35.25M },
            };
        }

        public static PriceRange EvaluatePrice(decimal price)
        {
            if (price < 100M)
                return PriceRange.Cheap;
            else if (price <= 1000M)
                return PriceRange.MidRange;
            else
                return PriceRange.Expensive;
             
        }
    }
}
