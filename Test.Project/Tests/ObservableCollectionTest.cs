using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Test.Project.TestModels;
using NUnit.Framework;

namespace Test.Project.Tests
{
    [TestFixture]
    public class ObservableCollectionTest
    {
        [Test]
        public void observable_collection_test()
        {
            var people = new ObservableCollection<Person>();

            // event'i delege ediyoruz
            people.CollectionChanged += CollectionChanged;

            people.Add(new Person() { Name = "Kemal", SurName = "Sayar", Age = 23 });
            people.Add(new Person() { Name = "Soner", SurName = "Okcu", Age = 19 });

            people.RemoveAt(0);
        }

        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Action for this event: {0}", e.Action);

            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Silinen insanlar:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Eklenen insanlar:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }

    }
}