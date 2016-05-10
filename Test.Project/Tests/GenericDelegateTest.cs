using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Test.Project.Tests
{
    [TestFixture]
    public class GenericDelegateTest
    {
        private delegate void MyGenericDelegate<in T>(T args);

        [Test]
        public void generic_delegate_test()
        {
            var stringDelegate = new MyGenericDelegate<string>(StringTarget);
            var intDelegate = new MyGenericDelegate<int>(IntTarget);

            stringDelegate("Elif");
            intDelegate(24);
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
        }
        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }

        [Test]
        public void action_delegate_test()
        {
            var action = new Action<string, int>(DisplayAge);
            action("Berat", 27);
        }
        static void DisplayAge(string fullName, int age)
        {
            Console.WriteLine(fullName + " : " + age);
        }

        [Test]
        public void func_delegate_test()
        {
            var func = new Func<DateTime, double>(GetUserAgeAtTime);
            double dateDif = func(new DateTime(1989, 3, 21));
            Console.WriteLine("Date Dif: {0}", dateDif);
        }
        static double GetUserAgeAtTime(DateTime birthDate)
        {
            return (DateTime.Now - birthDate).TotalDays;
        }

    }
}