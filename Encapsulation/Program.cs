using System;
using System.Collections.Generic;
using System.Linq;
using SortPerson;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            for(int i = 0; i < 5;i++)
            {
                var cmdArge = Console.ReadLine().Split();
                var person = new Person(cmdArge[0], cmdArge[1], int.Parse(cmdArge[2]));
                persons.Add(person);
            }
            persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p=>Console.WriteLine(p.ToString()));
        }
    }
}
