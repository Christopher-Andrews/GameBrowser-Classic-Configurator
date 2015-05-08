using GBClassicConfig.Desktop.Classes;
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

namespace GBClassicConfig.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for Page_Test.xaml
    /// </summary>
    public partial class Windows : UserControl
    {
        public Windows()
        {
            InitializeComponent();
            GameList.Items.Add(new Game() { Name = "Game 1", Platform = "Steam", Added = DateTime.Now.ToString() });
            GameList.Items.Add(new Game() { Name = "Game 2", Platform = "GOG", Added = DateTime.Now.ToString() });
            GameList.Items.Add(new Game() { Name = "Game 3", Platform = "Origin", Added = DateTime.Now.ToString() });
        }
    }
}
