using System;

namespace SimplePrefix.PrefixTypes
{
    /// <summary>
    /// Represents a prefix that is defined as a power of two.
    /// </summary>
    public class BinaryPrefix : Prefix
    {
        private static decimal PowerOf(int exponent)
        {
            if (exponent < 0)
                throw new ArgumentException("BinaryPrefix only allows for positive powers of two.");

            if (exponent <= 63) return 1uL << exponent;

            decimal result = 1uL << 63;
            const int baseValue = 2;
            exponent -= 63;

            for (var remainingExponent = exponent; remainingExponent > 0; remainingExponent--)
            {
                result *= baseValue;
            }

            return result;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="BinaryPrefix"/> class.
        /// </summary>
        /// <param name="exponent">The exponent to be used to calculate the power of 2.</param>
        public BinaryPrefix(int exponent) : base(PowerOf(exponent))
        {
        }
    }
}