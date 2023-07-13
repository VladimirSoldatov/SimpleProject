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
    class Manager : Employee
    {
        string _fieldActivity;
        public Manager(string fName, string lName,
        DateTime date, double salary, string
        activity) : base(fName, lName,
        date, salary)
        {
            _fieldActivity = activity;
        }
        public void ShowManager()
        {
            WriteLine($"Менеджер. Сфера деятельности: {_fieldActivity}");
        }
    }
    class Scientist : Employee
    {
        string _scientificDirection;
        public Scientist(string fName, string lName,
        DateTime date, double salary, string
        direction) : base(fName, lName, date,
        salary)
        {
            _scientificDirection = direction;
        }
        public void ShowScientist()
        {
            WriteLine($"Ученый. Научное направление: { _scientificDirection}");
        }
    }


    class Specialist : Employee
    {
        string _qualification;
        public Specialist(string fName, string lName,
        DateTime date, double salary, string
        qualification) : base(fName, lName,
        date, salary)
        {
            _qualification = qualification;
        }
        public void ShowSpecialist()
        {
            WriteLine($"Специалист. Квалификация: {_qualification}");
        }
    }
class Program
{
    static void Main(string[] args)
    {
        Employee manager = new Manager("John", "Doe", new DateTime(1995, 7, 23), 3500, "продукты питания");
        Employee[] employees = 
        {
                manager,
                new Scientist("Jim", "Beam", new DateTime(1956,3,15), 4253, "история"),
                new Specialist("Jack", "Smith", new DateTime(1996,11,5), 2587.43,"физика")
        };
        foreach (Employee item in employees)
        {
            item.Print();
            //item.ShowScientist(); Error
            try
            {
                ((Specialist)item).
                ShowSpecialist(); // Способ №1
            }
            catch
            {
            }
            Scientist scientist = item as
            Scientist; // Способ №2
            if (scientist != null)
            {
                scientist.ShowScientist();
            }
            if (item is Manager) // Способ №3
            {
                (item as Manager).ShowManager();
            }
        }
    }
}
}