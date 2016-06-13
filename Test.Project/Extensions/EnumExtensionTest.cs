using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using NUnit.Framework;

namespace Test.Project.Extensions
{
    [TestFixture]
    public class EnumExtensionTest
    {
        public enum EnumStates
        {
            [System.ComponentModel.Description("Pasif")]
            Passive = 0,
            [System.ComponentModel.Description("Aktif")]
            Active = 1,
            [System.ComponentModel.Description("Sil")]
            Delete = 2
        }

        [Test]
        public void enum_seleclist_test()
        {
            var test = EnumExtensions.SelectlistOf<EnumStates>();
            var mvcSelectList = EnumExtensions.MvcSelectListOf<EnumStates>();

            Console.WriteLine(test);
            Console.WriteLine(mvcSelectList);
        }

    }

    public static class EnumExtensions
    {
        public static dynamic SelectlistOf<T>()
        {
            var enumType = typeof(T);

            // tek satirlik cozum :)
            // return enumType.IsEnum ? Enum.GetValues(enumType).Cast<System.Enum>().Select(x => new { id = x.ToInt32(), text = x.GetDescription() }) : null;

            if (enumType.IsEnum)
            {
                var dict = new Dictionary<int, string>();
                foreach (Enum item in Enum.GetValues(enumType))
                {
                    dict.Add(item.ToInt32(), item.GetDescription());
                }
                return dict.Select(x => new { id = x.Key, text = x.Value });
            }

            return null;
        }

        public static SelectList MvcSelectListOf<T>()
        {
            Type type = typeof(T);
            if (!type.IsEnum) return null;

            var items = Enum.GetValues(type).Cast<Enum>().Select(x => new { Value = x.ToInt32(), Text = x });
            return new SelectList(items, "Value", "Text");
        }

        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return value.ToString();

            var attribute = (System.ComponentModel.DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(System.ComponentModel.DescriptionAttribute));
            return attribute.Description;
        }

        public static int ToInt32(this object obj)
        {
            return Convert.ToInt32(obj);
        }
    }

}