using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            //Ask the user to input student name, student ID, and number of subjects
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            string studentID = Console.ReadLine();
            Console.Write("Enter the number of subjects: ");
            int subjectsCount = Convert.ToInt32(Console.ReadLine());

            //Initialize a variable name totalGrades to 0.0
            double totalGrades = 0.0;

            //Looping statement to get the grades of each subject input by the user 
            for (int i = 1; i <= subjectsCount; i++)
            {
                /* Prompt user to enter grade for each subject based on its subjects counts
                 and add all to get total grades*/
                Console.WriteLine($"Enter grade for subject {i}: ");
                double gradeSubject = Convert.ToDouble(Console.ReadLine());
                totalGrades += gradeSubject;
            }

            //Calculate the average grade by dividing the total grades by the number of subjects
            double averageGrade = totalGrades / subjectsCount;
            //Use Math.Round method for rounding the average to its nearest whole number
            double roundedAverage = Math.Round(averageGrade);

            //Display the average grade in two decimal places and rounded average
            Console.WriteLine("======================================");
            Console.WriteLine($"Average grade: {averageGrade:F2}\n" +
                              $"Round off to {roundedAverage}");
            Console.WriteLine("======================================");

            //Declare a variable performance that will use later for remarks
            string performance;
            //Determine the performance based on the rounded average grade
            if (roundedAverage >= 75)
            {
                //Rounded average that is greater than or equal to 75
                performance = "Passed";
                if (roundedAverage >= 98 && roundedAverage <= 100)
                {
                    Console.WriteLine("\t   With Highest Honors");
                }
                else if (roundedAverage >= 95 && roundedAverage <= 97)
                {
                    Console.WriteLine("\t   With High Honors");
                }
                else if (roundedAverage >= 90 && roundedAverage <= 94)
                {
                    Console.WriteLine("\t   With Honors");
                }
            }
            else
            {
                ////Rounded average less than 75
                performance = "Failed";
            }

            /* Display the final Student Performance Report including student name, 
             student ID, number of subjects, average grade, and remarks */
            Console.WriteLine("======================================\n");
            Console.WriteLine("\n----- Student Performance Report ----- ");
            Console.WriteLine($"Student Name\t\t{studentName}\n" +
                              $"Student ID\t\t{studentID}\n" +
                                $"Number of subjects\t{subjectsCount}\n" +
                               $"Average Grade\t\t{roundedAverage}\n" +
                                $"Remarks\t\t\t{performance}\n");

        }
    }
}
