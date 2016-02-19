using System;
using System.ComponentModel;

namespace CalculatorTestSuite
{
    public class MyEnum
    {
        public enum Name
        {
            [Description(AboutScreen.TITLE)]
            About,
            Calculator
        }

        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "description");
        }

        public static MyEnum.Name ParseEnum(string title)
        {
            return (MyEnum.Name)MyEnum.GetValueFromDescription<MyEnum.Name>(title);
        }
    }
}
