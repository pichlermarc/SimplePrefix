namespace SimplePrefix.PrefixTypes
{
    /// <summary>
    /// Represents a prefix that is defined as a power of 10.
    /// </summary>
    public class DecimalPrefix : Prefix
    {
        
        private static decimal PowerOf(int exponent)
        {
            // NOTE: A Method to do this should exist somewhere, but AFAIK in C# it does not.
            // If someone has a better idea, please feel free to put a more elegant solution here :)
            
            const int baseValue = 10;
            var result = 1m;

            if (exponent > 0)
            {
                for (var remainingExponent = exponent; remainingExponent > 0; remainingExponent--)
                {
                    result *= baseValue;
                }
            }
            else if (exponent < 0)
            {
                for (var remainingExponent = exponent; remainingExponent < 0; remainingExponent++)
                {
                    result *= 1m/baseValue;
                }
            }

            return result;
        }
        
        /// <summary>
        /// Creates a new instance of the <see cref="DecimalPrefix"/> class. 
        /// </summary>
        /// <param name="exponent">The exponent to be used to calculate the power of 10.</param>
        public DecimalPrefix(int exponent) : base(PowerOf(exponent)) { }
    }
}