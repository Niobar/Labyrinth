using System;
using MJ003.Pages;
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
using Page = MJ003.Pages.Page;
using MJ003.Monsters;

namespace MJ003
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Page pageChoice;
        public GameWindow(Page page)
        {
            var pageButton = page.Button();
            if (GlobalVariables.lost || GlobalVariables.win)
            {
                if (GlobalVariables.lost)
                {
                    var window = new LostGame();
                    window.Show();
                }
                //if (GlobalVariables.win)
                //{
                //    var window = new WinGame();
                //    window.Show();
                //}
            }
            else
            {
                InitializeComponent();
                this.Background = new ImageBrush(new BitmapImage(new Uri(page.SourcePicture())));
                this.Top = 1;
                this.Left = 1;
                this.Show();
                Button[] buttons = new Button[]
                {
                Button001, Button002, Button003, Button004, Button005, Button006, Button007, Button008
                };
                Description.Text = page.Description();
                for (int i = 0; i < pageButton.Length / 3; i++)
                {
                    buttons[i].Content = pageButton[i, 0];
                    buttons[i].ToolTip = pageButton[i, 1];
                    buttons[i].Visibility = Visibility.Visible;
                    buttons[i].Tag = pageButton[i, 2];
                }
                pageChoice = page;
            }
        }

        private void Button001_Click(object sender, RoutedEventArgs e)
        {
            string buttonTag = Button001.Tag.ToString();
            Click(buttonTag);
            this.Close();

        }

        private void Button002_Click(object sender, RoutedEventArgs e)
        {
            string buttonTag = Button002.Tag.ToString();
            Click(buttonTag);
            this.Close();
        }
        private void Button003_Click(object sender, RoutedEventArgs e)
        {
            string buttonTag = Button003.Tag.ToString();
            Click(buttonTag);
            this.Close();
        }
        private void Click(string button)
        {
            var window = new GameWindow(pageChoice.Choice(button));
            if (MonsterPresence.monstersLedger.ContainsKey(button) && MonsterPresence.monstersLedger[button].undefeated)
            {
                window.Hide();
                var combatWindow = new CombatWindow(MonsterPresence.monstersLedger[button].monster, window);
                MonsterPresence.monstersLedger[button] = new MonsterLedger(false, null);
            }
        }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    new MainWindow().Show();
                    this.Close();
                    break;
                default:
                    break;
            }
            
        }
    }
}
