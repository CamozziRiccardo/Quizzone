using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzone
{
    public class SingleChoiceQuestion : Question
    {
        public string CorrectAnswer { get; set; }
        public Dictionary<string, bool> Choices { get; set; }

        public SingleChoiceQuestion(string text, string correctAnswer)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
            Choices = new Dictionary<string, bool>();
        }

        public override void Display()
        {
            Console.WriteLine($"{Text}");
            foreach (var choice in Choices)
            {
                Console.WriteLine($"{choice.Key}: {(choice.Value ? "Correct" : "Incorrect")}");
            }
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return Choices.ContainsKey(userAnswer) && Choices[userAnswer];
        }
    }
}