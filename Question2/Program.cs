using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student 1 name: ");
            Student studentOne = new Student(Console.ReadLine());

            Console.Write("Enter Student 2 name: ");
            Student studentTwo = new Student(Console.ReadLine());

            Console.Write("Enter Teacher's name: ");
            Teacher teacherN = new Teacher(Console.ReadLine());

            Person[] names  = {studentOne, studentTwo, teacherN};

           Console.WriteLine($"\n{studentOne.Study()}.");
           Console.WriteLine($"{studentTwo.Study()}.");
           Console.WriteLine($"{teacherN.Explain()}.");
        }
    }
}