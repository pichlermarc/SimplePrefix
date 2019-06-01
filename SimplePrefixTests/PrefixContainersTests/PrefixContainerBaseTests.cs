using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SimplePrefix.Attributes;
using SimplePrefix.PrefixContainers;
using SimplePrefix.PrefixTypes;

namespace SimplePrefixTests.PrefixContainersTests
{
    public class PrefixContainerBaseTests
    {
        private class FakePrefixContainer : PrefixContainer
        {
            [PrefixField] public readonly Prefix Prefix1 = new Prefix(10);
            [PrefixField] public readonly Prefix Prefix2 = new Prefix(20);
            [PrefixField] public readonly Prefix Prefix3 = new Prefix(30);
        }
        
        private FakePrefixContainer _prefixContainer;
        
        [SetUp]
        public void SetUp()
        {
            _prefixContainer = new FakePrefixContainer();
        }
        
        [Test]
        public void GetNamesCorrect()
        {
            Assert.AreEqual(new List<string> {"Prefix1", "Prefix2", "Prefix3"}, _prefixContainer.PrefixNames);
        }

        [Test]
        public void GetPrefixByNameCorrect()
        {
            Assert.AreEqual(_prefixContainer.Prefix1, _prefixContainer["Prefix1"]);
            Assert.AreEqual(_prefixContainer.Prefix2, _prefixContainer["Prefix2"]);
            Assert.AreEqual(_prefixContainer.Prefix3, _prefixContainer["Prefix3"]);
        }

        [Test]
        public void GetPrefixesCorrect()
        {
            Assert.AreEqual(new List<Prefix> {_prefixContainer.Prefix1, _prefixContainer.Prefix2, _prefixContainer.Prefix3}, _prefixContainer.Prefixes.ToList());
        }
    }

    public class PrefixContainerBaseComplexTests
    {
        private class FakePrefixContainerWithAlternateNames : PrefixContainer
        {
            [PrefixField("prefix1")] 
            public readonly Prefix Prefix1 = new Prefix(10);
            [PrefixField("prefix2")] 
            public readonly Prefix Prefix2 = new Prefix(20);
            [PrefixField("prefix3")] 
            public readonly Prefix Prefix3 = new Prefix(30);
        }

        [Test]
        public void PrefixContainerAlternateNames()
        {
            var container = new FakePrefixContainerWithAlternateNames();
            Assert.AreEqual(container.Prefix1, container["Prefix1"]);
            Assert.AreEqual(container.Prefix2, container["Prefix2"]);
            Assert.AreEqual(container.Prefix3, container["Prefix3"]);
            Assert.AreEqual(container.Prefix1, container["prefix1"]);
            Assert.AreEqual(container.Prefix2, container["prefix2"]);
            Assert.AreEqual(container.Prefix3, container["prefix3"]);
        }

        private class FakePrefixContainerWithMultipleAlternateNames : PrefixContainer
        {
            [PrefixField("prefix1")]
            [PrefixField("prefixOne")]
            [PrefixField("prefixUno")]
            public readonly Prefix Prefix1 = new Prefix(10);
            [PrefixField("prefix2")] 
            [PrefixField("prefixTwo")] 
            public readonly Prefix Prefix2 = new Prefix(20);
            [PrefixField("prefix3")] 
            public readonly Prefix Prefix3 = new Prefix(30);
        }
        
        [Test]
        public void PrefixContainerMultipleAlternateNames()
        {
            var container = new FakePrefixContainerWithMultipleAlternateNames();
            Assert.AreEqual(container.Prefix1, container["Prefix1"]);
            Assert.AreEqual(container.Prefix2, container["Prefix2"]);
            Assert.AreEqual(container.Prefix3, container["Prefix3"]);
            Assert.AreEqual(container.Prefix1, container["prefix1"]);
            Assert.AreEqual(container.Prefix2, container["prefix2"]);
            Assert.AreEqual(container.Prefix3, container["prefix3"]);
            Assert.AreEqual(container.Prefix1, container["prefixOne"]);
            Assert.AreEqual(container.Prefix1, container["prefixUno"]);
            Assert.AreEqual(container.Prefix2, container["prefixTwo"]);
        }
        
        private class FakePrefixContainerWithOverrideNames : PrefixContainer
        {
            [PrefixField("prefixOne", true)] 
            public readonly Prefix Prefix1 = new Prefix(10);
            [PrefixField("prefixTwo", true)] 
            public readonly Prefix Prefix2 = new Prefix(20);
            [PrefixField("prefix3")] 
            public readonly Prefix Prefix3 = new Prefix(30);
        }
        
        
        [Test]
        public void PrefixContainerWithOverrideNames()
        {
            var container = new FakePrefixContainerWithOverrideNames();
            Assert.AreEqual(container.Prefix3, container["Prefix3"]);
            Assert.AreEqual(container.Prefix1, container["prefixOne"]);
            Assert.AreEqual(container.Prefix2, container["prefixTwo"]);
            Assert.AreEqual(container.Prefix3, container["prefix3"]);

            Assert.Throws<KeyNotFoundException>(() =>
            {
                var discard = container["Prefix1"];
            });
            
            
            Assert.Throws<KeyNotFoundException>(() =>
            {
                var discard = container["Prefix2"];
            });
        }
        
        private class FakePrefixContainerWithMultipleOverrideNames : PrefixContainer
        {
            [PrefixField("prefixOne", true)]
            [PrefixField("prefixTwo", true)] 
            public readonly Prefix Prefix1 = new Prefix(10);
            [PrefixField("prefixTwo", true)] 
            public readonly Prefix Prefix2 = new Prefix(20);
            [PrefixField("prefix3")] 
            public readonly Prefix Prefix3 = new Prefix(30);
        }

        [Test]
        public void PrefixContainerWithMultipleOverrideNames()
        {
            Assert.Throws<InvalidOperationException>(() => new FakePrefixContainerWithMultipleOverrideNames());
        }
    }
}