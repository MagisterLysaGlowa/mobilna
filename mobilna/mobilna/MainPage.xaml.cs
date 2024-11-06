using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Dice0.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice1.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice2.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice3.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice4.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
        }
    }
}
