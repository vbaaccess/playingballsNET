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

namespace WpfPlayingBalls
{
    /// <summary>
    /// Logika interakcji dla klasy WinNewGameRecord.xaml
    /// </summary>
    public partial class WinNewGameRecord : Window
    {
        public WinNewGameRecord()
        {
            InitializeComponent();
        }

        public string GetWinnerNickName()
        {
            base.ShowDialog();

            //TO DO - jesli nie podano zwroc anonymous

            return this.NickName.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
