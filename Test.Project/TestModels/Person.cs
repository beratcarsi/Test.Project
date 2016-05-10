namespace Test.Project.TestModels
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " " + SurName + " Age: " + Age;
        }
    }
}