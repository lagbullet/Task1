using System;

namespace StudentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student = new Student("SurName", "FirstName", "Patronymic", "2000-01-01");
            Student.SetMark("subject1", 10);
            Student.SetMark("subject2", 8);
            Student.SetMark("subject3", 5);
            Student.SetMark("subject4", 6);
            Student.Show();
            Console.ReadKey();
            Console.WriteLine("AVG MArk --> " + Student.GetAvgMark());
            Console.WriteLine("");
            Console.WriteLine("");
            Student.ResetAllMarks();
            Student.Show();
            Console.ReadKey();
        }
    }
}