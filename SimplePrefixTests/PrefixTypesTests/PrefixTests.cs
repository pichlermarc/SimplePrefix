using NUnit.Framework;
using SimplePrefix.PrefixTypes;

namespace SimplePrefixTests.PrefixTypesTests
{
    public class PrefixTests
    {
        [Test]
        public void PrefixActsLikeDecimal()
        {
            var prefix = new Prefix(123m);
            Assert.True(123m == prefix);
            Assert.AreEqual(123m, (decimal) prefix);
            Assert.AreEqual(124.5m, 1.5m + prefix);
            Assert.AreEqual(246m, prefix * 2m);
        }

        [Test]
        public void ConvertToReturnsCorrectConversion()
        {
            var prefix = new Prefix(1000m);
            Assert.AreEqual(1.5m,prefix.ConvertTo(1500));
            
            prefix = new Prefix(0.001m);
            Assert.AreEqual(1500m, prefix.ConvertTo(1.5m));
        }

        [Test]
        public void ConvertFromReturnsCorrectConversion()
        {
            var prefix = new Prefix(1000m);
            Assert.AreEqual(1500, prefix.ConvertFrom(1.5m));
            
            prefix = new Prefix(0.001m);
            Assert.AreEqual(1.5m, prefix.ConvertFrom(1500));
        }
    }
}