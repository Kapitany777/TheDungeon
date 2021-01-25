using Dungeon.GameData;
using Dungeon.Names;
using Dungeon.Utils;
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

namespace TheDungeon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;
        
        public MainWindow()
        {
            InitializeComponent();

            player = new Player("Feriba");

            StackPanelPlayer.DataContext = player;
        }

        private void ButtonGenerate_Click(object sender, RoutedEventArgs e)
        {
            PlayerName names = new PlayerName();
            
            TextBoxNames.Clear();

            for (int i = 0; i < 20; i++)
            {
                TextBoxNames.AppendText($"{names.NextName()}{Environment.NewLine}");
            }

            this.Title = Directories.SaveGames;
        }
    }
}
