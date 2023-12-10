using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    public partial class AnswerPage : ContentPage
    {
        public AnswerPage(QuestionModel question)
        {
            InitializeComponent();
            BindingContext = question;
        }
    }
}