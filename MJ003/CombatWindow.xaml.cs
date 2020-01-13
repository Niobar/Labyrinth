using MJ003.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MJ003
{
    /// <summary>
    /// Interaction logic for CombatWindow.xaml
    /// </summary>
    public partial class CombatWindow : Window
    {
        GameWindow previousWindow;
        public CombatWindow(Monster monster, GameWindow window)
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Pages/img/dark.jpg")));
            this.Top = 1;
            this.Left = 1;
            MonsterImage.Source = new BitmapImage(new Uri(monster.ImageSource(), UriKind.Relative));
            this.Show();
            previousWindow = window;
            int[] fiveDices = CombatTurn.BeginningTurn();
            dice1.Content = fiveDices[0];
            dice2.Content = fiveDices[1];
            dice3.Content = fiveDices[2];
            dice4.Content = fiveDices[3];
            dice5.Content = fiveDices[4];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            previousWindow.Show();
            this.Close();
        }

        private void BackgroundImg_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }


        private void Dice1_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.playerCharacterWindow.testBlock.Text = dice1.Content.ToString();
        }

        private void Dice2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dice3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dice4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dice5_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.lost = true;
            this.Close();
            previousWindow.Show();
        }

    }
}
