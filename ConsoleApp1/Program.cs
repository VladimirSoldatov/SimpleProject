using System;
using static System.Console;
namespace SimpleProject
{
    public class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;
        public Human(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }
        public Human(string fName, string lName,
        DateTime date)
        {
            _lastName = lName;
            _birthDate = date;
        }
        public void Show()
        {
            WriteLine($"\nФамилия: {_lastName}" +
                $"\nИмя: { _firstName}\nДата рождения:" +
                $"{_birthDate.ToShortDateString()} " +
                $"");
        }
    }
    public class Employee : Human
    {
        double _salary;
        public Employee(string fName, string lName) :
        base(fName, lName)
        { }
        public Employee(string fName, string lName,
        double salary)
        : base(fName, lName)
        {
            _salary = salary;
        }
        public Employee(string fName, string lName,
        DateTime date, double salary)
        : base(fName, lName, date)
        {
            _salary = salary;
        }
        public void Print()
        {
            Show();
            WriteLine($"Заработная плата: {_salary}$");
        }

        }
        class Program
        {
            static void Main(string[] args)
            {
            Employee employee = new Employee("John",
            "Doe");
            employee.Print();
            employee = new Employee("Jim", "Beam", 1253);
            employee.Print();
            employee = new Employee("Jack", "Smith",
            DateTime.Now, 3587.43);
            employee.Print();
        }
        }
    }