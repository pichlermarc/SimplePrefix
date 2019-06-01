using NUnit.Framework;
using SimplePrefix.PrefixTypes;

namespace SimplePrefixTests.PrefixTypesTests
{
    public class DecimalPrefixTests
    {
        [Test]
        public void InitializesToCorrectValueWithPositiveExponent()
        {
            var prefix = new DecimalPrefix(3);
            Assert.AreEqual(1000m, (decimal) prefix);
        }

        [Test]
        public void InitializesToCorrectValueWithZeroExponent()
        {
            var prefix = new DecimalPrefix(0);
            Assert.AreEqual(1m, (decimal) prefix);
        }
        
        [Test]
        public void InitializesToCorrectValueWithNegativeExponent()
        {
            var prefix = new DecimalPrefix(-3);
            Assert.AreEqual(0.001m, (decimal) prefix);
        }
    }
}