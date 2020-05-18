using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryIncrease
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
        public Person(string firstName, string lastName, int age, decimal salary) : this()
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;

        }
        private string firstName;
        public string FirstName { get { return firstName; } }
        private string lastName;
        public string LastName { get { return lastName; } }
        private int age;
        public int Age { get { return age; } }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
        }



        public void IncreaseSalary(decimal persentages)
        {
            if (this.age > 30) this.salary += salary * persentages / 100;
            else this.salary += salary * persentages / 200;

        }
        public override string ToString() => $"{ this.FirstName} { this.LastName } recives {this.salary}";


    }
}

