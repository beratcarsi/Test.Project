using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Test.Project.TestModels;

namespace Test.Project.Tests
{
    [TestFixture]
    public class QueueListTest
    {
        [Test]
        public void generic_queue_list_test()
        {
            //Queue<T>: FIFO; ilk giren ilk cikar mantigina gore calisir.
            //Enqueue: Queue yapımıza yeni bir eleman eklemek için kullanılır.
            //Dequeue: Queue yapımızdan sıradaki ilk elemanı alıp bu elemanı siler.
            //Peek : Queue'deki nesneyi silmeden son elemanı döndürür.

            Queue<Person> personQueue = new Queue<Person>();
            personQueue.Enqueue(new Person() { Name = "Ahmet", SurName = "Kem", Age = 21 });
            personQueue.Enqueue(new Person() { Name = "Mehmet", SurName = "Tac", Age = 15 });

            Console.WriteLine($"Peeked : {personQueue.Peek()}");
            Console.WriteLine($"Dequeue : {personQueue.Dequeue()}");

            Console.WriteLine($"Peeked : {personQueue.Peek()}");
            Console.WriteLine($"Dequeue : {personQueue.Dequeue()}");

            try
            {
                Console.WriteLine($"Peeked : {personQueue.Peek()}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

        }

    }
}