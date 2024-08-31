using System;
using System.IO;

namespace StudentRegistration
{
    internal class StudentRegistrationProgram
    {
        static void Main(string[] args)
        {
            // Array of required files to proceed with enrollment
            string[] requiredFiles = new string[]
            {
                "Form137.pdf",
                "GoodMoral.pdf",
                "PSA.pdf",
                "MedicalCertificate.pdf"
            };

            // Set the tuition fee for constant as this is the amount to be paid for all courses
            const double TUITION_FEE = 32000.00;

            // Display admission requirements to enroll 
            Console.WriteLine("Welcome to the STI College Enrollment System!\n\n" +
                   "=============== ADMISSION REQUIREMENTS ===============" +
                   "\nNote: File names in your directory must have a .pdf extension\n");

            // Display the four (4) required files in the array 
            foreach (string file in requiredFiles)
            {
                Console.WriteLine(file);
            }

            // Loop the program until the user chooses to exit or the program ends
            while (true)
            {
                // Ask if the user wants to enroll by answering yes or no 
                Console.Write("\nDo you want to enroll? (yes/no): ");
                string enrollResponse = Console.ReadLine().ToLower(); // Response will be converted to lower case

                // Exit the program if the enroll response is no 
                if (enrollResponse == "no")
                {
                    Console.WriteLine("Thank you for using this enrollment system!");
                    return; // Terminate the program 
                }
                // Prompt if the answer is neither yes nor no
                else if (enrollResponse != "yes")
                {
                    Console.WriteLine("Invalid input. Please answer with \"yes\" or \"no\".");
                    continue; // Ask again if the user wants to enroll
                }

                /* These are files that are located on your computer. The value will vary from every user
                 since it depends on what their directory contains */
                Console.Write("Enter your directory path: ");
                string directoryPath = Console.ReadLine();

                Console.WriteLine("\nChecking for required documents...");

                bool allFilesExist = true;
                string missingFiles = "";

                // Loop for checking each required file
                foreach (string file in requiredFiles)
                {
                    // Combine directory path and file name to get the full path
                    string filePath = Path.Combine(directoryPath, file);

                    while (true)
                    {
                        // Ask the user if they have the file, loop until valid input is given
                        Console.Write($"\nDo you have {file}? (yes/no): ");
                        string checkFile = Console.ReadLine().ToLower();

                        if (checkFile == "no")
                        {
                            Console.WriteLine($"You indicated that you do not have {file}.");

                            // Even if the user said "no", we still verify if the file is in the directory
                            if (File.Exists(filePath))
                            {
                                Console.WriteLine($"However, {file} exists in the directory.");
                            }
                            else
                            {
                                Console.WriteLine($"{file} does not exists in the directory.");
                                missingFiles += file + "\n"; // Count by listing the missing files
                                allFilesExist = false;
                            }

                            break; // Valid input, exit the loop to proceed with checking the next file
                        }
                        else if (checkFile == "yes")
                        {
                            Console.WriteLine($"You indicated that you have {file}.");

                            // Check if the file really exists in the directory
                            if (File.Exists(filePath))
                            {
                                Console.WriteLine($"File {file} exists in the directory.");
                            }
                            else
                            {
                                Console.WriteLine($"However, {file} does not exists in the directory.");
                                missingFiles += file + "\n"; // Count by listing the missing files
                                allFilesExist = false;
                            }

                            break; // Exit the loop if already satisfy condition 
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please answer with 'yes' or 'no'.");
                            // Continue asking the user if s/he provide answer other than yes or no
                        }
                    }
                }

                // If all the required files exist, proceed with the registration process
                if (allFilesExist)
                {
                    Console.WriteLine("\nAll required documents are present." +
                                      "\nYou can proceed with the registration.");

                    // Display college programs offer
                    Console.WriteLine("\n================== COLLEGE PROGRAMS ==================\n");
                    Console.WriteLine("[1] Bachelor of Science in Information Technology (BSIT)\n" +
                                      "[2] Bachelor of Science in Computer Science (BSCS)\n" +
                                      "[3] Bachelor of Science in Computer Engineering (BSCPE)\n" +
                                      "[4] Bachelor of Science in Information Systems (BSIS)\n");

                    string courseChoice; // Declare variable for selection
                    while (true)
                    {
                        // Get the desired program/course of the user
                        Console.Write("Enter the number of your desired course [1-4]: ");
                        courseChoice = Console.ReadLine();

                        if (courseChoice == "1")
                        {
                            courseChoice = "Bachelor of Science in Information Technology (BSIT)";
                            break;
                        }
                        else if (courseChoice == "2")
                        {
                            courseChoice = "Bachelor of Science in Computer Science (BSCS)";
                            break;
                        }
                        else if (courseChoice == "3")
                        {
                            courseChoice = "Bachelor of Science in Computer Engineering (BSCPE)";
                            break;
                        }
                        else if (courseChoice == "4")
                        {
                            courseChoice = "Bachelor of Science in Information Systems (BSIS)";
                            break;
                        }
                        else
                        {
                            // Ask the user again to input a number from 1 to 4 for college courses
                            Console.WriteLine("Invalid choice! Please input a number ranging from (1-4).");
                        }
                    }

                    Console.Write("Enter your first name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter your last name: ");
                    string lastName = Console.ReadLine();

                    // Combine first name and last name 
                    string studentName = firstName + " " + lastName;

                    // Convert student name to capital or upper case letters
                    studentName = studentName.ToUpper();

                    Console.WriteLine($"The tuition fee is {TUITION_FEE}.");

                    while (true)
                    {
                        try
                        {
                            // Ask the user how much s/he will pay
                            Console.Write("Enter the amount of money you wish to pay: ");
                            double paymentAmount = Convert.ToDouble(Console.ReadLine());

                            if (paymentAmount < TUITION_FEE)
                            {
                                // Amount is insufficient
                                Console.WriteLine($"Insufficient funds!\n" +
                                                  "You cannot proceed with enrollment.");
                                continue;  // Ask the user again to input money for payment
                            }
                            else if (paymentAmount > TUITION_FEE)
                            {
                                // Calculate and display the change if the payment is more than the tuition fee
                                double change = paymentAmount - TUITION_FEE;
                                Console.WriteLine($"\nPaid Amount:\t\t{paymentAmount}\n" +
                                                  $"Change:\t\t\t{change}");
                            }
                            else if (paymentAmount == TUITION_FEE)
                            {
                                // Display if the payment amount is the same value as the tuition fee
                                Console.WriteLine("Payment is exact.\n" +
                                                  "Your balance is 0.00");
                            }

                            // Terminate the loop for valid payment
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                            continue;  // Back to the question of the amount to be paid
                        }
                    }

                    // Display student details including student name and program
                    Console.WriteLine($"\nYou have successfully enrolled.");
                    Console.WriteLine("\n=================  STUDENT DETAILS  =================\n");
                    Console.WriteLine($"Name:\t\t{studentName}\n" +
                                      $"Program:\t{courseChoice}");

                }
                // Enrollment will be canceled even if one file is missing 
                else
                {
                    Console.WriteLine("\nEnrollment failed! Please make sure all required documents are exists." +
                                      "\nMissing Files:");
                    Console.WriteLine(missingFiles); // Display the missing files
                }

                Console.WriteLine("\n\t\tThank you for inquiring!\n");
                return; // Exit the program either successful or failed registration
            }
        }
    }
}