using System;
using System.Collections.Generic;
using System.Text;

namespace MathMultiplicationTables.Models
{
    /// <summary>
    /// Basic Model that is used to generate questions and pass them to the view via the viewmodel
    /// </summary>
    public class Question
    {
        public string questionText { get; set; }
        public string correctAnswer { get; set; }
        public string button1Text { get; set; }
        public string button2Text { get; set; }
        public string button3Text { get; set; }
    }
}
