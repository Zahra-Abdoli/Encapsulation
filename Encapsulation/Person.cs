using System;
using System.Collections.Generic;
using System.Text;

namespace SortPerson
{
   public class Person
    {
        //private string firstName;
        //private string lastName;
        //private int age;
        public Person()
        {
            Console.WriteLine("person added");
        }
        public Person(string firstName,string lastName,int age) :this()
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;

        }
        
        public string FirstName { get; set; }
        public string LastName { get; private set; }
            public int Age { get; set; }
   public override string ToString()=> $"{ this.FirstName} { this.LastName } is { this.Age} years old";
        
    }
   
}
