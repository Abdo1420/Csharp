
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //List<int> studentGrades = [85, 92, 78, 95, 88, 70, 100, 65];
            //Console.WriteLine("\n---- Print Student Grades ----\n");
            //Console.Write($"StudentGrades: [ ");
            //foreach (int g in studentGrades) { Console.Write($"{g}, "); }
            //Console.WriteLine("]");
            //Console.WriteLine("\n---- Number of Grades ----\n");
            //Console.WriteLine(studentGrades.Count());
            //Console.WriteLine("\n---- first and last grade ----\n");
            //Console.WriteLine($"First Grade: {studentGrades[0]}");
            //Console.WriteLine($"Last Grade: {studentGrades[^1]}");
            //Console.WriteLine("\n---- Sort the grades ascending ----\n");
            //studentGrades.Sort();
            //Console.Write($"StudentGrades: [ ");
            //foreach (int g in studentGrades) { Console.Write($"{g}, "); }
            //Console.WriteLine("]");
            //Console.WriteLine("\n---- first grade above 90 ----\n");
            //Console.WriteLine($"the first grade above 90= {studentGrades.Find(n => n > 90)}");
            //Console.WriteLine("\n---- all grades below 75 (failing grades) ----\n");
            //List<int> failingGrades = studentGrades.FindAll(g => g < 75);
            //Console.Write($"FailingGrades: [ ");
            //foreach (int g in failingGrades) { Console.Write($"{g}, "); }
            //Console.WriteLine("]");
            //Console.WriteLine("\n---- ٌRemove all (failing grades) ----\n");
            //studentGrades.RemoveAll(g=>g<75);
            //Console.Write($"StudentGrades: [ ");
            //foreach (int g in studentGrades) { Console.Write($"{g}, "); }
            //Console.WriteLine("]");
            //Console.WriteLine("\n---- ٌCheck if any grade equals 100 ----\n");
            //if (studentGrades.Contains(100))
            //    WriteLine($"Yes the number in index {studentGrades.IndexOf(100)}");
            //else
            //    WriteLine("The number is not found!!");
            //Console.WriteLine("\n---- List String ----\n");
            //List<string> stringStudentGrades = new();
            //foreach(int g in studentGrades)
            //{
            //    stringStudentGrades.Add("Grade:" + g.ToString());
            //}
            //foreach(string g in stringStudentGrades)
            //    Console.WriteLine(g);


            #endregion

            #region Exercise 2: Leaderboard
            //SortedList<int, string> leaderboard = new();
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");
            //Console.WriteLine("==== Print All Players Score ====\n");
            //foreach (KeyValuePair<int, string> l in leaderboard)
            //    Console.WriteLine(l);
            //Console.WriteLine("\n==== first key and first value ====\n");
            //Console.WriteLine($"First key: {leaderboard.Keys[0]}");
            //Console.WriteLine($"First value: {leaderboard.Values[0]}");
            //Console.WriteLine("\n==== Check if score 500 exists ====\n");
            //if (leaderboard.ContainsKey(500))
            //    Console.WriteLine($"Found key in index {leaderboard.IndexOfKey(500)}");
            //else
            //    Console.WriteLine("The key is not found!!");

            //Console.WriteLine("\n==== Safely get the player with score 999 ====\n");
            //string? value = null;
            //leaderboard.TryGetValue(999, out value);
            //Console.WriteLine($"player with score 999: {value}");

            //Console.WriteLine("\n==== Remove the player with score 200 ====\n");
            //leaderboard.Remove(200);
            //foreach (KeyValuePair<int, string> l in leaderboard)
            //    Console.WriteLine(l);



            #endregion

            #region Exercise 3: Phone Book
            //Console.WriteLine("==== Create phone book application ====\n");
            //Dictionary<string, string> phoneBook =new(4);
            //phoneBook["Ahmed"] = "75395147";
            //phoneBook["Abdo"] = "85295175";
            //phoneBook["Doha"] = "96374185";
            //phoneBook["Ali"] = "45698712";
            //Console.WriteLine("\n==== Add a new contact using [] syntax ====\n");
            //phoneBook["Salma"] = "35862478";
            //Console.WriteLine("\n==== Try adding a duplicate using .Add() ====\n");
            //try { phoneBook.Add("Ali", "45698712"); }
            //catch{
            //    Console.WriteLine("This key already exists.");
            //}
            //Console.WriteLine("\n==== Try adding a duplicate using .TryAdd() ====\n");
            //if (phoneBook.TryAdd("Ahmed", "75395147"))
            //    Console.WriteLine("Adding Sucssful..");
            //else
            //    Console.WriteLine("The addition failed..");
            //Console.WriteLine("\n==== Search for a contact that doesn’t exist ====\n");
            //if (phoneBook.ContainsKey("Salma"))
            //    Console.WriteLine($"The contact is found...");
            //else
            //    Console.WriteLine("The contact not found...");
            //Console.WriteLine("\n==== Get a contact with a fallback of Not Found ====\n");
            //string? contact = phoneBook.GetValueOrDefault("Hany");
            //if(contact==null)
            //    Console.WriteLine("Not Found...");
            //else
            //    Console.WriteLine($"Salma :{phoneBook["Salma"]}");
            //Console.WriteLine("\n====  all Keys and all Values ====\n");
            //Console.Write($"Keys: ");
            //foreach (var item in phoneBook)
            //{
            //    Console.Write($" {item.Key} - ");
            //}
            //Console.Write($"\nValues: ");
            //foreach (var item in phoneBook)
            //{
            //    Console.Write($" {item.Value} - ");
            //}



            #endregion

            #region Exercise 4: Unique Email Validator
            //HashSet<string> email=new(StringComparer.OrdinalIgnoreCase);
            //email.Add("ahmed@test.com");
            //email.Add("AHMED@test.com");
            //email.Add("sara@test.com");
            //email.Add("Sara@Test.Com");
            //Console.WriteLine("=============\n");
            //Console.WriteLine(email.Count()); 
            //Console.WriteLine("count = 2 becose (StringComparer.OrdinalIgnoreCase) must hashset not deffrant capital or small and hashset storeg elemants unique not allow duplecit");
            //Console.WriteLine("\n=============\n");
            //HashSet<int> setA = [1, 2, 3, 4, 5];
            //HashSet<int> setB = [4, 5, 6, 7, 8];
            //Console.WriteLine("\n====== (setA)UnionWith(setB) =======\n");
            //HashSet<int> union = new(setA);
            //union.UnionWith(setB);
            //Console.Write("UnionWith:");
            //foreach(int u in union) { Console.Write($"{u} - "); }
            //Console.WriteLine("\n\n====== (setA)IntersectWith(setB) =======\n");
            //HashSet<int> inter = new(setA);
            //inter.IntersectWith(setB);
            //Console.Write("IntersectWith:");
            //foreach (int u in inter) { Console.Write($"{u} - "); }
            //Console.WriteLine("\n\n====== (setA)ExceptWith(setB) =======\n");
            //HashSet<int> except = new(setA);
            //except.ExceptWith(setB);
            //Console.Write("ExceptWith:");
            //foreach (int u in except) { Console.Write($"{u} - "); }
            //Console.WriteLine( );
            //HashSet<int> newNumpars = [1, 2];
            //Console.WriteLine("\n=============\n");
            //Console.WriteLine($"[1,2] is a subset of setA = {newNumpars.IsSubsetOf(setA)}");
            #endregion

            #region Exercise 5: Print Queue Simulator
            Queue<string> printer = new();
            printer.Enqueue("Report.pdf");
            printer.Enqueue("Invoice.pdf");
            printer.Enqueue("Letter.docx");
            printer.Enqueue("Resume.pdf");
            printer.Enqueue("Photo.jpg");
            Console.WriteLine("==== print contents and Count ====\n");
            foreach (var item in printer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Count= {printer.Count}");
            Console.WriteLine("\n==== print next (without removing)  ====\n");
            Console.WriteLine(printer.Peek());
            Console.WriteLine("\n==== Process the queue  ====\n");
            do
            {
                Console.WriteLine($"Printing: [{printer.Peek()}]");
                printer.Dequeue();
            }
            while (printer.Capacity!=0);
            Console.WriteLine("\n====  empty queue  ====\n");
           // Exption error becose printer is empty compile not found elemant for Dequeue
            #endregion

            #region Exercise 6: Browser History (Undo)

            #endregion
        }
    }
}
