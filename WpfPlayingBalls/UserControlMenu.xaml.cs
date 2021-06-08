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
            TheEnd();
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

        private void TheEnd()
        {
            MessageBoxResult MBR = MessageBoxResult.Yes;
            MBR = MessageBox.Show("Czy napewno chcesz zamknąć program ?", "UWAGA", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (MBR == MessageBoxResult.Yes)
                Application.Current.Shutdown();

        }

        private void TEST_Click(object sender, RoutedEventArgs e)
        {
            WinNewGameRecord nr = new WinNewGameRecord();
            string winnerNickName = nr.GetWinnerNickName();

            MessageBox.Show(winnerNickName, "TEST", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
