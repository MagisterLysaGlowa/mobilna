using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobilna.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DicesPage : ContentPage
    {
        public DicesPage()
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