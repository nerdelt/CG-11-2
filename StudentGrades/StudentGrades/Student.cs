using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace StudentGrades
{
    class Student
    {
        // creates string array for txt file to go into
        public List<string> Students = new List<string>();
        
        //creates a list for all the split strings from Students
        public List<string> SplitList = new List<string>();

        //creates list for scores to go into 
        public List<int> Scores = new List<int>();

        //creates string property to be returned 
        public string Name { get; set; }

        //creates double to find average from scores list
        public double Average { get; set; }

        public void GetStudentData()
        {
            string line;
            //reads txt file and creates list, each line being item in list. 
            using (StreamReader sr = new StreamReader(@"C:\Users\nerdelt\source\repos\CG-11-2\StudentGrades\StudentGrades\studentdata.txt"))
            {
                //while loop to add each line as an element in  list Students
                while ((line = sr.ReadLine()) != null)
                {
                    Students.Add(line);
                }
            }
        }

        public void NameAndAverage()
        {
            // creates loop that....
            foreach (string s in Students)
            {
                //splits each string into smaller strings and adds them to new list
                SplitList = s.Split(' ').ToList();

                // assigns name
                Name = SplitList[0];

                //removes name to just have int
                SplitList.RemoveAt(0);

                //creates a loop to 
                foreach (string n in SplitList)
                    {
                        //Scores.Add(int.Parse(n)); (another way to do this)

                        //coverts strings to int and adds them to int list
                        Scores.AddRange(SplitList.ConvertAll(int.Parse));
                    }
                //finds averages of scores in list
                Average = Scores.Average();

                //clears list 
                Scores = new List<int>();

                //writes each students name and score 
                Console.WriteLine($"{Name} has an average score of {Average}.");
            }
        }


        // I did this but then couldn't figure out how to make it print more than one student's average/ name
        public override string ToString()
        {
            return $"{Name} has an average score of {Average}.";
        }
    }
}







  
































