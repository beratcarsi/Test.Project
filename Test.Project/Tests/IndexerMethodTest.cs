using System;
using System.Collections;
using NUnit.Framework;
using Shouldly;
using Test.Project.TestModels;

namespace Test.Project.Tests
{
    [TestFixture]
    public class IndexerMethodTest
    {
        [Test]
        public void indexer_method_test()
        {
            var people = new PersonCollection();

            people[0] = new Person()
            {
                Name = "Ali",
                SurName = "Tor",
                Age = 21
            };

            for (int i = 0; i < people.Count; i++)
                Console.WriteLine(people[i]);

            people[0].Name.ShouldBe("Ali");
            people.Count.ShouldBe(1);
        }
    }

    public class PersonCollection : IEnumerable
    {
        private ArrayList _arPeople = new ArrayList();

        public Person this[int index]
        {
            get { return (Person)_arPeople[index]; }
            set { _arPeople.Insert(index, value); }
        }

        public int Count
        {
            get { return _arPeople.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return _arPeople.GetEnumerator();
        }
    }

}