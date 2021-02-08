using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.Helpers
{
    public static class ExtensionMethods
    {
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
