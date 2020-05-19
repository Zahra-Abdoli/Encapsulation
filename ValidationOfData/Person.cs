using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationOfData
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("person added");
        }
        public Person(string firstName, string lastName, int age, decimal salary) : this()
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;

        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value.Length < 3) Console.WriteLine(" First name cannot contain fewer than 3 symbols!");
                else this.firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3) throw new ArgumentException(" Lastname cannot contain fewer than 3 symbols!");
                else this.lastName = value;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value <= 0) throw new ArgumentException("Age cannot be zero or a negative integer!");
                else age = value;
            }
        }

        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 460) throw new ArgumentException("Salary cannot be less than 460 dollars!");
                 else this.salary = value;
            }
        }



        public void IncreaseSalary(decimal persentages)
        {
            if (this.age > 30) this.salary += this.salary * persentages / 100;
            else this.salary += this.salary * persentages / 200;

        }
        public override string ToString() => $"{ this.FirstName} { this.LastName } recives {this.salary}";



    }
}
