using MathMultiplicationTables.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xamarin.Forms;

namespace MathMultiplicationTables.ViewModels
{
    /// <summary>
    /// View Model that current holds the date for the page Tables where the questions are asked
    /// </summary>
    public class TableViewModel : BaseViewModel
    {
        public int answered { get; set; }
        public int correct { get; set; }
        public int wrong { get; set; }
        public int totalQuestions { get; set; }
        public int multiplyTable { get; set; }
        public List<Question> questions { get; set; }

        public TableViewModel(int _multiplyTable)
        {
            Title = "Tables";
            answered = 0;
            correct = 0;
            wrong = 0;
            totalQuestions = 3;
            this.multiplyTable = _multiplyTable;

            int k = 0;            
            questions = new List<Question>();
            Random random = new Random();
            

            for (k = 0; k < totalQuestions; k++)
            {
                var question = new Question();
                int randomNumber = random.Next(1, 12);
                int correctButton = random.Next(1, 3);

                question.questionText = _multiplyTable + " x " + randomNumber;
                question.correctAnswer = (_multiplyTable * randomNumber).ToString();

                switch (correctButton)
                {
                    case 1:
                        question.button1Text = (_multiplyTable * randomNumber).ToString();
                        question.button2Text = (_multiplyTable * (randomNumber + 1)).ToString();
                        question.button3Text = (_multiplyTable * (randomNumber - 1)).ToString();
                        break;
                    case 2:
                        question.button2Text = (_multiplyTable * randomNumber).ToString();
                        question.button3Text = (_multiplyTable * (randomNumber + 1)).ToString();
                        question.button1Text = (_multiplyTable * (randomNumber - 1)).ToString();
                        break;
                    case 3:
                        question.button3Text = (_multiplyTable * randomNumber).ToString();
                        question.button1Text = (_multiplyTable * (randomNumber + 1)).ToString();
                        question.button2Text = (_multiplyTable * (randomNumber - 1)).ToString();
                        break;
                }

                questions.Add(question);
            }
        }
    }
}
