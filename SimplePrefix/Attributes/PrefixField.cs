using System;

namespace SimplePrefix.Attributes
{
    /// <summary>
    /// Used to mark a field that is supposed to be accessible in a <see cref="SimplePrefix.PrefixContainers.PrefixContainer"/>
    /// Per field multiple <see cref="PrefixField"/> Attributes can be used, but only one may 
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class PrefixField : Attribute
    {
        /// <summary>
        /// The PrefixName for set in the <see cref="PrefixField"/> constructor.
        /// </summary>
        public string PrefixName { get; }
        
        /// <summary>
        /// True if the overrideName flag in the <see cref="PrefixField"/> constructor has been set.
        /// </summary>
        public bool OverrideName { get; }
        
        /// <summary>
        /// Creates a new instance of the <see cref="PrefixField"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="overrideName"></param>
        public PrefixField(string name = "", bool overrideName = false)
        {
            PrefixName = name;
            OverrideName = overrideName;
        }
    }
}