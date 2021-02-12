using System;
using System.Linq;
using System.Reflection;

namespace ConsoleAppProject.Helpers
{
    /// <summary>
    /// These methods extend existing classes or enuerations
    /// By Derek & Andrei
    /// </summary>
    public static class ExtensionMethods
    {

        /// <summary>
        /// Discovered by Andrei Cruceru Where ??
        /// Much better as it works for any enumeration but needs
        /// using System.ComponentModel;
        /// using System.ComponentModel.DataAnnotations;
        /// When used.
        /// </summary>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
            where TAttribute : Attribute
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<TAttribute>();
        }

        /// <summary>
        /// Discovered by Derek in Stack Overflow
        /// Not so good as it needs a new method for every 
        /// different enumeration
        /// </summary>
        public static string EnumValue(this MyEnum e)
        {
            switch (e)
            {
                case MyEnum.FirstValue:
                    return "First Friendly Value";
                case MyEnum.SecondValue:
                    return "Second Friendly Value";
                case MyEnum.ThirdValue:
                    return "Third Friendly Value";
            }
            return "Horrible Failure!!";
        }

    }
}
