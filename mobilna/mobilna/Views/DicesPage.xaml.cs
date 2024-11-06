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
        private int gameResult = 0;
        public DicesPage()
        {
            InitializeComponent();
            Dice0.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice1.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice2.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice3.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice4.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
        }

        private void RollDices_Clicked(object sender, EventArgs e)
        {
            int[] dice = new int[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                dice[i] = random.Next(1, 7);
            }

            Dice0.Source = ImageSource.FromResource("mobilna.Images.liczba" + dice[0] +".png");
            Dice1.Source = ImageSource.FromResource("mobilna.Images.liczba" + dice[1] + ".png");
            Dice2.Source = ImageSource.FromResource("mobilna.Images.liczba" + dice[2] + ".png");
            Dice3.Source = ImageSource.FromResource("mobilna.Images.liczba" + dice[3] + ".png");
            Dice4.Source = ImageSource.FromResource("mobilna.Images.liczba" + dice[4] + ".png");


            int rollResult = 0;
            for (int dots = 1; dots < 6; dots++)
            {
                int count = 0;
                for (int diceIndex = 0; diceIndex < 5; diceIndex++)
                {
                    if (dice[diceIndex] == dots)
                    {
                        count++;
                    }
                }
                if(count > 1)
                {
                    rollResult += dots * count;
                }
            }

            rollResult_label.Text = "Wynik tego losowania: " + rollResult;
            gameResult += rollResult;
            gameResult_label.Text = "Wynik gry: " + gameResult;
        }

        private void ResetGame_Clicked(object sender, EventArgs e)
        {
            Dice0.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice1.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice2.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice3.Source = ImageSource.FromResource("mobilna.Images.question.jpg");
            Dice4.Source = ImageSource.FromResource("mobilna.Images.question.jpg");

            rollResult_label.Text = "Wynik tego losowania: ";
            gameResult = 0;
            gameResult_label.Text = "Wynik gry: ";
        }
    }
}