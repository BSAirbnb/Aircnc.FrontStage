using System;
using System.ComponentModel;

namespace Aircnc.FrontStage.Common
{
    public static class EnumHelper
    {

        public static string GetDescriptionText(this Enum source)
        {
            var field = source.GetType().GetField(source.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return source.ToString();
        }
    }
}
