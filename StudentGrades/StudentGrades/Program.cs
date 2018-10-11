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

            List<string> students = new List<string>();

            string line;

            //reads txt file and creates list, each line being item in list. 
            using (StreamReader sr = new StreamReader(@"C:\Users\nerdelt\source\repos\CG-11-2\StudentGrades\StudentGrades\studentdata.txt"))
            {
                //while loop to add each line as an element in  list Students
                while ((line = sr.ReadLine()) != null)
                {
                    students.Add(line);
                }
            }

            //goes through text file, assigns student's name and average and prints 
            student.NameAndAverage(students);

            Console.ReadLine();

      
            }
        }
    }
 
