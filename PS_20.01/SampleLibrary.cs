using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{
    public enum PersonMaritalStatus
    {
        Merried,
        Single
    }
    [Serializable]
    public class Person
    {
        public string Name;
        public string LastName;
        int Age;
        public PersonMaritalStatus MaritsalStatus;
        public Person(string Name, string Lastname, int Age)
        {
            this.Name = Name;
            this.LastName = Lastname;
            this.Age = Age;
            this.MaritsalStatus = PersonMaritalStatus.Single;
        }
        public void Print()
        {
            Console.WriteLine("Person:\nName: " + Name + "\nLastname: " + LastName + "\nAge: " + Age);
        }
    }

    public class Employee : Person
    {
        public string Position;
        public decimal Salary;
        public Employee(string Name, string Lastname, int Age, string Position, decimal Salary) :
            base(Name, Lastname, Age)
        {
            this.Position = Position;
            this.Salary = Salary;
        }
    }
}