using System;

namespace Quiz
{
    internal class Question
    {
        private readonly string _question;
        private readonly int _correctAnswerNo;
        private int _currentAnswerNo = 1;
        private readonly string[] _answers;

        public Question(string question, int correctAnswerNo, params string[] answers)
        {
            _answers = answers;
            _correctAnswerNo = correctAnswerNo;
            _question = question;
        }

        private void Show()
        {
            Console.WriteLine(_question + "? ");
            Console.WriteLine("Trykk TAB for å bytte svar, ENTER for å svare.");
            ShowAnswers();
        }

        public bool Run()
        {
            Show();
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Tab)
                {
                    _currentAnswerNo++;
                    if (_currentAnswerNo > _answers.Length) _currentAnswerNo = 1;
                    Console.Clear();
                    Show();
                }
            } while (key != ConsoleKey.Enter);
            var isCorrect = _currentAnswerNo == _correctAnswerNo;
            Console.WriteLine(isCorrect ? "Riktig!" : "Feil");
            return isCorrect;
        }

        private void ShowAnswers()
        {
            for (var i = 0; i < _answers.Length; i++)
            {
                var questionNo = i + 1;
                if (questionNo == _currentAnswerNo)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{questionNo}: {_answers[i]}");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
