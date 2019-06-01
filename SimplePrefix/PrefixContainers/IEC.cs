using SimplePrefix.Attributes;
using SimplePrefix.PrefixTypes;

namespace SimplePrefix.PrefixContainers
{
    /// <summary>
    /// Provides binary <see cref="Prefix"/>es based on IEC 80000-13:2008 Clause 4
    /// </summary>
    public class IEC : PrefixContainer
    {
        [PrefixField("kibi")] public readonly Prefix Kibi = new BinaryPrefix(10);
        [PrefixField("mebi")] public readonly Prefix Mebi = new BinaryPrefix(20);
        [PrefixField("gibi")] public readonly Prefix Gibi = new BinaryPrefix(30);
        [PrefixField("tebi")] public readonly Prefix Tebi = new BinaryPrefix(40);
        [PrefixField("pebi")] public readonly Prefix Pebi = new BinaryPrefix(50);
        [PrefixField("exbi")] public readonly Prefix Exbi = new BinaryPrefix(60);
        [PrefixField("zebi")] public readonly Prefix Zebi = new BinaryPrefix(70);
        [PrefixField("yobi")] public readonly Prefix Yobi = new BinaryPrefix(80);
    }
}