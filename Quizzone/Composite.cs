using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzone
{
    //classe interfaccia
    public interface IQuestion
    {
        string Text { get; set; }
        void Display();
        bool CheckAnswer(string userAnswer);
    }
}