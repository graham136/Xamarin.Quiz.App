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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Event handler for the choice of multiplication table selected. Opens table page
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e"></param>
        async void Table_Button_Clicked(object sender, EventArgs e)
        {
            string data = ((Button)sender).BindingContext as string;
            int table = Int32.Parse(data);
            TableViewModel tableViewModel = new TableViewModel(table);
            await Navigation.PushAsync(new TablesPage(tableViewModel));
        }
        /// <summary>
        /// Event handler for the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Button_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}