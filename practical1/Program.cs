using System;

namespace StudentManagementSystem
{
    class Student
    {
        private string name;
        private int age;
        private double marks;
        private string branch;
        private double fee;
        private bool hostel;
        private double scholarship;
        private double finalFee;

        public Student(string name, int age, double marks)
        {
            this.name = name;
            this.age = age;
            this.marks = marks;
        }

        public void Admission()
        {
            if (marks < 60)
            {
                Console.WriteLine("\nSorry! You are NOT eligible for admission.");
                return;
            }

            Console.WriteLine("\nCongratulations! You are eligible for admission.");

            Console.WriteLine("\nSelect Engineering Branch");
            Console.WriteLine("1. Computer Engineering      - $5000");
            Console.WriteLine("2. Information Technology    - $4800");
            Console.WriteLine("3. Mechanical Engineering    - $4500");
            Console.WriteLine("4. Civil Engineering         - $4200");
            Console.WriteLine("5. Electrical Engineering    - $4600");

            Console.Write("\nEnter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    branch = "Computer Engineering";
                    fee = 5000;
                    break;

                case 2:
                    branch = "Information Technology";
                    fee = 4800;
                    break;

                case 3:
                    branch = "Mechanical Engineering";
                    fee = 4500;
                    break;

                case 4:
                    branch = "Civil Engineering";
                    fee = 4200;
                    break;

                case 5:
                    branch = "Electrical Engineering";
                    fee = 4600;
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            Console.Write("\nHostel Accommodation Required? (yes/no): ");
            string option = Console.ReadLine().ToLower();

            hostel = option == "yes";

           
            if (marks > 90)
                scholarship = 100;
            else if (marks >= 70)
                scholarship = 40;
            else
                scholarship = 0;

            finalFee = fee - (fee * scholarship / 100);

            Display();
        }

        public void Display()
        {
            Console.WriteLine("\n=========== ADMISSION DETAILS ===========");

            Console.WriteLine("Student Name       : " + name);
            Console.WriteLine("Age                : " + age);
            Console.WriteLine("Marks              : " + marks + "%");
            Console.WriteLine("Selected Branch    : " + branch);
            Console.WriteLine("Original Fee       : $" + fee);
            Console.WriteLine("Scholarship        : " + scholarship + "%");
            Console.WriteLine("Final Fee          : $" + finalFee);

            if (hostel)
                Console.WriteLine("Hostel             : YES");
            else
                Console.WriteLine("Hostel             : NO");

            Console.WriteLine("=========================================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine(" STUDENT MANAGEMENT SYSTEM ");
            Console.WriteLine("====================================");

            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks (%) : ");
            double marks = Convert.ToDouble(Console.ReadLine());

            Student s1 = new Student(name, age, marks);

            s1.Admission();

            Console.WriteLine("\nPress Enter to Exit...");
            Console.ReadLine();
        }
    }
}
