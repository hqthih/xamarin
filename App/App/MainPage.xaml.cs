using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        FirebaseDatabaseHelper firebaseDatabaseHelper;

        public MainPage()
        {
            InitializeComponent();
            firebaseDatabaseHelper = new FirebaseDatabaseHelper();
            LoadQuestions();
        }

        async void LoadQuestions()
        {
            var questions = await firebaseDatabaseHelper.GetQuestions();
            QuestionsListView.ItemsSource = questions;
        }

        void OnQuestionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedQuestion = (QuestionModel)e.SelectedItem;
            Navigation.PushAsync(new AnswerPage(selectedQuestion));
            QuestionsListView.SelectedItem = null;
        }
    }
}
