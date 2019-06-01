using System.Collections.Generic;
using NUnit.Framework;
using SimplePrefix.PrefixContainers;

namespace SimplePrefixTests.PrefixContainersTests
{
    public class IecPrefixTests
    {
        private Dictionary<string, decimal> _expectedValues;
        private IEC _prefixes;

        [SetUp]
        public void SetUp()
        {
            _expectedValues = new Dictionary<string, decimal>
            {
                {"Kibi", 1024m},
                {"Mebi", 1048576m},
                {"Gibi", 1073741824m},
                {"Tebi", 1099511627776m},
                {"Pebi", 1125899906842624m},
                {"Exbi", 1152921504606846976},
                {"Zebi", 1180591620717411303424m},
                {"Yobi", 1208925819614629174706176m}
            };

            _prefixes = new IEC();
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