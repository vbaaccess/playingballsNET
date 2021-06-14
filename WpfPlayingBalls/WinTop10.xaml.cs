using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Logika interakcji dla klasy WinTop10.xaml
    /// </summary>
    public partial class WinTop10 : Window
    {
        ObservableCollection<ScoreData> dataGridTop10 = new ObservableCollection<ScoreData>();

        public WinTop10()
        {
            InitializeComponent();
            
            Top10LoadData();    // Przykladowe dane, docelowo z xml lokalnego PC potem z serwera z wynikami
            InitTop10List();
        }

        private void InitTop10List()
        {
            ListTop10.ItemsSource = dataGridTop10;
            

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListTop10.ItemsSource);
            ListSortDirection howToSort = ListSortDirection.Descending;
            view.SortDescriptions.Clear();

            view.SortDescriptions.Add(new SortDescription("Score", howToSort));
        }

        private void Top10LoadData()
        {
            // Przykladowe dane

            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Pawel"
              , Score = 43
              , ScoreDate = Convert.ToDateTime("2021-05-28")
              , SuscribNewGame = true
              , SuscribEmail = "pablodd@wp.pl"
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Tadeusz"
              , Score = 55
              , ScoreDate = Convert.ToDateTime("2021-06-01")
              , SuscribNewGame = true
              , SuscribEmail = "t.tyburczy@gmail.com"
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Ewa"
              , Score = 75
              , ScoreDate = Convert.ToDateTime("2021-06-05")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Olga"
              , Score = 99
              , ScoreDate = Convert.ToDateTime("2021-06-09")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Anna"
              , Score = 72
              , ScoreDate = Convert.ToDateTime("2021-06-14")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Krystyna"
              , Score = 65
              , ScoreDate = Convert.ToDateTime("2021-04-03")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Bania"
              , Score = 19
              , ScoreDate = Convert.ToDateTime("2021-04-09")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "AAdam"
              , Score = 33
              , ScoreDate = Convert.ToDateTime("2021-04-01")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Mieczyslaw"
              , Score = 25
              , ScoreDate = Convert.ToDateTime("2021-03-01")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Master"
              , Score = 54
              , ScoreDate = Convert.ToDateTime("2021-03-11")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Mieczyslaw 2"
              , Score = 25
              , ScoreDate = Convert.ToDateTime("2021-03-15")
            });
            dataGridTop10.Add(new ScoreData()
            {
                NickName = "Borys"
              , Score = 54
              , ScoreDate = Convert.ToDateTime("2021-02-22")
            });
        }

        private void ListTop10_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
