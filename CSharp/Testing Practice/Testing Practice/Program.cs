using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework1
{
    class Program
    {
        static void Main ()
        {
          
            AddCourseList();
            Student student = new Student();
            student.EnterStudentDetails();
            student.PrintStudentDetails();

        }

        public static void AddCourseList()
        {
            var courses = new List<string>();
            courses.Add("Biology");
            courses.Add("Math");
            Console.WriteLine("CoursesList");
            foreach (string courseName in courses)
            {
                Console.WriteLine(courseName);
            }
        }
    }

    public static class University
    {
        public static void AboutUniversity()
        {
            Console.WriteLine("AboutUniversity");
        }
    }
    
    public class Student
    {
        int age;
        double Note1;
        double Note2;
        double average;
        string? name ="Ioana";
        
        public void EnterStudentDetails()
        {
            
            Console.WriteLine("Enter student name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter student age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first note:");
            Note1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Emter second note:");
            Note2 = Convert.ToDouble(Console.ReadLine());

            average = (Note2 + Note1) / 2;
            
        }
        
        public void PrintStudentDetails()
        {
            
            Console.WriteLine("Student name:" + name);
            Console.WriteLine("Student age:" + age);
            Console.WriteLine("Student's first note" + Note1);
            Console.WriteLine("Student's second note" + Note2);
            Console.WriteLine("Average;" + average);
            
            if (average > 6 && average <= 10)
            {
                Console.WriteLine("Student Passed");
            }
            else if (average >= 1 && average < 5)
            {
                Console.WriteLine("Student failed");
            }
            else
            {
                Console.WriteLine("Invalid Note");
            }

           

            string[] courses = { "Math", "Programming", "Biology", "English" };
          
            int[] mathNotes = new int[3] { 7, 9, 6 };
            int[] programmingNotes = new int[3] { 10, 3, 8 };
            double[] BiologyNotes = new double[5] { 9.2, 3.5, 8.0, 6.4, 5.9 };
            double[] EnglishNotes = new double[4] { 7.4, 5.8, 6.7, 9.8 };

            Console.WriteLine(name + "' s " + courses[0] + " notes are: " + mathNotes[0] + ", " + mathNotes[1] + ", " + mathNotes[2]);
            Console.WriteLine(name + "' s " + courses[1] + " notes are: " + programmingNotes[0] + ", " + programmingNotes[1] + ", " + programmingNotes[2]);
            Console.WriteLine(name + "' s " + courses[2] + " notes are: " + BiologyNotes[0] + ", " + BiologyNotes[1] + ", " + BiologyNotes[2] + ", " + BiologyNotes[3] + ", " + BiologyNotes[4]);
            Console.WriteLine(name + "' s " + courses[3] + " notes are: " + EnglishNotes[0] + ", " + EnglishNotes[1] + ", " + EnglishNotes[2] + ", " + EnglishNotes[3]);

            Console.WriteLine("Max biology note: " + BiologyNotes.Max());
            Console.WriteLine("Min programming note:" + programmingNotes.Min());
            Console.WriteLine("Math average: " + mathNotes.Sum() / 3);
            Console.WriteLine("Biology average: " + BiologyNotes.Sum() / 4);

            //Array Sort
            Array.Sort(BiologyNotes);
            foreach (double arrayValue in BiologyNotes)
            {
                Console.WriteLine(arrayValue);
            }
            Array.Sort(courses);
            foreach (string arrayValue in courses)
            {
                Console.WriteLine(arrayValue);
            }
            //Multidimensional array
            int[,] notes = { { 1, 3, 10 }, { 2, 4, 6 } };
            Console.WriteLine(notes[0, 2]);
            notes[0, 0] = 5;
            Console.WriteLine(notes[0, 0]);
            foreach (int i in notes)
            {
                Console.WriteLine("Array value: " + i);
            }

            // Get array Length
            for (int i = 0; i < BiologyNotes.GetLength(0); i++)
            {
                int J = BiologyNotes.GetLength(0);
                Console.WriteLine("Biology notes array length: " + J);
                break;
            }
            int totalStudentsNotes = 5;
            int[] note = new int[totalStudentsNotes];
            for (int i = 0; i < totalStudentsNotes; i++)
            {
                Console.WriteLine("Emter note:" + i);
                note[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Reverse number //
            Console.WriteLine("Reverse note list: ");
            Array.Reverse(mathNotes);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" {0} ", mathNotes[i]);
            }
            

            var Students = new List<string>() { "Mihai", "Cristina" };
            // Console.WriteLine(students); // Incorect
            Console.WriteLine("Students Lists: ");
            foreach(string StudentName in Students)
            {
                Console.WriteLine(StudentName);
            }
            Students.Add("Mirela");
            Students.Add("Andrei");
            Console.WriteLine("Students new list: ");
            foreach (string StudentName in Students)
            {
                Console.WriteLine(StudentName); 
            }
            var groupOfStudents = new List<int>() { 12, 28, 33 };
            Console.WriteLine("Total number of atudents:" + groupOfStudents.Sum());
            Console.WriteLine("Groups total: " + groupOfStudents.Count());
            

            try
            {
                string[] studentsNames = { "Mihaela", "Stefan", "Alina" };
                Console.WriteLine(studentsNames[2]);
            }
            catch
            {
                Exception e;
                Console.WriteLine("\nSomething went wrong. The stundent does not exist.");
            }
        }

    }
}
















