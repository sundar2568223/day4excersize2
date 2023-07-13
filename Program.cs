using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] studmarks = new int[4, 6];
            //for(int i = 0; i < 4;i++)
            //{
            //    Console.WriteLine($"Enter Student {i+1}\'s Roll Number");
            //    studmarks[i,0] = int.Parse( Console.ReadLine() );
            //    for(int j = 1; j < 6; j++)
            //    {

            //        Console.WriteLine($"Enter marks of Student\'s{i+1} in sem\'{j-1} Tota");
            //        studmarks[i,j] = int.Parse( Console.ReadLine() );
            //    }
            //}
            //Console.WriteLine("Marks as follows");
            //Console.WriteLine("Rollno\tsem1\tsem2\tsem3\tsem4\tTotal");
            //for(int i = 0;i < 4; i++)
            //{
            //    for(int j=0; j < 6; j++)
            //    {
            //        Console.Write(studmarks[i,j]+"\t" );
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();
                // Create a rectangular array to store roll numbers and marks
                int[,] studMarks = new int[4, 4];

                // Get input for roll numbers and marks
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Enter Roll No for Student {0}: ", i + 1);
                    int rollNo = int.Parse(Console.ReadLine());

                    // Store roll number in the array
                    studMarks[i, 0] = rollNo;

                    // Get marks for semesters 2, 3, and 4
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Enter Marks for Semester {0}: ", j + 1);
                        int marks = int.Parse(Console.ReadLine());

                        // Store marks in the array
                        studMarks[i, j] = marks;
                    }
                }

                // Print the details
                Console.WriteLine("Roll No\tSem1\tSem2\tSem3\tSem4\tTotal");

                for (int i = 0; i < 4; i++)
                {
                    int rollNo = studMarks[i, 0];
                    int totalMarks = 0;

                    Console.Write(rollNo + "\t");

                    for (int j = 0; j < 4; j++)
                    {
                        int marks = studMarks[i, j];
                        Console.Write(marks + "\t");

                        // Calculate total marks
                        totalMarks += marks;
                    }

                    Console.WriteLine(totalMarks);
    }
        }
    }
}


