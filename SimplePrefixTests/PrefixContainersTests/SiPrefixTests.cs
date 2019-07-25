using System.Collections.Generic;
using NUnit.Framework;
using SimplePrefix.PrefixContainers;

namespace SimplePrefixTests.PrefixContainersTests
{
    public class SiPrefixTests
    {
        private SI _prefixes;

        [SetUp]
        public void SetUp()
        {
            _prefixes = new SI();
        }
        
        [Test]
        public void FieldNameAndValueAsExpected()
        {
            var expectedValues = new Dictionary<string, decimal>
            {
                {"Yocto", 0.000000000000000000000001m},
                {"Zepto", 0.000000000000000000001m},
                {"Atto",  0.000000000000000001m},
                {"Femto", 0.000000000000001m},
                {"Pico",  0.000000000001m},
                {"Nano",  0.000000001m},
                {"Micro", 0.000001m},
                {"Milli", 0.001m},
                {"Centi", 0.01m},
                {"Deci",  0.1m},
                {"Deca",  10m},
                {"Hecto", 100m},
                {"Kilo",  1000m},
                {"Mega",  1000000m},
                {"Giga",  1000000000m},
                {"Tera",  1000000000000m},
                {"Peta",  1000000000000000m},
                {"Exa",   1000000000000000000m},
                {"Zetta", 1000000000000000000000m},
                {"Yotta", 1000000000000000000000000m}
            };

            foreach (var (key, value) in expectedValues)
            {
                Assert.AreEqual(value, (decimal) _prefixes[key]);
            }
        }
        
        [Test]
        public void FieldAlternateNameAndValueAsExpected()
        {
            var expectedValues = new Dictionary<string, decimal>
            {
                {"yocto", 0.000000000000000000000001m},
                {"zepto", 0.000000000000000000001m},
                {"atto",  0.000000000000000001m},
                {"femto", 0.000000000000001m},
                {"pico",  0.000000000001m},
                {"nano",  0.000000001m},
                {"micro", 0.000001m},
                {"milli", 0.001m},
                {"centi", 0.01m},
                {"deci",  0.1m},
                {"deca",  10m},
                {"hecto", 100m},
                {"kilo",  1000m},
                {"mega",  1000000m},
                {"giga",  1000000000m},
                {"tera",  1000000000000m},
                {"peta",  1000000000000000m},
                {"exa",   1000000000000000000m},
                {"zetta", 1000000000000000000000m},
                {"yotta", 1000000000000000000000000m}
            };

            foreach (var (key, value) in expectedValues)
            {
                Assert.AreEqual(value, (decimal) _prefixes[key]);
            }
        }
        
        [Test]
        public void FieldSymbolNamesAndValuesAsExpected()
        {
            var expectedValues = new Dictionary<string, decimal>
            {
                {"y", 0.000000000000000000000001m},
                {"z", 0.000000000000000000001m},
                {"a", 0.000000000000000001m},
                {"f", 0.000000000000001m},
                {"p", 0.000000000001m},
                {"n", 0.000000001m},
                {"µ", 0.000001m},
                {"m", 0.001m},
                {"c", 0.01m},
                {"d", 0.1m},
                {"da",10m},
                {"h", 100m},
                {"k", 1000m},
                {"M", 1000000m},
                {"G", 1000000000m},
                {"T", 1000000000000m},
                {"P", 1000000000000000m},
                {"E", 1000000000000000000m},
                {"Z", 1000000000000000000000m},
                {"Y", 1000000000000000000000000m}
            };

            foreach (var (key, value) in expectedValues)
            {
                Assert.AreEqual(value, (decimal) _prefixes[key]);
            }
        }
    }
}