
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            List<int> studentGrades = [85, 92, 78, 95, 88, 70, 100, 65];
            Console.WriteLine("\n---- Print Student Grades ----\n");
            Console.Write($"StudentGrades: [ ");
            foreach (int g in studentGrades) { Console.Write($"{g}, "); }
            Console.WriteLine("]");
            Console.WriteLine("\n---- Number of Grades ----\n");
            Console.WriteLine(studentGrades.Count());
            Console.WriteLine("\n---- first and last grade ----\n");
            Console.WriteLine($"First Grade: {studentGrades[0]}");
            Console.WriteLine($"Last Grade: {studentGrades[^1]}");
            Console.WriteLine("\n---- Sort the grades ascending ----\n");
            studentGrades.Sort();
            Console.Write($"StudentGrades: [ ");
            foreach (int g in studentGrades) { Console.Write($"{g}, "); }
            Console.WriteLine("]");
            Console.WriteLine("\n---- first grade above 90 ----\n");
            Console.WriteLine($"the first grade above 90= {studentGrades.Find(n => n > 90)}");
            Console.WriteLine("\n---- all grades below 75 (failing grades) ----\n");
            List<int> failingGrades = studentGrades.FindAll(g => g < 75);
            Console.Write($"FailingGrades: [ ");
            foreach (int g in failingGrades) { Console.Write($"{g}, "); }
            Console.WriteLine("]");
            Console.WriteLine("\n---- ٌRemove all (failing grades) ----\n");
            studentGrades.RemoveAll(g=>g<75);
            Console.Write($"StudentGrades: [ ");
            foreach (int g in studentGrades) { Console.Write($"{g}, "); }
            Console.WriteLine("]");
            Console.WriteLine("\n---- ٌCheck if any grade equals 100 ----\n");
            if (studentGrades.Contains(100))
                WriteLine($"Yes the number in index {studentGrades.IndexOf(100)}");
            else
                WriteLine("The number is not found!!");
            Console.WriteLine("\n---- List String ----\n");
            List<string> stringStudentGrades = new();
            foreach(int g in studentGrades)
            {
                stringStudentGrades.Add("Grade:" + g.ToString());
            }
            foreach(string g in stringStudentGrades)
                Console.WriteLine(g);
        
            #endregion


        }
    }
}
