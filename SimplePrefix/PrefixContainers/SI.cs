using SimplePrefix.Attributes;
using SimplePrefix.PrefixTypes;

namespace SimplePrefix.PrefixContainers
{
    /// <summary>
    /// Provides decimal <see cref="Prefix"/>es based on the definition in the International System of Units (SI)
    /// </summary>
    public class SI : PrefixContainer
    {
        [PrefixField] public readonly Prefix Yocto = new DecimalPrefix(-24);
        [PrefixField] public readonly Prefix Zepto = new DecimalPrefix(-21);
        [PrefixField] public readonly Prefix Atto = new DecimalPrefix(-18);
        [PrefixField] public readonly Prefix Femto = new DecimalPrefix(-15);
        [PrefixField] public readonly Prefix Pico = new DecimalPrefix(-12);
        [PrefixField] public readonly Prefix Nano = new DecimalPrefix( -9);
        [PrefixField] public readonly Prefix Micro = new DecimalPrefix(-6);
        [PrefixField] public readonly Prefix Milli = new DecimalPrefix(-3);
        [PrefixField] public readonly Prefix Kilo = new DecimalPrefix(3);
        [PrefixField] public readonly Prefix Mega = new DecimalPrefix(6);
        [PrefixField] public readonly Prefix Giga = new DecimalPrefix(9);
        [PrefixField] public readonly Prefix Tera = new DecimalPrefix(12);
        [PrefixField] public readonly Prefix Peta = new DecimalPrefix(15);
        [PrefixField] public readonly Prefix Exa = new DecimalPrefix(18);
        [PrefixField] public readonly Prefix Zetta = new DecimalPrefix(21);
        [PrefixField] public readonly Prefix Yotta = new DecimalPrefix(24);
    }
}