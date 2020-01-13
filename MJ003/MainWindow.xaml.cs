using MJ003.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MJ003
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlayerCharacters.PlayerCharacter.PlayerName("Unknown");
            var window = new GameWindow(new Page001());
            window.Top = 1;
            window.Left = 1;
            GlobalVariables.playerCharacterWindow.Top = 1;
            GlobalVariables.playerCharacterWindow.Left = window.Width - 12; //why it has to be less to stick to window, while when using actual width it's couple of pixels apart ?
            GlobalVariables.playerCharacterWindow.Show();
            this.Close();

        }

    }
}
