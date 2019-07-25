using SimplePrefix.Attributes;
using SimplePrefix.PrefixTypes;

namespace SimplePrefix.PrefixContainers
{
    /// <summary>
    /// Provides decimal <see cref="Prefix"/>es based on the definition in the International System of Units (SI)
    /// </summary>
    public class SI : PrefixContainer
    {
        [PrefixField("yocto")] [PrefixField("y")]
        public readonly Prefix Yocto = new DecimalPrefix(-24);

        [PrefixField("zepto")] [PrefixField("z")]
        public readonly Prefix Zepto = new DecimalPrefix(-21);

        [PrefixField("atto")] [PrefixField("a")]
        public readonly Prefix Atto = new DecimalPrefix(-18);

        [PrefixField("femto")] [PrefixField("f")]
        public readonly Prefix Femto = new DecimalPrefix(-15);

        [PrefixField("pico")] [PrefixField("p")]
        public readonly Prefix Pico = new DecimalPrefix(-12);

        [PrefixField("nano")] [PrefixField("n")]
        public readonly Prefix Nano = new DecimalPrefix(-9);

        [PrefixField("micro")] [PrefixField("µ")]
        public readonly Prefix Micro = new DecimalPrefix(-6);

        [PrefixField("milli")] [PrefixField("m")]
        public readonly Prefix Milli = new DecimalPrefix(-3);
        
        [PrefixField("centi")] [PrefixField("c")]
        public readonly Prefix Centi = new DecimalPrefix(-2);

        [PrefixField("deci")] [PrefixField("d")]
        public readonly Prefix Deci = new DecimalPrefix(-1);

        [PrefixField("deca")] [PrefixField("da")]
        public readonly Prefix Deca = new DecimalPrefix(1);

        [PrefixField("hecto")] [PrefixField("h")]
        public readonly Prefix Hecto = new DecimalPrefix(2);

        [PrefixField("kilo")] [PrefixField("k")]
        public readonly Prefix Kilo = new DecimalPrefix(3);

        [PrefixField("mega")] [PrefixField("M")]
        public readonly Prefix Mega = new DecimalPrefix(6);

        [PrefixField("giga")] [PrefixField("G")]
        public readonly Prefix Giga = new DecimalPrefix(9);

        [PrefixField("tera")] [PrefixField("T")]
        public readonly Prefix Tera = new DecimalPrefix(12);

        [PrefixField("peta")] [PrefixField("P")]
        public readonly Prefix Peta = new DecimalPrefix(15);

        [PrefixField("exa")] [PrefixField("E")]
        public readonly Prefix Exa = new DecimalPrefix(18);

        [PrefixField("zetta")] [PrefixField("Z")]
        public readonly Prefix Zetta = new DecimalPrefix(21);

        [PrefixField("yotta")] [PrefixField("Y")]
        public readonly Prefix Yotta = new DecimalPrefix(24);
    }
}