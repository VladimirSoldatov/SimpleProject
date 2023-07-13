using System;
using static System.Console;
namespace SimpleProject
{
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;
        public Human(string fName, string lName,
        DateTime date)
        {
            _firstName = fName;
            _lastName = lName;
            _birthDate = date;
        }
        public abstract void Think();
        public virtual void Print()
        {
            WriteLine($"" +
                $"\nФамилия: {_lastName}" +
                $"\nИмя: { _firstName}" +
                $"\nДата рождения:{_birthDate.ToLongDateString()}");
        }
    }
    abstract class Learner : Human
    {
        string _institution;
        public Learner(string fName, string lName,
        DateTime date, string institution) :
        base(fName, lName, date)
        {
            _institution = institution;
        }
        public abstract void Study();
        public override void Print()
        {
            base.Print();
            WriteLine($"Учебное заведение:{ _institution}.");
        }
    }
    class Student : Learner
    {
        string _groupName;
        public Student(string fName, string lName,
        DateTime date, string institution,
        string groupName) : base(fName, lName,
        date, institution)
        {
            _groupName = groupName;
        }
        public override void Think()
        {
            WriteLine("Я думаю как студент.");
        }
        public override void Study()
        {
            WriteLine("Я изучаю предметы в институте.");
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Учусь в {_groupName} группе.");
        }
    }
    class SchoolChild : Learner
    {
        string _className;
        public SchoolChild(string fName, string
        lName, DateTime date,
        string institution, string className) :
        base(fName, lName, date, institution)
        {
            _className = className;
        }
        public override void Think()
        {
            WriteLine("Я думаю как школьник.");
        }
        public override void Study()
        {
            WriteLine("Я изучаю предметы в школе.");
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Учусь в {_className} классе.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Learner[] learners =
            {
                new Student("John", "Doe", new DateTime(1990, 6, 12), "IT Step", "15PPS21"),
                new SchoolChild("Jack", "Smith", new DateTime(2008, 4, 18), "School#154", "1-A")
            };
            foreach (Learner item in learners)
            {
                item.Print();
                item.Think();
                item.Study();
            }
        }
    }
}