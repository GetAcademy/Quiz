using System;

namespace Quiz
{
    internal class Quiz
    {
        private readonly Question[] _questions;
        private int _currentQuestionIndex = -1;
        private int _correctCount = 0;

        public Quiz(Question[] questions)
        {
            _questions = questions;
        }

        public bool IsRunning => _currentQuestionIndex < _questions.Length;

        public void Run()
        {
            _currentQuestionIndex++;
            var question  = _questions[_currentQuestionIndex];
            var isCorrect = question.Run();
            if (isCorrect) _correctCount++;
            ShowStats();
        }

        private void ShowStats()
        {
            Console.WriteLine($"Du har svart på {_currentQuestionIndex+1} spørsmål av totalt {_questions.Length}. Du har {_correctCount} riktige. ");
        }
    }
}
