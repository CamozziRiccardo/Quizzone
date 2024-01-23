using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercitazione_test
{
    public partial class MainForm : Form
    {
        private Quiz quiz;

        public MainForm()
        {
            InitializeComponent();
            quiz = new Quiz();
        }

        private void AddQuestionButtonDisplay_Click(object sender, EventArgs e)
        {
            var questionType = QuestionTypeComboBox.SelectedItem.ToString();

            if (questionType == "Vero o Falso")
            {
                veroOFalso.Show();
            }
            else if (questionType == "Scelta Multipla")
            {
                sceltaMultipla.Show();
            }
            else if (questionType == "Scelta Singola")
            {
                sceltaSingola.Show();
            }
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            var questionType = QuestionTypeComboBox.SelectedItem.ToString();

            if (questionType == "Vero o Falso")
            {
                quiz.AddQuestion(CreateTrueFalseQuestion());
            }
            else if (questionType == "Scelta Multipla")
            {
                quiz.AddQuestion(CreateMultipleChoiceQuestion());
            }
            else if (questionType == "Scelta Singola")
            {
                quiz.AddQuestion(CreateSingleChoiceQuestion());
            }

            QuestionListBox.Items.Add(quiz.questions[quiz.questions.Count - 1].Text);
        }

        private IQuestion CreateTrueFalseQuestion()
        {
            string text;
            bool correctAnswer;

            text = TextTextBox.Text;
            correctAnswer = Convert.ToBoolean(CorrectAnswerTextBox.Text);

            return new TrueFalseQuestion(text, correctAnswer);
        }

        private IQuestion CreateMultipleChoiceQuestion()
        {
            string text;
            List<string> correctAnswers;

            text = TextTextBox.Text;
            correctAnswers = new List<string> { Choice1TextBox.Text, Choice2TextBox.Text };

            return new MultipleChoiceQuestion(text, correctAnswers);
        }

        private IQuestion CreateSingleChoiceQuestion()
        {
            string text;
            string correctAnswer;

            text = TextTextBox.Text;
            correctAnswer = Choice1TextBox.Text;

            return new SingleChoiceQuestion(text, correctAnswer);
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            quiz.Display();
        }

        private void GetScoreButton_Click(object sender, EventArgs e)
        {
            string userAnswers;
            double score;

            userAnswers = UserAnswersTextBox.Text;
            score = quiz.GetScore(userAnswers);

            MessageBox.Show($"Your score is: {score}%");
        }
    }
}