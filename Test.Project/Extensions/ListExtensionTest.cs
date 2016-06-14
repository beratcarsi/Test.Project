using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using NUnit.Framework;
using Shouldly;
using Test.Project.Core;
using Test.Project.TestModels;

namespace Test.Project.Extensions
{
    [TestFixture]
    public class ListExtensionTest
    {
        [Test]
        public void selectlist_test()
        {
            var list = new Person().GetDataList();

            var selectList = list.ToSelectList(x => x.Id, y => y.Name);

            Console.WriteLine(selectList);
        }


        [Test]
        public void static_reflection_get_property_name_test()
        {
            //Should return "Length", value type property
            StaticReflection.GetPropertyName<string>(x => x.Length).ShouldBe("Length");

            //Should return "Data", reference type property
            StaticReflection.GetPropertyName<Exception>(x => x.Data).ShouldBe("Data");

            //Should return "Clone", method returning reference type
            StaticReflection.GetPropertyName<string>(x => x.Clone()).ShouldBe("Clone");

            //Should return "GetHashCode", method returning value type
            StaticReflection.GetPropertyName<string>(x => x.GetHashCode()).ShouldBe("GetHashCode");

            //Should return "Reverse", void method
            StaticReflection.GetPropertyName<List<string>>(x => x.Reverse()).ShouldBe("Reverse");

            //Should return "LastIndexOf", method with parameter
            StaticReflection.GetPropertyName<string>(x => x.LastIndexOf(',')).ShouldBe("LastIndexOf");

            //Should return "Length", no type parameter required
            "someString".GetPropertyName(x => x.Length).ShouldBe("Length");
        }

    }


    public static class ListExtensions
    {
        public static SelectList ToSelectList<T>(this IList<T> list, Expression<Func<T, object>> valueFieldName, Expression<Func<T, object>> textFieldName)
        {
            var id = StaticReflection.GetPropertyName(valueFieldName);  // .net fw 4.5 de type belirtilmeli: StaticReflection.GetPropertyName<T>(valueFieldName);
            var text = StaticReflection.GetPropertyName(textFieldName);

            return new SelectList(list, id, text);
        }
    }

}