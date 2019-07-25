using SimplePrefix.Attributes;
using SimplePrefix.PrefixTypes;

namespace SimplePrefix.PrefixContainers
{
    /// <summary>
    /// Provides binary <see cref="Prefix"/>es based on IEC 80000-13:2008 Clause 4
    /// </summary>
    public class IEC : PrefixContainer
    {
        [PrefixField("kibi")] [PrefixField("Ki")]
        public readonly Prefix Kibi = new BinaryPrefix(10);

        [PrefixField("mebi")] [PrefixField("Mi")]
        public readonly Prefix Mebi = new BinaryPrefix(20);

        [PrefixField("gibi")] [PrefixField("Gi")]
        public readonly Prefix Gibi = new BinaryPrefix(30);

        [PrefixField("tebi")] [PrefixField("Ti")]
        public readonly Prefix Tebi = new BinaryPrefix(40);

        [PrefixField("pebi")] [PrefixField("Pi")]
        public readonly Prefix Pebi = new BinaryPrefix(50);

        [PrefixField("exbi")] [PrefixField("Ei")]
        public readonly Prefix Exbi = new BinaryPrefix(60);

        [PrefixField("zebi")] [PrefixField("Zi")]
        public readonly Prefix Zebi = new BinaryPrefix(70);

        [PrefixField("yobi")] [PrefixField("Yi")]
        public readonly Prefix Yobi = new BinaryPrefix(80);
    }
}