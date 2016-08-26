
namespace Test.Project.TestModels
{
    public class FakeTableClass
    {
        public int Id { get; set; }
        public int AnInt { get; set; }
        public string AString { get; set; }
        public float AFloat { get; set; }
        public FKTableClass AFKReference { get; set; }
    }

    public class FKTableClass
    {
        public int Id { get; set; }
        public int AFKInt { get; set; }
    }
}