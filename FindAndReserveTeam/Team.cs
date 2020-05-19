using System;
using System.Collections.Generic;
using System.Text;

namespace FindAndReserveTeam
{
    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        private List<Person> firstTeam = new List<Person>();

        public List<Person> FirstTeam
        {
            get { return firstTeam; }
        }
        private List<Person> reserveTeam=new List<Person>();

        public List<Person> ReserveTeam
        {
            get
            {
                return reserveTeam;
            }


        }
       public void AddPlayer(Person person) 
            {
            if (person.Age > 40) reserveTeam.Add(person);
            else firstTeam.Add(person);
}
}
}
