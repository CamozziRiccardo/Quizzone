using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_test
{
    //classe interfaccia
    public interface IQuestion
    {
        string Text { get; set; }
        void Display();
        bool CheckAnswer(string userAnswer);
    }

    //classe astratta
    public abstract class Question : IQuestion
    {
        public string Text { get; set; }
        public abstract void Display();
        public abstract bool CheckAnswer(string userAnswer);
    }
}