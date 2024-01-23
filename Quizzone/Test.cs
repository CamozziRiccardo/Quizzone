using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test
{
    public class Quiz : IQuestion
    {
        private List<IQuestion> questions;
        public string Text { get; set; }

        public Quiz()
        {
            questions = new List<IQuestion>();
        }

        public void AddQuestion(IQuestion question)
        {
            questions.Add(question);
        }

        public void Display()
        {
            foreach (var question in questions)
            {
                question.Display();
            }
        }

        public double GetScore(string userAnswers)
        {
            var score = 0;
            var totalQuestions = questions.Count;
            var userAnswerList = userAnswers.Split(';');

            for (int i = 0; i < totalQuestions; i++)
            {
                var userAnswer = userAnswerList[i];
                if (questions[i].CheckAnswer(userAnswer))
                {
                    score++;
                }
            }

            return (double)score / totalQuestions * 100;
        }

        public bool CheckAnswer(string userAnswer)
        {
            throw new NotImplementedException();
        }
    }
}