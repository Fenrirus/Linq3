using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, decimal> values = Purchase.GetPrices();
            var priceGroups =
             from pair in values
             group pair.Key by Purchase.EvaluatePrice(pair.Value)
             into priceGroup
             orderby priceGroup.Key descending
             select priceGroup;

            foreach (var group in priceGroups)
            {
                string stringKey;
                switch (group.Key)
                {
                    case PriceRange.Cheap:
                        stringKey = "tanie";
                        break;
                    case PriceRange.MidRange:
                        stringKey = "średnie";
                        break;
                    default:
                        stringKey = "tanie";
                        break;
                }
                Console.Write($"Znalazłem {group.Count()} {stringKey}");
                foreach (var issue in group)
                {
                    Console.Write(issue.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
