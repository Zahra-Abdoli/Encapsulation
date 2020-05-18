using System;
using System.Collections.Generic;
using System.Text;

namespace SortPerson
{
    /// <summary>
    /// 
    /// </summary>
   public class Person
    {
        public Person()
        {
            Console.WriteLine("person added");
        }
        public Person(string firstName,string lastName,int age) :this()
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;

        }
        private string firstName;
        public string FirstName { get { return firstName; }}
        private string lastName;
        public string LastName { get { return lastName; } }
        private int  age;
        public int Age { get { return age; } }
   public override string ToString()=> $"{ this.FirstName} { this.LastName } is { this.Age} years old";
        
    }
   
}
