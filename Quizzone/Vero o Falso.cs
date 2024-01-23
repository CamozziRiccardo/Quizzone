using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzone
{
    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string text, bool correctAnswer)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
        }

        public override void Display()
        {
            Console.WriteLine($"{Text} (True or False)");
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return userAnswer.ToLower() == "true" == CorrectAnswer;
        }
    }
}