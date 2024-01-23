using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzone
{
    //classe astratta
    public abstract class Question : IQuestion
    {
        public string Text { get; set; }
        public abstract void Display();
        public abstract bool CheckAnswer(string userAnswer);
    }
}
