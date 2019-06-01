using System;
using NUnit.Framework;
using SimplePrefix.PrefixTypes;

namespace SimplePrefixTests.PrefixTypesTests
{
    public class BinaryPrefixTests
    {
        [Test]
        public void InitializesToCorrectValue()
        {
            var prefix = new BinaryPrefix(10);
            Assert.AreEqual(1024m, (decimal) prefix);
        }

        [Test]
        public void NegativePowerThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BinaryPrefix(-1));
        }
    }
}