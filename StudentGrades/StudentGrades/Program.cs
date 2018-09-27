using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates new student object
            Student student = new Student();

            Console.WriteLine("To display the quiz scores averages of each student, Please press ENTER.");

            //this allows user to press enter 
            Console.ReadLine();

            //reads the text file 
            student.GetStudentData();

            //goes through text file, assigns student's name and average and prints 
            student.NameAndAverage();

            Console.ReadLine();

        }
    }
}
