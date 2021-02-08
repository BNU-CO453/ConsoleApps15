using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ConsoleAppProject.Helpers
{
    public static class EnumHelper<T>
    {
        public static string GetDescription(Enum @enum)
        {
            if (@enum == null)
                return null;

            string description = @enum.ToString();

            try
            {
                FieldInfo fi = @enum.GetType().GetField(@enum.ToString());

                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes.Length > 0)
                    description = attributes[0].Description;
            }
            catch
            {
            }

            return description;
        }

        public static string GetDisplayValue(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes == null) return string.Empty;
            return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
        }
    }
}
