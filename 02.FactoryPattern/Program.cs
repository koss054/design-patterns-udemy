using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pf = new PersonFactory();
            var people = new List<Person>();

            Person firstPerson = pf.CreatePerson("Koss");
            Person secondPerson = pf.CreatePerson("Miki");
            Person thirdPerson = pf.CreatePerson("Damqnski");
            Person fourthPerson = pf.CreatePerson("Vanki4a");
            Person fifthPerson = pf.CreatePerson("Dakata");
            Person sixthPerson = pf.CreatePerson("Bili");

            people.Add(firstPerson);
            people.Add(secondPerson);
            people.Add(thirdPerson);
            people.Add(fourthPerson);
            people.Add(fifthPerson);
            people.Add(sixthPerson);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id}-{person.Name}");
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PersonFactory
    {
        private int personId;

        public PersonFactory()
        {
            personId = 0;
        }

        public Person CreatePerson(string name)
        {
            var person = new Person()
            {
                Id = personId,
                Name = name,
            };

            personId++;
            return person;
        }
    }
}