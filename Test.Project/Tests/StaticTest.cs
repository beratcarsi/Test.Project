using System;
using NUnit.Framework;

namespace Test.Project.Tests
{
    [TestFixture]
    public class StaticTest
    {
        [Test]
        public void static_test()
        {
            StaticService.UserName = "A";
            Console.WriteLine(StaticService.UserName);

            StaticService.UserName = "B";
            Console.WriteLine(StaticService.UserName);
        }

        [Test]
        public void class_test()
        {
            var aClass = new ClassService();
            aClass.UserName = "A";
            Console.WriteLine(aClass.UserName);

            aClass.UserName = "B";
            Console.WriteLine(aClass.UserName);
        }

        [Test]
        public void two_class_test()
        {
            var aClass = new ClassService();
            aClass.UserName = "A";
            Console.WriteLine(aClass.UserName);

            var bClass = new ClassService();
            bClass.UserName = "B";
            Console.WriteLine("B: " + bClass.UserName);

            Console.WriteLine("A: " + aClass.UserName);
        }

        public static class StaticService
        {
            public static string UserName { get; set; }
        }

        public class ClassService
        {
            public string UserName { get; set; }
        }
    }
}