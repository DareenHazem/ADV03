using System.Collections;

namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            ////1-
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            ////2-
            //Print.PrintList("List",grades);
            //Console.WriteLine($"Grades Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades[0]}, Last Grade: {grades[^1]}");
            ////3-
            //grades.Sort();
            //Print.PrintList("Sorted List", grades);
            ////4 
            //Console.WriteLine($"First grade above 90: {grades.Find(x => x > 90)}");
            ////5
            //List<int> failingGrades = grades.FindAll(x => x <75);
            //Print.PrintList("Grades below 75",failingGrades);
            ////6
            //grades.RemoveAll(x => x < 75);
            //Print.PrintList("Grades below 75 after being removed", grades);
            ////7
            //Console.WriteLine($"Is any grade equals 100? {grades.Contains(100)}");
            ////8
            //List<string> gradeStrings = grades.ConvertAll(n=>$"Grade: {n}");
            //Print.PrintList("List of String", gradeStrings);
            #endregion

            #region Exercise 2: Leaderboard
            ////1-
            //SortedDictionary<int, string> playersScore = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};
            ////2-
            //Print.PrintDictionary("orderd", playersScore);
            ////3-
            //Console.WriteLine($"The first key and first value: {playersScore.First()}");
            ////4-
            //Console.WriteLine($"Does score 500 exist? {playersScore.ContainsKey(500)}");
            ////5-
            //Console.WriteLine($"Safely get the player with score 999: {playersScore.TryGetValue(999,out string val)}, The value (if it exists) = {val??"Null"}");
            ////6-
            //playersScore.Remove(200);
            //Print.PrintDictionary("After removing key 200", playersScore);
            #endregion

            #region Exercise 3: Phone Book
            ////1-
            //Dictionary<string, int> contacts = new()
            //{
            //    ["Ahmed"] = 01023585,
            //    ["Sara"] = 01147896,
            //    ["Ali"] = 0107895,
            //    ["Mona"] = 01258943
            //};
            ////2-
            //contacts["Dareen"] = 01245783;
            ////3-
            //try
            //{
            //    contacts.Add("Dareen", 01245783);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            ////4-
            //Console.WriteLine($"TryAdd: {contacts.TryAdd("Dareen", 01245783)}");
            ////5-
            //Console.WriteLine($"Does it contains the key 'Mahmoud'? {contacts.ContainsKey("Mahmoud")}");
            //Console.WriteLine($"Does it contains the value '01234567'? {contacts.ContainsValue(01234567)}");
            ////6-
            //if (contacts.TryGetValue("Mahmoud", out int phone))
            //    Console.WriteLine(phone);
            //else
            //    Console.WriteLine("Not Found");
            ////7-
            //Print.PrintDict(contacts);
            #endregion

            #region Exercise 4: Unique Email Validator
            ////1-2
            //HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase) {
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};
            ////3-
            //Console.WriteLine($"Emails Count:{emails.Count}");
            ////It will be 2 because add in the constructor StringComparer that will ignore the capital case

            ////4-
            //HashSet<int> A = [ 1, 2, 3, 4, 5 ];
            //HashSet<int> B = [ 4, 5, 6, 7, 8 ];

            ////5-
            //A.UnionWith(B);
            //Print.PrintHashSet("UnionWith", A);

            //A.IntersectWith(B);
            //Print.PrintHashSet("IntersectWith", A);

            //A.ExceptWith(B);
            //Print.PrintHashSet("ExceptWith", A);

            ////6-
            //HashSet<int> C = [1, 2];
            //Console.WriteLine($"Check if (1,2) is a subset of Set A: { A.IsSubsetOf(C) }");
            #endregion

            #region Exercise 5: Print Queue Simulator
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Report.pdf");
            //queue.Enqueue("Invoice.pdf");
            //queue.Enqueue("Letter.docx");
            //queue.Enqueue("Resume.pdf");
            //queue.Enqueue("Photo.jpg");
            ////1-
            //Console.WriteLine($"Count: {queue.Count}");
            //Print.PrintQueue("Queue",queue);

            ////2-
            //Console.WriteLine($"First Element: {queue.Peek()}");

            ////3-
            //while (queue.Count > 0) {
            //    Console.WriteLine($"Printing[{queue.Dequeue()}]");
            //}

            ////4-
            //Console.WriteLine($"Dequeue on empty Queue: {queue.TryDequeue(out string? val)}");
            #endregion
        }
    }
}
