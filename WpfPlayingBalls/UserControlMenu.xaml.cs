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

namespace WpfPlayingBalls
{
    /// <summary>
    /// Logika interakcji dla klasy UserControlMenu.xaml
    /// </summary>
    public partial class UserControlMenu : UserControl
    {
        public UserControlMenu()
        {
            InitializeComponent();
        }

        private void CommandBindings_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBindings_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // TO DO - ask for approval if the game is in progress
            Application.Current.Shutdown();
        }

        private void OProgramie_Click(object sender, RoutedEventArgs e)
        {
            WinAbaut win = new WinAbaut();
            win.Show();
        }

        private void Top10_Click(object sender, RoutedEventArgs e)
        {
            WinTop10 win = new WinTop10();
            win.Show();
        }
    }
}
