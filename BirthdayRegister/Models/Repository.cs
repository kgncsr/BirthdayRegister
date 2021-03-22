using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayRegister.Models
{
    public static class Repository
    {
        private static List<Person> _person = new List<Person>();

        public static List<Person> Persons
        {
            get
            {
                return _person;
            }
        }

        public static void AddPerson(Person person)
        {
            _person.Add(person);
        }
    }
}
