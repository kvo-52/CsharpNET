using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsClient
{
    internal class RandomNameGenerator
    {
        private static readonly Random random = new Random();

        public static string GenerateRandomName()
        {
            string[] prefixes = { "Big", "Good", "Brilliant", "Shok", "Danger" };
            string[] suffixes = { "Kat", "Tom", "Bob", "Mikl", "Evgeniya" };

            string randomPrefix = prefixes[random.Next(prefixes.Length)];
            string randomSuffix = suffixes[random.Next(suffixes.Length)];

            return $"{randomPrefix} {randomSuffix}";
        }

    }
}
