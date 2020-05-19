using System;
using System.Collections.Generic;

namespace FindAndReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]));

                persons.Add(person);
            }
            
            Team team = new Team("Lexicon");
            foreach (Person p in persons)
            {
                team.AddPlayer(p);
            }
           Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.ReserveTeam.Count);

        }
    }
}