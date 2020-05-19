using System;
using System.Collections.Generic;
using System.Text;

namespace FindAndReserveTeam
{
   public class Person
    {
        public Person()
        {
            Console.WriteLine("person added");
        }
        public Person(string firstName, string lastName, int age) : this()
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;

            //Team.AddPlayer(this);
        }
        private string firstName;
        public string FirstName { get { return firstName; } }
        private string lastName;
        public string LastName { get { return lastName; } }
        private int age;
        public int Age { get { return age; } }

    }
}
