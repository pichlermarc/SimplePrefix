using SimplePrefix.PrefixContainers;
using SimplePrefix.PrefixTypes;

namespace SimplePrefix
{
    /// <summary>
    /// Offers a simpler syntax compared to using the <see cref="Prefix"/>, <see cref="SI"/>, and <see cref="IEC"/> classes on their own.
    /// </summary>
    public static class Prefixes
    {
        /// <summary>
        /// Provides decimal <see cref="Prefix"/>es based on the definition in the International System of Units (SI)
        /// </summary>
        public static SI SI { get; } = new SI();
        
        /// <summary>
        /// Provides binary <see cref="Prefix"/>es based on IEC 80000-13:2008 Clause 4
        /// </summary>
        public static IEC IEC { get; } = new IEC();

        /// <summary>
        /// Converts a value from prefixed representation to non-prefixed representation.
        /// </summary>
        /// <param name="value">The value to convert to non-prefixed representation.</param>
        /// <param name="prefix">The prefix to remove from the value.</param>
        /// <returns>The non-prefixed representation.</returns>
        public static decimal ConvertFrom(Prefix prefix, decimal value)
        {
            return prefix.ConvertFrom(value);
        }

        /// <summary>
        /// Converts a value from non-prefixed representation to prefixed representation.
        /// </summary>
        /// <param name="value">The value to convert to prefixed representation.</param>
        /// <param name="prefix">The prefix to use with the value.</param>
        /// <returns>The prefixed representation.</returns>
        public static decimal ConvertTo(Prefix prefix, decimal value)
        {
            return prefix.ConvertTo(value);
        }
    }
}