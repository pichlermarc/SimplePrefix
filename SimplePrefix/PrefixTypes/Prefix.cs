namespace SimplePrefix.PrefixTypes
{
    /// <summary>
    /// Represents a prefix. Can be implicitly handled like a <see cref="decimal"/>
    /// </summary>
    public class Prefix
    {
        private readonly decimal _prefixDecimalValue;

        /// <summary>
        /// Creates a new instance of the <see cref="Prefix"/> class.
        /// </summary>
        /// <param name="prefixDecimalValue">The decimal value of the prefix.</param>
        /// <example>
        ///    var milli = new Prefix(0.001m);
        /// </example>
        public Prefix(decimal prefixDecimalValue)
        {
            _prefixDecimalValue = prefixDecimalValue;
        }

        /// <summary>
        /// Converts a value from non-prefixed representation to prefixed representation.
        /// </summary>
        /// <param name="value">The value to convert to prefixed representation.</param>
        /// <returns>The prefixed representation.</returns>
        public virtual decimal ConvertTo(decimal value)
        {
            return value / _prefixDecimalValue;
        }

        /// <summary>
        /// Converts a value from prefixed representation to non-prefixed representation.
        /// </summary>
        /// <param name="value">The value to convert from prefixed representation.</param>
        /// <returns>The non-prefixed representation.</returns>
        public virtual decimal ConvertFrom(decimal value)
        {
            return value * _prefixDecimalValue;
        }
 
        public static implicit operator decimal(Prefix prefix)
        {
            return prefix._prefixDecimalValue;
        }
    }
}