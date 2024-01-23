using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzone
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> CorrectAnswers { get; set; }
        public Dictionary<string, bool> Choices { get; set; }

        public MultipleChoiceQuestion(string text, List<string> correctAnswers)
        {
            Text = text;
            CorrectAnswers = correctAnswers;
            Choices = new Dictionary<string, bool>();
        }

        public override void Display()
        {
            Console.WriteLine($"{Text}");
            foreach (var choice in Choices)
            {
                Console.WriteLine($"{choice.Key}: {(CorrectAnswers.Contains(choice.Key) ? "Correct" : "Incorrect")}");
            }
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return CorrectAnswers.Contains(userAnswer);
        }
    }
}