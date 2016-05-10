using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Test.Project.Tests
{
    [TestFixture]
    public class DelegateTest
    {
        [Test]
        public void traditional_delegate_test()
        {
            var numbers = new List<int>();
            numbers.AddRange(new int[] { 5, 7, 9, 14, 17, 2, 6 });

            var predicate = new Predicate<int>(IsEvenNumber);
            var evenNumbers = numbers.FindAll(predicate);

            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void anonymous_method_delegate_test()
        {
            var numbers = new List<int>();
            numbers.AddRange(new int[] { 5, 7, 9, 14, 17, 2, 6 });

            List<int> evenNumbers = numbers.FindAll(
                delegate (int i) { return (i % 2) == 0; }
                );

            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void lambda_expression_test()
        {
            var numbers = new List<int>();
            numbers.AddRange(new int[] { 5, 7, 9, 14, 17, 2, 6 });

            List<int> evenNumbers = numbers.FindAll(i => i % 2 == 0);

            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }

        // Target for the Predicate<> delegate.  
        static bool IsEvenNumber(int i)
        {
            // Is it an even number?  
            return (i % 2) == 0;
        }

    }
}