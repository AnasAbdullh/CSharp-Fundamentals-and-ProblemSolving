using System;

namespace StudentManagementSystem
{
class Student
{
    // Fields & Constants
    private static int nextId = 1; // لتوليد أرقام فريدة لكل طالب
    private const int MaxStudents = 100; // عدد الطلاب الأقصى

    // Properties
    public int ID { get; }
    public string Name { get; set; }
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative!");
            _age = value;
        }
    }
    private int _age; // يتم تخزين العمر هنا بعد الفحص

    public double GPA { get; set; } // معدل الطالب

    // Constructor
    public Student(string name, int age, double gpa)
    {
        ID = nextId++;
        Name = name;
        Age = age;
        GPA = gpa;
    }

    // Method to Display Student Info
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID} | Name: {Name} | Age: {Age} | GPA: {GPA:F2}");
    }
}

class Program
{
    // Array to Store Students
    static Student[] students = new Student[MaxStudents];
    static int studentCount = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Find Student by ID");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
            case "1":
                AddStudent();
                break;
            case "2":
                DisplayStudents();
                break;
            case "3":
                FindStudent();
                break;
            case "4":
                DeleteStudent();
                break;
            case "5":
                Console.WriteLine("Exiting... Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
            }
        }
    }

    static void AddStudent()
    {
        if (studentCount >= students.Length)
        {
            Console.WriteLine("Student list is full!");
            return;
        }

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        int age;
        while (true)
        {
            Console.Write("Enter Age: ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0) break;
            Console.WriteLine("Invalid age, please enter a positive integer.");
        }

        double gpa;
        while (true)
        {
            Console.Write("Enter GPA (0 - 4): ");
            if (double.TryParse(Console.ReadLine(), out gpa) && gpa >= 0 && gpa <= 4) break;
            Console.WriteLine("Invalid GPA, must be between 0 and 4.");
        }

        students[studentCount++] = new Student(name, age, gpa);
        Console.WriteLine("Student added successfully!");
    }

    static void DisplayStudents()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        Console.WriteLine("List of Students:");
        foreach (var student in students)
        {
            if (student != null)
                student.DisplayInfo();
        }
    }

    static void FindStudent()
    {
        Console.Write("Enter Student ID to search: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            foreach (var student in students)
            {
                if (student != null && student.ID == id)
                {
                    student.DisplayInfo();
                    return;
                }
            }
            Console.WriteLine("Student not found.");
        }
        else
        {
            Console.WriteLine("Invalid ID format.");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i] != null && students[i].ID == id)
                {
                    for (int j = i; j < studentCount - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    students[--studentCount] = null;
                    Console.WriteLine("Student deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Student not found.");
        }
        else
        {
            Console.WriteLine("Invalid ID format.");
        }
    }
}
}