using MJ003.PlayerCharacters;
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
    /// Interaction logic for Character.xaml
    /// </summary>
    public partial class CharacterWindow : Window
    {
        public CharacterWindow()
        {
            InitializeComponent();
            CharacterName.Text = PlayerCharacter.Name;
            //this.Show();
        }
    }
}
