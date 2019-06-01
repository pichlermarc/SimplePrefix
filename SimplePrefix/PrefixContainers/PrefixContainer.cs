using System;
using System.Collections.Generic;
using System.Linq;
using SimplePrefix.Attributes;
using SimplePrefix.PrefixTypes;

namespace SimplePrefix.PrefixContainers
{
    /// <summary>
    /// Provides prefixes based on fields with <see cref="PrefixField"/>-Attributes of the child class.
    /// </summary>
    public abstract class PrefixContainer
    {
        private readonly Dictionary<string, Prefix> _prefixes;
        
        /// <summary>
        /// The prefix names that are accessible though the Indexer.  
        /// </summary>
        public ICollection<string> PrefixNames => _prefixes.Keys;
        
        /// <summary>
        /// The <see cref="Prefix"/>es available inside this container.
        /// </summary>
        public IEnumerable<Prefix> Prefixes => _prefixes.Values;

        /// <summary>
        /// Sets up the available prefixes inside the <see cref="PrefixContainer"/> class.
        /// </summary>
        /// <exception cref="InvalidOperationException"> if a base class has set <see cref="PrefixField"/>.OverrideName to <value>true</value> more than once on a given field.</exception>
        protected PrefixContainer()
        {
            _prefixes = new Dictionary<string, Prefix>();
            var memberInfos = GetType()
                .GetFields()
                .Where(field => Attribute.IsDefined(field, typeof(PrefixField))
                                && typeof(Prefix).IsAssignableFrom(field.FieldType));

            foreach (var fieldInfo in memberInfos)
            {
                var prefixField = (PrefixField[]) Attribute.GetCustomAttributes(fieldInfo, typeof(PrefixField));
                var names = prefixField.Where(prefixFieldAttribute => prefixFieldAttribute.PrefixName != string.Empty)
                    .Select(prefixFieldAttribute => prefixFieldAttribute.PrefixName).ToList();

                var overrideAttributes = prefixField
                    .Where(prefixFieldAttribute => prefixFieldAttribute.OverrideName)
                    .ToList();

                if (!overrideAttributes.Any())
                {
                    names.Add(fieldInfo.Name);
                }
                else if (overrideAttributes.Count > 1)
                {
                    throw new InvalidOperationException(
                        "Cannot override default name more than once (Multiple use of overrideName = true)");
                }

                foreach (var name in names)
                {
                    _prefixes.Add(name, (Prefix) fieldInfo.GetValue(this));
                }
            }
        }

        /// <summary>
        /// Gets the prefix with the specified name from the container. 
        /// </summary>
        /// <param name="prefixName">The prefix-name as defined in the <see cref="PrefixField"/>-Annotation.</param>
        public Prefix this[string prefixName] => _prefixes[prefixName];
    }
}