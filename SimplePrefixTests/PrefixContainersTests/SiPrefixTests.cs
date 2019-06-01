using System.Collections.Generic;
using NUnit.Framework;
using SimplePrefix.PrefixContainers;

namespace SimplePrefixTests.PrefixContainersTests
{
    public class SiPrefixTests
    {
        private Dictionary<string, decimal> _expectedValues;
        private SI _prefixes;

        [SetUp]
        public void SetUp()
        {
            _expectedValues = new Dictionary<string, decimal>
            {
                {"Yocto", 0.000000000000000000000001m},
                {"Zepto", 0.000000000000000000001m},
                {"Atto",  0.000000000000000001m},
                {"Femto", 0.000000000000001m},
                {"Pico",  0.000000000001m},
                {"Nano",  0.000000001m},
                {"Micro", 0.000001m},
                {"Milli", 0.001m},
                {"Kilo",  1000m},
                {"Mega",  1000000m},
                {"Giga",  1000000000m},
                {"Tera",  1000000000000m},
                {"Peta",  1000000000000000m},
                {"Exa",   1000000000000000000m},
                {"Zetta", 1000000000000000000000m},
                {"Yotta", 1000000000000000000000000m}
            };

            _prefixes = new SI();
        }
        
        [Test]
        public void ValuesAreAsExpected()
        {
            foreach (var (key, value) in _expectedValues)
            {
                Assert.AreEqual(value, (decimal) _prefixes[key]);
            }
        }
    }
}