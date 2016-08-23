using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using NUnit.Framework;

namespace Test.Project.Tests
{
    [TestFixture]
    public class ReflectionTest
    {
        [Test]
        public void reflection_test()
        {
            System.Reflection.Assembly info = typeof(SampleClass).Assembly;
            Console.WriteLine(info);

            Assembly asm = Assembly.GetExecutingAssembly();
            var list = asm.GetTypes()
                .Where(type => typeof(SampleClass).IsAssignableFrom(type)) //filter class
                .Where(type => type.IsPublic)
                .Where(type => !type.IsDefined(typeof(NonActionAttribute)))
                .SelectMany(type => type.GetMethods());

            foreach (var methodInfo in list)
            {
                Console.WriteLine(methodInfo.MemberType);
            }
            Console.WriteLine(list);
        }

        [Test]
        public void reflection2_test()
        {
            //var asm = Assembly.Load("Ninject.MVC");
            Assembly asm = Assembly.GetExecutingAssembly();

            var controlleractionlist = asm.GetTypes()
                .Where(type => typeof(System.Web.Mvc.Controller).IsAssignableFrom(type))
                .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                .Where(m => !m.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), true).Any())
                .Select(x => new
                {
                    Controller = x.DeclaringType.Name,
                    Action = x.Name,
                    ReturnType = x.ReturnType.Name,
                    Attributes =
                        string.Join(",", x.GetCustomAttributes().Select(a => a.GetType().Name.Replace("Attribute", "")))
                })
                .OrderBy(x => x.Controller).ThenBy(x => x.Action).ToList();
        }


        public class SampleClass
        {
            public string UserName { get; set; }

            public string Method_A()
            {
                return "A";
            }

            public string Method_B()
            {
                return "B";
            }

        }

    }
}