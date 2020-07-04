using MathMultiplicationTables.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MathMultiplicationTables.Views
{
    /// <summary>
    /// Main quiz page for the app. Receives data from its viewmodel Pageviewmodel, which is create by the HomePage
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TablesPage : ContentPage
    {
        public TableViewModel _viewmodel;
        public string answer { get; set; }
        public int answered { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="viewModel"></param>
        public TablesPage(TableViewModel viewModel)
        {
            InitializeComponent();
            _viewmodel = viewModel;
            BindingContext = viewModel;
            this._viewmodel = viewModel;

            button1.Text = _viewmodel.questions[0].button1Text;
            button2.Text = _viewmodel.questions[0].button2Text;
            button3.Text = _viewmodel.questions[0].button3Text;
            question.Text = _viewmodel.questions[0].questionText;
            answer = _viewmodel.questions[0].correctAnswer;
            answered = 0;
        }

        /// <summary>
        /// Event handler for the three buttons on the page that represent the answers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void AnswerButton_Clicked(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            if (answer == button.Text)
            {
                await DisplayAlert("", "Correct " + question.Text + " = " + answer, "Ok");
                _viewmodel.correct++;
            }
            else
            {
                await DisplayAlert("", "Sorry that is wrong. \nThe correct answer is " + question.Text + " = " + answer, "Ok");                
            }

            if (answered + 1 == _viewmodel.totalQuestions)
            {
                await DisplayAlert("", "Nicely done. You have \n " + _viewmodel.correct + " out of " + _viewmodel.totalQuestions, "Ok");
                await Navigation.PopToRootAsync();
            }
            else
            {
                answered++;
                button1.Text = _viewmodel.questions[answered].button1Text;
                button2.Text = _viewmodel.questions[answered].button2Text;
                button3.Text = _viewmodel.questions[answered].button3Text;
                question.Text = _viewmodel.questions[answered].questionText;
                answer = _viewmodel.questions[answered].correctAnswer;
            }
        }
    }
}