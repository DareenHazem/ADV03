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
        }
    }
}
