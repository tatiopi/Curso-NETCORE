using System;

namespace CursoCSharp_9_bodied_members
{
    class Student
    {
        public string Name { get; set }
        public string Surname { get; set; }

        public string FullName { get; set; }
        public string Age { get; set; }

        //public override string ToString()
        //{
        //    return $"{FullName} , {Age}";
        //}

        public override string ToString() => $"{FullName }, {Age }";

        private int age;
        public int Age2
        {
            get => age;
            set => age = value > 0 ? value : throw new ArgumentNullException(nameof(value));
        }

        // Version clasica
        //public Student(string name , string surname , int age)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Age2 = age;
        //}

        // Version BodieMembers
        public Student(string name, string surname, int age) => (Name, Surname, Age2) = (name, surname, age);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }
    class Program
    {


    }
}
