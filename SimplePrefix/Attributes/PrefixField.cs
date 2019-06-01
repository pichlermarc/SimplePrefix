using System;

namespace SimplePrefix.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class PrefixField : Attribute
    {
        public string PrefixName { get; }
        public bool OverrideName { get; }
        
        public PrefixField(string name = "", bool overrideName = false)
        {
            PrefixName = name;
            OverrideName = overrideName;
        }
    }
}