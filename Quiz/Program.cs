using System;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quiz = new Quiz(new[]
            {
                new Question(
                    "Hva er hovedstaden i Norge", 
                    3, 
                    "Bergen", "Trondheim", "Oslo"),
                new Question(
                    "Hva er hovedstaden i Sverige", 
                    1, 
                    "Stockholm", "Gøteborg", "Malmø", "Umeå"),
                new Question(
                    "Hva er hovedstaden i Danmark", 
                    2, 
                    "Aarhus", "København"),
            });
            while (quiz.IsRunning)
            {
                quiz.Run();
            }
            Console.WriteLine("Quizen er ferdig");
        }
    }
}
