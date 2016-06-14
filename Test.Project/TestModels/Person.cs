using System.Collections.Generic;

namespace Test.Project.TestModels
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " " + SurName + " Age: " + Age;
        }

        public List<Person> GetDataList()
        {
            var list = new List<Person>
            {
                new Person() { Id = 1, Name = "John", SurName = "Cash", Age = 15 },
                new Person() { Id = 2, Name = "Mehmet", SurName = "Deli", Age = 20 },
                new Person() { Id = 3, Name = "Berat", SurName = "Carsi", Age = 25 }
            };
            return list;
        }
    }
}