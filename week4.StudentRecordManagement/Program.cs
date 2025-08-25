using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4.StudentRecordManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentName = new List<string>();
            List<int> studentID = new List<int>();
            List<int> studentGrade = new List<int>();
            bool usingSystem = true;
            while (usingSystem)
            {
                //clear the console
                Console.Clear();
                //create a menu for student record management system
                Console.WriteLine("Student Record Management System");
                Console.WriteLine("1. Add Student Record");
                Console.WriteLine("2. View Student Records");
                Console.WriteLine("3. Remove a Student via ID");
                Console.WriteLine("4. Update Student Information via ID");
                Console.WriteLine("5. View All Students");
                Console.WriteLine("6. Find Student With Highest Grades");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                //Give a switch case for the menu
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Add Student Record
                        Console.Write("Student Name: ");
                        studentName.Add(Console.ReadLine());
                        Console.Write("Student ID: ");
                        studentID.Add(Convert.ToInt32(Console.ReadLine()));
                        if (studentID.Distinct().Count() != studentID.Count())
                        {
                            Console.WriteLine("Student ID must be unique. Press Enter to continue.");
                            studentID.RemoveAt(studentID.Count - 1);
                            studentName.RemoveAt(studentName.Count - 1);
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Student Grade: ");
                        studentGrade.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.ReadLine();
                        break;
                    case 2:
                        //View Student Records
                        Console.Write("Input the student's ID: ");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        int findStudent = studentID.IndexOf(ID);
                        Console.WriteLine();
                        if (findStudent != -1)
                        {
                            Console.WriteLine("Student Name: " + studentName[findStudent]);
                            Console.WriteLine("Student ID: " + studentID[findStudent]);
                            Console.WriteLine("Student Grade: " + studentGrade[findStudent]);
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        //Remove a Student via ID
                        Console.Write("Input the student's ID to remove the student: ");
                        int IDToRemove = Convert.ToInt32(Console.ReadLine());
                        int removeStudent = studentID.IndexOf(IDToRemove);
                        studentName.RemoveAt(removeStudent);
                        studentID.RemoveAt(removeStudent);
                        studentGrade.RemoveAt(removeStudent);
                        Console.WriteLine("Student removed successfully");
                        Console.ReadLine();
                        break;
                    case 4:
                        //Update Student Information
                        Console.Write("Input the student's ID to update the student: ");
                        int IDToUpdate = Convert.ToInt32(Console.ReadLine());
                        int updateStudent = studentID.IndexOf(IDToUpdate);
                        Console.WriteLine("What about the student do you want to edit?\na. Student Name\nb. Student ID\nc. Student Grade");
                        string updateChoice = Console.ReadLine();
                        switch (updateChoice)
                        {
                            case "a":
                                Console.Write("Enter new name: ");
                                studentName[updateStudent] = Console.ReadLine();
                                break;
                            case "b":
                                Console.Write("Enter new ID: ");
                                studentID[updateStudent] = Convert.ToInt32(Console.ReadLine());
                                break;
                            case "c":
                                Console.Write("Enter new grade: ");
                                studentGrade[updateStudent] = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.ReadLine("Invalid choice");
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        //View All Students
                        for (int i = 0; i < studentName.Count; i++)
                        {
                            Console.WriteLine((i+1) + ". " + studentName[i] + ", " + studentID[i] + ", " + studentGrade[i]);
                        }
                        Console.ReadLine();
                        break;
                    case 6:
                        //Find Student With Highest Grades
                        int highestGrade = studentGrade.Max();
                        int highestGradeIndex = studentGrade.IndexOf(highestGrade);
                        Console.WriteLine("Student with highest grade is: " + studentName[highestGradeIndex] + " with a grade of: " + studentGrade[highestGradeIndex]);
                        Console.ReadLine();
                        break;
                    case 7:
                        //Exit
                        Console.ReadLine();
                        usingSystem = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
