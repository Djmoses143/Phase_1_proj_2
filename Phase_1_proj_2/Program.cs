using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase_1_proj_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teachers = TeacherManaging.LoadTeacherData();
            while (true)
            {
                Console.WriteLine("Welcome to Rainbow School Teacher Data.");
                Console.WriteLine("1. Display All Teachers");
                Console.WriteLine("2. Add New Teacher");
                Console.WriteLine("3. Update Teacher Data");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your Choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TeacherManaging.DisplayAllTeachers(teachers);
                        break;
                    case 2:
                        TeacherManaging.AddNewTeacher(teachers);
                        break;
                    case 3:
                        TeacherManaging.UpdateTeacherData(teachers);
                        break;
                    case 4:
                        TeacherManaging.SaveTeacherData(teachers);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter correct choice.");
                        break;
                }
                Console.Write("Do you want to continue (y/n)?:");
                string continueChoice = Console.ReadLine();
                if (continueChoice.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
