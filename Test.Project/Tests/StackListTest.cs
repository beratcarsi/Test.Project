using System;
using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;
using Test.Project.TestModels;

namespace Test.Project.Tests
{
    [TestFixture]
    public class StackListTest
    {
        [Test]
        public void stack_list_test()
        {
            var stackList = new Stack<Person>();

            stackList.Push(new Person() { Name = "John", SurName = "Cash", Age = 15 });
            stackList.Push(new Person() { Name = "Mehmet", SurName = "Deli", Age = 20 });
            stackList.Push(new Person() { Name = "Berat", SurName = "Carsi", Age = 25 });

            var lastPerson = stackList.Peek(); // get last person item
            lastPerson.Name.ShouldBe("Berat");

            lastPerson = stackList.Pop(); // get last person item after delete this
            Console.WriteLine(lastPerson);

            stackList.Count.ShouldBe(2);

            stackList.Clear();
            try
            {
                stackList.Peek();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                ex.Message.ShouldBe("Stack empty.");
            }
        }

    }
}
