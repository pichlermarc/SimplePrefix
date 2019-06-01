using Moq;
using NUnit.Framework;
using SimplePrefix.PrefixTypes;
using SimplePrefix;

namespace SimplePrefixTests
{
    public class PrefixesTests
    {
        [Test]
        public void ConvertToCallsPrefix()
        {
            var prefix = new Mock<Prefix>(10m);
            prefix.Setup(mock => mock.ConvertTo(10m)).Returns(20m);
            Assert.AreEqual(20m, Prefixes.ConvertTo(prefix.Object, 10m));
            prefix.Verify(mock => mock.ConvertTo(10m), Times.Once);
        }
        
        [Test]
        public void ConvertFromCallsPrefix()
        {
            var prefix = new Mock<Prefix>(10m);
            prefix.Setup(mock => mock.ConvertFrom(10m)).Returns(20m);
            Assert.AreEqual(20m, Prefixes.ConvertFrom(prefix.Object, 10m));
            prefix.Verify(mock => mock.ConvertFrom(10m), Times.Once);
        }

        [Test]
        public void SiAreAlwaysTheSameObject()
        {
            Assert.AreSame(Prefixes.SI, Prefixes.SI);
        }
        
        
        [Test]
        public void IecAreAlwaysTheSameObject()
        {
            Assert.AreSame(Prefixes.IEC, Prefixes.IEC);
        }
    }
}