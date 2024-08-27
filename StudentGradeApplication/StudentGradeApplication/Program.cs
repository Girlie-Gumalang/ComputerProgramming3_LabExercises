using System;

namespace StudentGradeApplication
{

    class frmStudentGradeProgram
    {

        static void Main(string[] args)
        {

            // Ask user to enter his/her name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Arrays for storing value of subjects and grades
            string[] subjects = { "English", "Mathematics", "Science", "Filipino", "History" };
            double[] grades = new double[subjects.Length]; //5

            // Loop for input grades in each subjects
            for (int i = 0; i < subjects.Length; i++)
            {
                //declare a variable that will use later
                double grade;
                // Make sure that user will input a number grade between 0 and 100
                do
                {
                    Console.Write("Enter your " + subjects[i] + " grade: ");
                    grade = Convert.ToDouble(Console.ReadLine());

                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Try Again! Grade must be between 0 and 100.");
                    }
                } while (grade < 0 || grade > 100); // Repeat if the user does not input correct value

                grades[i] = grade; // Each value of grade will store in array of grades
            }

            // Display name of student
            Console.WriteLine("____________________________");
            Console.WriteLine("Student Grade Application");
            Console.WriteLine($"\nName: {name}");

            // Display grades for each subject
            Console.WriteLine("\n\t\t\tGrades");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i] + ":\t\t" + grades[i]);
            }

            // Declare variable answer
            string answer;
            // Ask the user if s/he wants to generate the average
            do
            {
                Console.Write("\nDo you want to generate your average? (yes/no): ");
                answer = Console.ReadLine().ToLower(); //answer will convert in lower case

                if (answer == "yes")
                {
                    double total = 0.0;

                    // Compute total grades by adding grade for each subject
                    for (int i = 0; i < grades.Length; i++)
                    {
                        total += grades[i];
                    }

                    // Calculate and generate average in two decimal places
                    double average = total / grades.Length;
                    Console.WriteLine($"Average: {average:F2}");

                    // Condition for passed for failed
                    if (average >= 75)
                    {
                        Console.WriteLine("\n\t\tThe student passed.\n" +
                                       $"\tThe general average of {name} is {average:F2}");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\tThe student failed.\n" +
                                        $"\tThe general average of {name} is {average:F2}");
                    }
                }
                else if (answer == "no")
                { // result if the user's answer is no
                    Console.WriteLine("You declined to generate the average.");
                }
                else
                { // If the user input is other than yes or no
                    Console.WriteLine("Invalid input! Please enter \"yes\" or \"no\".");
                    /* backslash (\) is the escape character if you want to use double 
                    quotation for emphasizing a word */
                }

            } while (answer != "yes" && answer != "no"); // repeat until the user answers yes or no
        }
    }
}