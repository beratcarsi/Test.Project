using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Test.Project.Tests
{
    [TestFixture]
    public class EventHandlerTest
    {
        [Test]
        public void event_handler_test()
        {
            Person p1 = new Person() { PersonId = 1, Name = "Ali" };
            p1.PersonHasChanged += ShowChangedUser;
            p1.PersonHasChanged += SendChangedUserInformation;
            p1.Name = "Test";
        }

        static void ShowChangedUser(Person p, string fieldName, string newValue)
        {
            Console.WriteLine($"Person ID: {p.PersonId} Field: {fieldName} | New Value: {newValue}");
        }

        static void SendChangedUserInformation(Person p, string fieldName, string newValue)
        {
            Console.WriteLine($"Person ID: {p.PersonId} Bilgilendirme maili gonderiliyor");
        }

        public class Person
        {
            public delegate void PersonChangeHandler(Person person, string fieldName, string newValue);
            public event PersonChangeHandler PersonHasChanged;

            public int PersonId { get; set; }
            private string _name;
            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                    //eger event method set edildi ise calistir
                    PersonHasChanged?.Invoke(this, "Name", value);
                }
            }
        }


        [Test]
        public void generic_event_handler_test()
        {
            var p1 = new PersonWithGenericEvent() { PersonId = 1, Name = "Ali" };
            p1.PersonHasChanged += ShowChangedUser;
            p1.PersonHasChanged += SendChangedUserInformation;
            p1.Name = "Test2";
        }
        static void ShowChangedUser(object sender, CustomEventArgs e)
        {
            Console.WriteLine($@"Person ID: {e.PersonId} Field: {e.FieldName} | New Value: {e.NewValue}");
        }
        static void SendChangedUserInformation(object sender, CustomEventArgs e)
        {
            Console.WriteLine($@"Person ID: {e.PersonId} Bilgilendirme maili gonderiliyor");
        }

        class PersonWithGenericEvent
        {
            public event EventHandler<CustomEventArgs> PersonHasChanged;

            public int PersonId { get; set; }
            private string _name;
            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                    if (PersonHasChanged != null)
                    {
                        CustomEventArgs c = new CustomEventArgs();
                        c.PersonId = this.PersonId;
                        c.FieldName = "Name";
                        c.NewValue = value;
                        PersonHasChanged(this, c);
                    }
                }
            }
        }

        public class CustomEventArgs : EventArgs
        {
            public int PersonId { get; set; }
            public string FieldName { get; set; }
            public string NewValue { get; set; }
        }

    }
}