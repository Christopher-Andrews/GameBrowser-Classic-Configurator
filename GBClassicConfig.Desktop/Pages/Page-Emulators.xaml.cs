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
    public partial class Emulators : UserControl
    {
        # region - Declarations...
        public string[] xSwitches = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6" };
        public string[] xxSwitches = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6" };
        public string[] xxxSwitches = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6" };
        public string[] xxxxSwitches = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6" };
        public string[] xxxxxSwitches = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6" };
        public string[] xxxxxxSwitches = new string[] { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6" };

        #endregion


        public Emulators()
        {
            InitializeComponent();
            GameList.Items.Add(new Game() { Name = "Game 1", Platform = "Super Nintendo", Added = DateTime.Now.ToString() });
            GameList.Items.Add(new Game() { Name = "Game 2", Platform = "Playstation 2", Added = DateTime.Now.ToString() });
            GameList.Items.Add(new Game() { Name = "Game 3", Platform = "Gamecube", Added = DateTime.Now.ToString() });
        }
    }
}
