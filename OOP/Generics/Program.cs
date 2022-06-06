using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Fulano";

            DataContext contextPerson = new DataContext<Person>();
            contextPerson.Save(person);
        }
    }
}