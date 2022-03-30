using System;

namespace Quiz
{
    internal class Question
    {
        private readonly string _question;
        private readonly int _correctAnswerNo;
        private readonly string[] _answers;

        public Question(string question, int correctAnswerNo, params string[] answers)
        {
            _answers = answers;
            _correctAnswerNo = correctAnswerNo;
            _question = question;
        }

        public bool Run()
        {
            Console.WriteLine(_question + "? ");
            ShowAnswers();
            var answerNo = 0;
            while (answerNo < 1 || answerNo > _answers.Length)
            {
                Console.Write("Skriv inn tallet til riktige svaralternativ: ");
                var answerNoStr = Console.ReadLine();
                var isSuccess = int.TryParse(answerNoStr, out answerNo);
                if (!isSuccess) continue;
            }

            var isCorrect = answerNo == _correctAnswerNo;
            Console.WriteLine(isCorrect?"Riktig!":"Feil");
            return isCorrect;
        }

        private void ShowAnswers()
        {
            for (var i = 0; i < _answers.Length; i++)
            {
                var questionNo = i + 1;
                Console.WriteLine($"{questionNo}: {_answers[i]}");
            }
        }
    }
}
