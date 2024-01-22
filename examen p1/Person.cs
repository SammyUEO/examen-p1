using examen_p1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_p1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int YearOfBirth { get; set; }
        public int Age
        {
            get
            {
              
                return DateTime.Now.Year - YearOfBirth;
            }
        }

    }
}   static class PersonProcessor
{
    public static Person FindTheOldestPerson(Person[] people)
    {
        Person oldestPerson = null;

        foreach (var person in people)
        {
            if (person == null || person.Age > oldestPerson.Age)
            {
                oldestPerson = person;
            }
        }
        return oldestPerson;
    }
}
