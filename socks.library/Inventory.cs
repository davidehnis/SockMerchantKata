using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socks.library
{
    public class Inventory
    {
        public static int Socks(int[] inventory)
        {
            if (!inventory.Any()) throw new Exception("set was empty");
            if (inventory.Length > 100) throw new Exception("set was too large");

            // color / count
            var dictionary = new Dictionary<int, int>();
            foreach (var entry in inventory)
            {
                if (dictionary.ContainsKey(entry)) dictionary[entry] = dictionary[entry] + 1;
                else dictionary.Add(entry, 1);
            }

            var pairs = 0;
            foreach (var entry in dictionary)
            {
                pairs = pairs + CountPairs(entry.Value);
            }

            return pairs;
        }

        private static int CountPairs(int value)
        {
            if (value % 2 == 0) return value / 2;
            if (value % 2 == 1) return (value - 1) / 2;

            return 0;
        }
    }
}