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
        public override string ToString()
        {
            return $"\nФамилия: {_lastName}" +
                $"\nИмя: { _firstName}" +
                $"\nДата рождения:{ _birthDate.ToLongDateString()}";
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
        public override string ToString()
        {
            return base.ToString()
                + $"\nУчебное заведение: { _institution}.";
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
        public override string ToString()
        {
            return base.ToString() + $"\nУчусь в { _groupName} группе.";
        }
    }
    class SchoolChild : Learner
    {
        string _className;
        public SchoolChild(string fName,
        string lName, DateTime date,
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
        public override string ToString()
        {
            return base.ToString() + $"\nУчусь в {_className} классе.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John",
            "Doe", new DateTime(1990, 6, 12),
            "IT Step", "15PPS21");
            WriteLine($"" +
                $"Полное имя типа - " +
                $"{student.GetType().FullName}.");
            WriteLine($"Имя текущего элемента - " +
                $"{ student.GetType().Name}.");
            WriteLine($"Базовый класс текущего элемента - " +
                $"{student.GetType().BaseType}.");
            WriteLine($"Является ли текущий элемент абстрактным объектом - " +
                $"{ student.GetType().IsAbstract}.");
            WriteLine($"Является ли объект классом - " +
                $"{ student.GetType().IsClass}.");
            WriteLine($"Можно ли получить доступ к объекту из кода за пределами сборки - " +
                $"{student.GetType().IsVisible}.");
}
}